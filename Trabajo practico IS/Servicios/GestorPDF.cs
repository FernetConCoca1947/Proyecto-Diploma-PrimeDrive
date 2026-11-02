using PdfSharp;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDev.HtmlRenderer.PdfSharp;



namespace Servicios
{
    public static class GestorPDF
    {
        public static void GenerarPdfDesdeHtml(string contenidoHtml, string rutaArchivoDestino)
        {
            PdfDocument documentoPdf = PdfGenerator.GeneratePdf(contenidoHtml, PageSize.A4);
            documentoPdf.Save(rutaArchivoDestino);
        }

        public static void GenerarComprobanteCheckIn(BE.CONTRATO contrato,string nivelCombustible,decimal montoDanos,string rutaArchivoDestino)
        {
            string html = ConstruirHtmlCheckIn(contrato, nivelCombustible, montoDanos);
            GenerarPdfDesdeHtml(html, rutaArchivoDestino);
        }

        private static string ConstruirHtmlCheckIn(BE.CONTRATO c, string nivelCombustible, decimal montoDanos)
        {
            DateTime fechaDevolucion = c.FechaHoraDevolucion ?? DateTime.Now;
            int diasReales = Math.Max(1, (fechaDevolucion.Date - c.FechaHoraRetiro.Date).Days);
            int kmSalida = c.KmSalida;
            int kmEntrada = c.KmEntrada ?? kmSalida;
            int kmRecorridos = Math.Max(0, kmEntrada - kmSalida);

            decimal tarifaDiaria = c.Reserva.Categoria.TarifaDiaria;
            decimal subtotalAlquiler = diasReales * tarifaDiaria;
            decimal montoFinal = c.MontoFinal ?? subtotalAlquiler;
            decimal recargoCombustible = Math.Max(0, montoFinal - subtotalAlquiler - montoDanos);

            string operadorActual = SESION.GetInstancia().usuactual != null
                ? SESION.GetInstancia().usuactual.Usuario
                : "Mostrador";

            bool tieneAlerta = !string.IsNullOrWhiteSpace(c.Vehiculo.ObservacionRevision);
            string estadoInspeccion = tieneAlerta
                ? $"CON ALERTA TÉCNICA ({c.Vehiculo.ObservacionRevision})"
                : "APROBADO - Unidad recibida en óptimas condiciones operativas";

            string observacionesContrato = string.IsNullOrWhiteSpace(c.Observaciones)
                ? "Sin observaciones adicionales registradas."
                : c.Observaciones;

            return $@"
            <html>
            <head>
                <style>
                    body {{ font-family: Arial, sans-serif; color: #2c3e50; margin: 25px; font-size: 11px; }}
                    table.header-table {{ width: 100%; border-collapse: collapse; background-color: #006666; color: white; }}
                    table.header-table td {{ padding: 16px; vertical-align: middle; }}
                    .brand-title {{ font-size: 20px; font-weight: bold; letter-spacing: 1px; }}
                    .brand-sub {{ font-size: 10px; color: #d0ece7; margin-top: 4px; }}
                    .doc-box {{ text-align: right; font-size: 11px; line-height: 1.5; }}
                    .doc-num {{ font-size: 15px; font-weight: bold; color: #ffffff; }}
                    .section-title {{ background-color: #e8f4f4; color: #006666; font-weight: bold; font-size: 11px; padding: 7px 10px; margin-top: 18px; border-left: 4px solid #008080; }}
                    table.info-grid {{ width: 100%; border-collapse: collapse; margin-top: 8px; }}
                    table.info-grid td {{ width: 50%; border: 1px solid #cccccc; padding: 10px; vertical-align: top; line-height: 1.7; }}
                    .label-title {{ color: #008080; font-weight: bold; font-size: 11px; margin-bottom: 5px; border-bottom: 1px solid #eeeeee; padding-bottom: 3px; }}
                    table.audit-table {{ width: 100%; border-collapse: collapse; margin-top: 8px; }}
                    table.audit-table th {{ background-color: #546e7a; color: white; padding: 7px; font-size: 10px; text-align: center; border: 1px solid #546e7a; }}
                    table.audit-table td {{ padding: 8px; font-size: 10px; text-align: center; border: 1px solid #cccccc; }}
                    table.finance-table {{ width: 100%; border-collapse: collapse; margin-top: 8px; }}
                    table.finance-table th {{ background-color: #008080; color: white; padding: 8px; font-size: 10px; text-align: left; }}
                    table.finance-table td {{ padding: 9px 8px; font-size: 10px; border-bottom: 1px solid #dddddd; }}
                    .right {{ text-align: right; }}
                    .center {{ text-align: center; }}
                    .bold {{ font-weight: bold; }}
                    table.total-box {{ width: 100%; border-collapse: collapse; margin-top: 12px; background-color: #f4f9f9; border: 2px solid #006666; }}
                    table.total-box td {{ padding: 12px; font-size: 14px; font-weight: bold; color: #006666; }}
                    .obs-box {{ border: 1px solid #cccccc; background-color: #fafafa; padding: 10px; margin-top: 8px; font-size: 10px; line-height: 1.5; }}
                    .legal-text {{ font-size: 9px; color: #666666; text-align: justify; margin-top: 20px; line-height: 1.4; }}
                    table.signatures {{ width: 100%; border-collapse: collapse; margin-top: 55px; }}
                    table.signatures td {{ width: 45%; text-align: center; font-size: 10px; color: #444444; padding-top: 8px; }}
                    .sig-line {{ border-top: 1px solid #333333; width: 80%; margin: 0 auto; padding-top: 6px; font-weight: bold; }}
                    .footer {{ margin-top: 25px; text-align: center; font-size: 9px; color: #888888; border-top: 1px solid #dddddd; padding-top: 8px; }}
                </style>
            </head>
            <body>
                <table class='header-table'>
                    <tr>
                        <td>
                            <div class='brand-title'>PRIME DRIVE S.A.</div>
                            <div class='brand-sub'>Sistema Corporativo de Gestión y Alquiler de Flota Vehicular</div>
                            <div class='brand-sub'>CUIT: 30-71589412-9 | IVA Responsable Inscripto</div>
                        </td>
                        <td class='doc-box'>
                            <div class='doc-num'>COMPROBANTE DE LIQUIDACIÓN FINAL</div>
                            <div>Contrato Nro: #{c.Id:D5} | Reserva Ref: #{c.Reserva.Id:D5}</div>
                            <div>Fecha de Emisión: {DateTime.Now:dd/MM/yyyy HH:mm} hs</div>
                            <div>Operador de Recepción: {operadorActual}</div>
                        </td>
                    </tr>
                </table>

                <div class='section-title'>1. IDENTIFICACIÓN DE LAS PARTES Y UNIDAD ASIGNADA</div>
                <table class='info-grid'>
                    <tr>
                        <td>
                            <div class='label-title'>DATOS DEL CLIENTE TITULAR</div>
                            Apellido y Nombre: {c.Reserva.Cliente.Apellido}, {c.Reserva.Cliente.Nombre}<br/>
                            Documento (DNI): {c.Reserva.Cliente.DNI}<br/>
                            Condición de Contrato: Particular - Garantía Preautorizada<br/>
                            Estado del Trámite: CERRADO Y LIQUIDADO
                        </td>
                        <td>
                            <div class='label-title'>UNIDAD FÍSICA Y SEGMENTO</div>
                            Vehículo: {c.Vehiculo.ToString()}<br/>
                            Categoría Tarifaria: {c.Reserva.Categoria.Nombre}<br/>
                            Tarifa Diaria Aplicada: $ {tarifaDiaria:N2}<br/>
                            Estado de Garantía: LIBERADA ($ {c.GarantiaRetenida:N2})
                        </td>
                    </tr>
                </table>

                <div class='section-title'>2. REGISTRO DE TELEMETRÍA Y AUDITORÍA FÍSICA (CHECK-OUT VS. CHECK-IN)</div>
                <table class='audit-table'>
                    <thead>
                        <tr>
                            <th>Fecha/Hora Retiro</th>
                            <th>Fecha/Hora Devolución</th>
                            <th>Días Computados</th>
                            <th>Kilometraje Salida</th>
                            <th>Kilometraje Entrada</th>
                            <th>Km Recorridos</th>
                            <th>Nivel Combustible</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>{c.FechaHoraRetiro:dd/MM/yyyy HH:mm}</td>
                            <td>{fechaDevolucion:dd/MM/yyyy HH:mm}</td>
                            <td class='bold'>{diasReales} día(s)</td>
                            <td>{kmSalida:N0} km</td>
                            <td>{kmEntrada:N0} km</td>
                            <td class='bold'>{kmRecorridos:N0} km</td>
                            <td>{nivelCombustible}</td>
                        </tr>
                    </tbody>
                </table>
                <div class='obs-box'>
                    Dictamen Técnico de Recepción: {estadoInspeccion}<br/>
                    Historial de Observaciones del Contrato: {observacionesContrato}
                </div>

                <div class='section-title'>3. DETALLE DE LIQUIDACIÓN ECONÓMICA Y CARGOS</div>
                <table class='finance-table'>
                    <thead>
                        <tr>
                            <th>Código</th>
                            <th>Concepto / Descripción del Cargo</th>
                            <th class='center'>Cantidad / Base</th>
                            <th class='right'>Precio Unitario</th>
                            <th class='right'>Subtotal ($)</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>ALQ-01</td>
                            <td>Alquiler por Días de Uso ({c.Reserva.Categoria.Nombre})</td>
                            <td class='center'>{diasReales} día(s)</td>
                            <td class='right'>$ {tarifaDiaria:N2}</td>
                            <td class='right'>$ {subtotalAlquiler:N2}</td>
                        </tr>
                        <tr>
                            <td>CMB-02</td>
                            <td>Cargo por Faltante de Combustible (Nivel reportado: {nivelCombustible})</td>
                            <td class='center'>1 ajuste</td>
                            <td class='right'>$ {recargoCombustible:N2}</td>
                            <td class='right'>$ {recargoCombustible:N2}</td>
                        </tr>
                        <tr>
                            <td>DAN-03</td>
                            <td>Cargos por Daños Físicos / Penalidades de Inspección</td>
                            <td class='center'>1 auditoría</td>
                            <td class='right'>$ {montoDanos:N2}</td>
                            <td class='right'>$ {montoDanos:N2}</td>
                        </tr>
                    </tbody>
                </table>

                <table class='total-box'>
                    <tr>
                        <td>IMPORTE TOTAL FINAL COBRADO</td>
                        <td class='right'>$ {montoFinal:N2}</td>
                    </tr>
                </table>

                <div class='legal-text'>
                    El presente comprobante acredita la recepción definitiva del vehículo detallado y la cancelación total de los cargos derivados del contrato de locación #{c.Id:D5}. Habiéndose verificado la liberación de la garantía preautorizada en la terminal electrónica (Posnet), las partes declaran no tener reclamos económicos pendientes por los conceptos aquí liquidados.
                </div>

                <table class='signatures'>
                    <tr>
                        <td>
                            <div class='sig-line'>Firma y Aclaración del Cliente</div>
                            <div>{c.Reserva.Cliente.Apellido}, {c.Reserva.Cliente.Nombre} (DNI {c.Reserva.Cliente.DNI})</div>
                        </td>
                        <td style='width: 10%;'></td>
                        <td>
                            <div class='sig-line'>Por Prime Drive S.A. (Recepción y Flota)</div>
                            <div>Operador: {operadorActual} - Sello de Sucursal</div>
                        </td>
                    </tr>
                </table>

                <div class='footer'>
                    Documento oficial generado electrónicamente por Prime Drive v1.5 - Impreso el {DateTime.Now:dd/MM/yyyy a las HH:mm:ss}
                </div>
            </body>
            </html>";
        }
    }
}

