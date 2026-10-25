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

        // CU07: Motor Algorítmico de Diagnóstico
        public List<BE.DIAGNOSTICO_OCUPACION> AnalizarOcupacionSucursal(int idSucursal, DateTime desde, DateTime hasta)
        {
            if (desde.Date < DateTime.Today)
                throw new Exception("El análisis comercial debe realizarse sobre fechas actuales o futuras.");
            if (desde > hasta)
                throw new Exception("La fecha de inicio no puede ser posterior a la fecha de fin.");

            List<BE.DIAGNOSTICO_OCUPACION> metricas = mapper.ObtenerMetricasOcupacion(idSucursal, desde, hasta);

            // 1. Primera pasada: Calcular porcentajes de ocupación matemática
            foreach (var item in metricas)
            {
                if (item.TotalFlota == 0)
                {
                    item.PorcentajeOcupacion = 0;
                    item.DiagnosticoCorto = "⚪ Sin Flota Asignada";
                    item.TipoAccionSugerida = "Ninguna";
                    item.ExplicacionDetallada = "No hay vehículos operativos de esta categoría en la sucursal.";
                    continue;
                }

                item.PorcentajeOcupacion = Math.Round(((decimal)item.VehiculosReservados / item.TotalFlota) * 100, 2);
                if (item.PorcentajeOcupacion > 100) item.PorcentajeOcupacion = 100;
            }

            // 2. Segunda pasada: Clasificar saturadas (>= 80%), ociosas (<= 30%) y cruzar para Upgrades
            foreach (var item in metricas.Where(x => x.TotalFlota > 0))
            {
                if (item.PorcentajeOcupacion >= 80)
                {
                    item.DiagnosticoCorto = "🔴 Saturada (Origen)";
                    item.TipoAccionSugerida = "Ninguna";
                    int libres = Math.Max(0, item.TotalFlota - item.VehiculosReservados);
                    item.ExplicacionDetallada = $"Categoría al límite ({item.PorcentajeOcupacion}% de ocupación, quedan {libres} unidades). Evaluar desbloqueo con categoría superior.";
                }
                else if (item.PorcentajeOcupacion <= 30)
                {
                    // Buscamos si existe una categoría de MENOR tarifa que esté saturada (>= 80%)
                    var catSaturadaInferior = metricas
                        .Where(x => x.TotalFlota > 0
                                 && x.PorcentajeOcupacion >= 80
                                 && x.Categoria.TarifaDiaria < item.Categoria.TarifaDiaria)
                        .OrderByDescending(x => x.Categoria.TarifaDiaria) // La inmediata inferior más cercana
                        .FirstOrDefault();

                    if (catSaturadaInferior != null)
                    {
                        // Caso CU09: UPGRADE ESTRATÉGICO
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
                        // Caso CU08: BAJA DEMANDA PURA (No hay categoría inferior saturada, solo estancamiento)
                        decimal descuentoSugerido = 20.00m; // Regla base del 20% OFF para reactivar demanda
                        item.DiagnosticoCorto = "⚠️ Baja Demanda Pura";
                        item.TipoAccionSugerida = "Baja Demanda";
                        item.CategoriaOrigenSaturada = null;
                        item.DescuentoSugerido = descuentoSugerido;
                        item.TarifaFinalSugerida = Math.Round(item.Categoria.TarifaDiaria * (1 - (descuentoSugerido / 100)), 2);
                        item.ExplicacionDetallada = $"Ocupación crítica del {item.PorcentajeOcupacion}%. Se sugiere lanzar una promoción directa del {descuentoSugerido}% OFF para incentivar el alquiler del segmento {item.Categoria.Nombre}.";
                    }
                }
                else
                {
                    item.DiagnosticoCorto = "✅ Ocupación Normal";
                    item.TipoAccionSugerida = "Ninguna";
                    item.DescuentoSugerido = 0;
                    item.TarifaFinalSugerida = item.Categoria.TarifaDiaria;
                    item.ExplicacionDetallada = "La categoría presenta un nivel de demanda equilibrado. No requiere intervención comercial.";
                }
            }

            return metricas;
        }

        // CU08 y CU09: Aprobación y lanzamiento
        public void AprobarPromocion(BE.PROMOCION promo)
        {
            if (promo.PorcentajeDescuento <= 0 || promo.PorcentajeDescuento > 50)
                throw new Exception("Por políticas de rentabilidad, el descuento debe situarse entre el 1% y el 50% como máximo (Flujo Alternativo 4.1).");

            if (string.IsNullOrWhiteSpace(promo.Motivo))
                throw new Exception("Debe especificar el motivo o justificación comercial de la promoción.");

            bool exito = mapper.RegistrarPromocion(promo);
            if (!exito)
                throw new Exception("Error en la base de datos al intentar activar la promoción.");
        }
    }
}
