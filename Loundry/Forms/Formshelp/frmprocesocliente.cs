using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InputKey;

namespace Loundry
{
    public partial class frmprocesocliente : Form
    {
        public string retornaccliente;
        public string retornaRsocial;
        public string retornaDomicilio;
        public string retornaTdoc;
        public string retornaNcuit;
        public string retornaIva;
        public string retornaLp;
        public string retornasaldocliente;

        public frmprocesocliente()
        {
            InitializeComponent();
        }

        private void btnrefreshclie_Click(object sender, EventArgs e)
        {
            abmproceso.refresh(ref dgvcliente, "Select * from cliente");
        }

        private void btnbuscaclie_Click(object sender, EventArgs e)
        {
            abmproceso.buscarcliente(ref dgvcliente);
        }

        private void frmprocesocliente_Load(object sender, EventArgs e)
        {
            configuracion.confdgv(dgvcliente, "",12, true);
            btnrefreshclie.PerformClick();
        }

        private void dgvcliente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int puntero = dgvcliente.CurrentRow.Index;
            retornaccliente = libreria.valorcelda(puntero, dgvcliente, "codigo", " ");

            if (retornaccliente == "0000")
            {
                //hago q ingrese el dni del cliente
                //string dato = InputDialog.mostrar("Ingrese DNI del cliente (SIN PUNTOS, SOLO NUMEROS)");
                //lo grabo en base cliente
                //string consulta = "update cliente set ndni='"+dato+"' where codigo='0000'";
                //bdcomun.ejecuta(consulta);
                //abmcliente.CF_ingresa();
                retornaRsocial = bdcomun.contenidocampo("Select * from cliente where codigo='0000'", "rsocial");
                retornaDomicilio = bdcomun.contenidocampo("Select * from cliente where codigo='0000'", "domicilio");
            }
            else
            {
                retornaRsocial = libreria.valorcelda(puntero, dgvcliente, "rsocial", " ");
                retornaDomicilio = libreria.valorcelda(puntero, dgvcliente, "domicilio", " ");
            }

            retornaccliente = libreria.rellena(retornaccliente, 4);
            retornaTdoc = libreria.valorcelda(puntero, dgvcliente, "dni", " ");
            retornaNcuit = libreria.valorcelda(puntero, dgvcliente, "ncuit", " ");
            retornaIva = libreria.valorcelda(puntero, dgvcliente, "iva", " ");
            retornaLp = libreria.valorcelda(puntero, dgvcliente, "lp", " ");
            retornasaldocliente = bdcomun.contenidocampo("Select importe from ctactecliente where ccliente='" + 
                                  retornaccliente + "' order by pk desc limit 1", "importe");

            DialogResult = DialogResult.OK; //cierra el formulario
            this.Close();
        }

        private void frmprocesocliente_Leave(object sender, EventArgs e)
        {

        }

    }
}
