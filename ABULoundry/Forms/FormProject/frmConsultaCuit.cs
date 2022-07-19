using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loundry
{
    public partial class frmConsultaCuit : Form
    {
        public string retornaNombreclie;
        public string retornaTipoDocClie;
        public string retornaNroDocClie;
        public string retornaTipoPersona;
        public string retornaIdPersona;
        public string retornaDireccion;
        public string retornaCondIva;
        public string retornaDescIva;
        public string retornaCuit;

        public frmConsultaCuit()
        {
            InitializeComponent();
        }

        private void btnConsultaCuit_Click(object sender, EventArgs e)
        {
            FEAFIPLib.BIWSFEV1 wsfev1 = new FEAFIPLib.BIWSFEV1();
            wsfev1.ModoProduccion = Properties.Settings.Default.afipmodoproduccion; 
                                    // En modo testing la consulta arroja que no hay resultados con infinidad de cuits
                                    // Debe agregarce en la ppagina de AFIP el web service de consulta padron A4. Desde el administrador de relaciones

            if (wsfev1.login(Properties.Settings.Default.afipcertificado,
                             Properties.Settings.Default.afippassword,
                             Properties.Settings.Default.afippadrona4))
            {
                ConsultaCuitResponse r = null;
                //30610171601
                if (wsfev1.ConsultaCUIT(Convert.ToInt64(txtcuitconsulta.Text), ref r))
                {
                    configuracion.mensaje(
                                    " Nombre: " + r.nombre + " " + r.tipoDocumento + " " + r.numeroDocumento +
                                    " Persona: " + r.tipoPersona + " " + r.idPersona +
                                    " Domicilio: " + r.domicilioFiscal_direccion + r.domicilioFiscal_localidad +
                                                   r.domicilioFiscal_idProvincia + r.domicilioFiscal_codPostal +
                                    " Iva: " + r.condicionIVA + r.condicionIVADesc
                                    );
                    List<ClienteDatos> lst = new List<ClienteDatos>();
                    lst.Add(new ClienteDatos
                    {
                        nombre = r.nombre,
                        tipoDocumento = r.tipoDocumento,
                        nroDocumento = r.numeroDocumento,
                        tipoPersona = r.tipoPersona,
                        idPersona = r.idPersona.ToString(),
                        domicilioFiscal_direccion = r.domicilioFiscal_direccion,
                        domicilioFiscal_localidad = r.domicilioFiscal_localidad,
                        domicilioFiscal_idProvincia = r.domicilioFiscal_idProvincia.ToString(),
                        domicilioFiscal_codPostal = r.domicilioFiscal_codPostal,
                        condicionIVA = r.condicionIVA.ToString(),
                        condicionIVADesc = r.condicionIVADesc
                    });
                    txtNombreclie.Text = lst[0].nombre;
                    txtTipoDocClie.Text = lst[0].tipoDocumento;
                    txtNroDocClie.Text = lst[0].nroDocumento;
                    txtTipoPersona.Text = lst[0].tipoPersona;
                    txtIdPersona.Text = lst[0].idPersona;
                    txtDireccion.Text = lst[0].domicilioFiscal_direccion + ", " + lst[0].domicilioFiscal_localidad + ", " +
                                      lst[0].domicilioFiscal_idProvincia.ToString() + ", " + lst[0].domicilioFiscal_codPostal;
                    txtCondIva.Text = lst[0].condicionIVA;
                    txtDescIva.Text = lst[0].condicionIVADesc;
                    //libreria.seleccionaitemcombo(ref cmbTipoResponsable, libreria.rellena(txtCondIva.Text, 2));
                }
                else
                {
                    MessageBox.Show(wsfev1.ErrorDesc);
                }
            }
            else
            {
                MessageBox.Show(wsfev1.ErrorDesc);
            }
        }

        private void btnTransfiere_Click(object sender, EventArgs e)
        {
            retornaNombreclie=txtNombreclie.Text ;
            retornaTipoDocClie=txtTipoDocClie.Text;
            retornaNroDocClie=txtNroDocClie.Text ;
            retornaTipoPersona= txtTipoPersona.Text;
            retornaIdPersona=txtIdPersona.Text;
            retornaDireccion=txtDireccion.Text;
            retornaCondIva=txtCondIva.Text;
            retornaDescIva=txtDescIva.Text;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmConsultaCuit_Load(object sender, EventArgs e)
        {
            txtcuitconsulta.Text = retornaCuit;
        }
    }
}
