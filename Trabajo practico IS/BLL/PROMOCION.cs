using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PROMOCION
    {
        private DAL.MP_PROMOCION mapper = new DAL.MP_PROMOCION();

        // =========================================================================
        // 1. CU07: MOTOR ALGORÍTMICO DE DIAGNÓSTICO DE OCUPACIÓN Y ALERTAS
        // =========================================================================
        public List<BE.DIAGNOSTICO_OCUPACION> AnalizarOcupacionSucursal(int idSucursal, DateTime desde, DateTime hasta)
        {
            if (idSucursal <= 0)
                throw new Exception("Debe seleccionar una sucursal válida.");

            if (desde.Date < DateTime.Today)
                throw new Exception("El análisis comercial debe realizarse sobre fechas actuales o futuras.");

            if (desde.Date > hasta.Date)
                throw new Exception("La fecha de inicio no puede ser posterior a la fecha de fin.");

            int diasAuditados = (hasta.Date - desde.Date).Days + 1;

            List<BE.DIAGNOSTICO_OCUPACION> metricas = mapper.ObtenerMetricasOcupacion(idSucursal, desde.Date, hasta.Date);

            // Primera pasada: Calcular porcentajes de ocupación real por categoría
            foreach (var item in metricas)
            {

                item.UnidadesOciosas = Math.Max(0, item.TotalFlota - item.VehiculosReservados);
                item.LucroCesante = item.UnidadesOciosas * item.Categoria.TarifaDiaria * diasAuditados;

                if (item.TotalFlota == 0)
                {
                    item.PorcentajeOcupacion = 0;
                    item.DiagnosticoCorto = "⚪ Sin Flota Asignada";
                    item.TipoAccionSugerida = "Ninguna";
                    item.DescuentoSugerido = 0;
                    item.TarifaFinalSugerida = item.Categoria.TarifaDiaria;
                    item.ExplicacionDetallada = "No hay vehículos operativos de esta categoría en la sucursal.";
                    continue;
                }

                item.PorcentajeOcupacion = Math.Round(((decimal)item.VehiculosReservados / item.TotalFlota) * 100, 2);
                if (item.PorcentajeOcupacion > 100)
                    item.PorcentajeOcupacion = 100;
            }

            // Segunda pasada: Clasificar saturadas (>= 80%), ociosas (<= 30%) y cruzar para Upgrades
            foreach (var item in metricas.Where(x => x.TotalFlota > 0))
            {
                if (item.PorcentajeOcupacion >= 80)
                {
                    item.DiagnosticoCorto = "🔴 Saturada (Origen)";
                    item.TipoAccionSugerida = "Ninguna";
                    item.DescuentoSugerido = 0;
                    item.TarifaFinalSugerida = item.Categoria.TarifaDiaria;

                    int libres = Math.Max(0, item.TotalFlota - item.VehiculosReservados);
                    item.ExplicacionDetallada = $"Categoría al límite ({item.PorcentajeOcupacion}% de ocupación, quedan {libres} unidades). Evaluar desbloqueo con categoría superior.";
                }
                else if (item.PorcentajeOcupacion <= 30)
                {
                    // Buscamos si existe una categoría de MENOR tarifa en la misma sucursal que esté saturada (>= 80%)
                    var catSaturadaInferior = metricas
                        .Where(x => x.TotalFlota > 0
                                 && x.PorcentajeOcupacion >= 80
                                 && x.Categoria.TarifaDiaria < item.Categoria.TarifaDiaria)
                        .OrderByDescending(x => x.Categoria.TarifaDiaria) // La inmediata inferior más cercana en precio
                        .FirstOrDefault();

                    if (catSaturadaInferior != null)
                    {
                        // Caso CU09: UPGRADE ESTRATÉGICO (Desbloqueo de Stock)
                        decimal descuentoUpgrade = Math.Round((1 - (catSaturadaInferior.Categoria.TarifaDiaria / item.Categoria.TarifaDiaria)) * 100, 2);

                        item.DiagnosticoCorto = $"🟢 Upgrade desde {catSaturadaInferior.Categoria.Nombre}";
                        item.TipoAccionSugerida = "Upgrade Estratégico";
                        item.CategoriaOrigenSaturada = catSaturadaInferior.Categoria;
                        item.DescuentoSugerido = descuentoUpgrade;
                        item.TarifaFinalSugerida = catSaturadaInferior.Categoria.TarifaDiaria;
                        item.ExplicacionDetallada = $"{catSaturadaInferior.Categoria.Nombre} está al {catSaturadaInferior.PorcentajeOcupacion}% de ocupación, pero hay {item.TotalFlota - item.VehiculosReservados} unidades de {item.Categoria.Nombre} libres. Sugerencia: Igualar tarifa aplicando {descuentoUpgrade}% OFF sobre {item.Categoria.Nombre}.";
                    }
                    else
                    {
                        // Caso CU08: BAJA DEMANDA PURA (Estancamiento sin categoría inferior saturada)
                        decimal descuentoSugerido = 20.00m;

                        item.DiagnosticoCorto = "⚠️ Baja Demanda Pura";
                        item.TipoAccionSugerida = "Baja Demanda";
                        item.CategoriaOrigenSaturada = null;
                        item.DescuentoSugerido = descuentoSugerido;
                        item.TarifaFinalSugerida = Math.Round(item.Categoria.TarifaDiaria * (1 - (descuentoSugerido / 100m)), 2);
                        item.ExplicacionDetallada = $"Ocupación crítica del {item.PorcentajeOcupacion}%. Se sugiere lanzar una promoción directa del {descuentoSugerido}% OFF para incentivar el alquiler del segmento {item.Categoria.Nombre}.";
                    }
                }
                else
                {
                    item.DiagnosticoCorto = "✅ Ocupación Normal";
                    item.TipoAccionSugerida = "Ninguna";
                    item.CategoriaOrigenSaturada = null;
                    item.DescuentoSugerido = 0;
                    item.TarifaFinalSugerida = item.Categoria.TarifaDiaria;
                    item.ExplicacionDetallada = "La categoría presenta un nivel de demanda equilibrado. No requiere intervención comercial.";
                }
            }

            return metricas;
        }

        // =========================================================================
        // 2. CU08 y CU09: VALIDACIÓN DE REGLAS DE NEGOCIO Y ALTA DE PROMOCIÓN
        // =========================================================================
        public void AprobarPromocion(BE.PROMOCION promo)
        {
            if (promo == null)
                throw new Exception("Los datos de la promoción no son válidos.");

            if (string.IsNullOrWhiteSpace(promo.Nombre))
                throw new Exception("Debe ingresar un nombre identificatorio para la promoción.");

            if (promo.Sucursal == null || promo.Sucursal.Id <= 0)
                throw new Exception("Debe especificar una sucursal válida.");

            if (promo.CategoriaObjetivo == null || promo.CategoriaObjetivo.Id <= 0)
                throw new Exception("Debe especificar la categoría objetivo de la promoción.");

            // Validaciones lógicas de fechas en memoria (evita viaje innecesario a la BD)
            if (promo.FechaDesde.Date < DateTime.Today)
                throw new Exception("La promoción no puede iniciar en una fecha pasada.");

            if (promo.FechaDesde.Date > promo.FechaHasta.Date)
                throw new Exception("La fecha de inicio no puede ser posterior a la fecha de fin.");

            // Validación de políticas de rentabilidad (Flujo Alternativo 4.1 de CU09)
            if (promo.PorcentajeDescuento <= 0 || promo.PorcentajeDescuento > 50)
                throw new Exception("Por políticas de rentabilidad, el porcentaje de descuento debe situarse entre el 1% y el 50%.");

            if (string.IsNullOrWhiteSpace(promo.Motivo))
                throw new Exception("Debe especificar el motivo o justificación comercial de la promoción.");

            // Validación de no superposición de ofertas (Flujo Alternativo 4.1 de CU08)
            int promocionesSolapadas = mapper.ValidarSolapamiento(
                promo.Sucursal.Id,
                promo.CategoriaObjetivo.Id,
                promo.FechaDesde.Date,
                promo.FechaHasta.Date
            );

            if (promocionesSolapadas > 0)
                throw new Exception($"Ya existe una promoción activa para la categoría {promo.CategoriaObjetivo.Nombre} en {promo.Sucursal.Nombre} durante el rango de fechas seleccionado.");

            bool exito = mapper.RegistrarPromocion(promo);
            if (!exito)
                throw new Exception("Ocurrió un error en la base de datos al intentar activar la promoción.");
        }

        // =========================================================================
        // 3. LISTAR PROMOCIONES VIGENTES EN MOSTRADOR
        // =========================================================================
        public List<BE.PROMOCION> ListarPromocionesActivas()
        {
            return mapper.Listar();
        }

        // =========================================================================
        // 4. DESACTIVAR PROMOCIÓN (BAJA LÓGICA)
        // =========================================================================
        public void DesactivarPromocion(int idPromocion)
        {
            if (idPromocion <= 0)
                throw new Exception("Debe seleccionar una promoción válida para desactivar.");

            bool exito = mapper.DesactivarPromocion(idPromocion);
            if (!exito)
                throw new Exception("No se pudo desactivar la promoción seleccionada en la base de datos.");
        }
    }
}
