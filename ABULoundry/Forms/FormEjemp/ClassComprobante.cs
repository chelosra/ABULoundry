using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loundry
{
    class ClassComprobante
    {
        public string PtoVta { get; set; }
        public string Nro { get; set; }
        public string CbteFch { get; set; }//    Fecha del comprobante.
        public string FchVto { get; set; }//  Fecha de vencimiento.
        public string ImpTotal { get; set; }//   Importe total del comprobante.
        public string ImpNeto { get; set; }//    Importe neto gravado.
        public string ImpIVA { get; set; }// Suma de los importes del array de IVA.
        public string DocTipo { get; set; }//     Código de documento identificatorio del comprador.
        public string DocNro { get; set; }//Nro. de identificación del comprador.
        public string FchVtoPago { get; set; }//     Fecha de vencimiento del pago servicio a facturar.

        public string CodAutorizacion { get; set; }//     CAE.
        public string FchProceso { get; set; }//  Fecha de procesamiento.
        public string Concepto { get; set; }//    Concepto del comprobante.
        public string CbteDesde { get; set; }//  Nro.de comprobante desde.
        public string CbteHasta { get; set; }//  Nro.de comprobante registrado hasta.
        public string ImpTotConc { get; set; }// Importe neto no gravado.
        public string ImpOpEx { get; set; }//    Importe exento.
        public string ImpTrib { get; set; }//    Suma de los importes del array de tributos.
        public string FchServDesde { get; set; }//   Fecha de inicio del abono para el servicio a facturar.
        public string FchServHasta { get; set; }//   Fecha de fin del abono para el servicio a facturar.
        public string MonId { get; set; }//  Código de moneda del comprobante.
        public string MonCotiz { get; set; }//   Cotización de la moneda informada.
        public string CbteTipo { get; set; }
        public string Iva { get; set; }
        public string Resultado { get; set; }

    }
}
