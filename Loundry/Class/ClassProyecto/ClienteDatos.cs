using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loundry
{
    public class ClienteDatos
    {
        public string nombre { get; set; }
        public string tipoDocumento { get; set; }
        public string nroDocumento { get; set; }
        public string tipoPersona { get; set; }
        public string idPersona { get; set; }
        public string domicilioFiscal_direccion { get; set; }
        public string domicilioFiscal_localidad { get; set; }
        public string domicilioFiscal_idProvincia { get; set; }
        public string domicilioFiscal_codPostal { get; set; }
        public string condicionIVA { get; set; }
        public string condicionIVADesc { get; set; }

    }
}
