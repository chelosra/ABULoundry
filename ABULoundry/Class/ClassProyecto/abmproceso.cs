using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;
using InputKey;

namespace Loundry
{
    class abmproceso
    {
        public static void refresh(ref DataGridView dgv, string consulta)
        {
            if (consulta == string.Empty)
                consulta = "Select * " +
                           "from Caja " +
                           "order by nrocaja desc ";

            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }
        ///<summary>
        ///Carga los datos de los productos segun el rubro
        ///</summary>
        public static void refreshrubro(ref DataGridView dgv, ref ComboBox cmbcrubro)
        {
            string consulta = string.Empty;
            if (cmbcrubro.Text == string.Empty)
                consulta = "Select detalle, stact, pventa, pventa1, pventa2, cprod, crubro " +
                            "from productos " +
                            "order by crubro, detalle  ";
            else
                consulta = "Select detalle, stact, pventa, pventa1, pventa2, cprod, crubro " +
                           "from productos " +
                           "where crubro='" + cmbcrubro.Text + "' " +
                           "order by crubro, detalle  ";
            bdcomun.dgv(dgv, consulta, "");

            libreria.alternacolorfila(ref dgv);
            string[] campos = { "cprod", "crubro" };
            configuracion.dgvocultacolumna(ref dgv, campos);
            string[] campos2 = { "detalle", "stact", "pventa", "pventa1", "pventa2" };
            string[] nombres = { "Producto", "Stock", "$ Mostrador", "$ Minorista", "$ Mayorista" };
            configuracion.dgvocultacolumna(ref dgv, campos2, nombres);

//            dgv.CurrentCell = dgv.CurrentRow.Cells[1];
        }
        ///<summary>
        ///Carga los datos de la comanda segun puesto de venta
        ///</summary>
        public static void refrescomanda(ref DataGridView dgv, ref ComboBox cmbcpventa, ref TextBox txtcCliente)
        {
            string consulta = string.Empty;
            consulta = "Select B.detalle, A.pventa, A.cantidad, A.subtotal, A.cprod, "+
                       "A.cliente,A.Lp, A.xdto " +
                       "from auxmovimiento3 as A " +
                       "inner join productos as B on (B.cprod=A.cprod) " +
                       "where A.cpventa='" + cmbcpventa.Text + "' and A.cliente='" +txtcCliente.Text+"'"+
                       "order by A.cpventa desc ";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            string[] campos = { "cprod", "cliente" };
            configuracion.dgvocultacolumna(ref dgv, campos);
            configuracion.dgvocultacolumna(ref dgv, campos);
            string[] campos2 = { "detalle", "pventa", "cantidad", "subtotal","xdto" };
            string[] nombres = { "Producto", "Precio", "Cantidad", "Total;Parcial","% dto" };
            configuracion.dgvocultacolumna(ref dgv, campos2, nombres);
        }
        ///<summary>
        ///Inicializa los datos para el formulario proceso
        ///</summary>
        public static void activa(ref ComboBox cmbpventa, ref ComboBox cmbcpventa,
                                  ref ComboBox cmbfpago1, ref ComboBox cmbcfpago1,
                                  ref ComboBox cmbfpago2, ref ComboBox cmbcfpago2,
                                  ref DataGridView dgvcomanda,
                                  ref TextBox txtccliente, 
                                  ref TextBox txtsubtotal, ref TextBox txtdto, ref TextBox txttotal,
                                  ref ComboBox cmbtkt, ref ComboBox cmbctkt, ref Button btnitka, ref Button btnitkc, 
                                  ref Label lblrsocial, ref Label lbliva, ref TextBox txtXiva, ref TextBox txtIva)
        {
            string fechini = bdcomun.contenidocampo("select * from caja order by nrocaja desc limit 1", "fechini");
            string fechcie = bdcomun.contenidocampo("select * from caja order by nrocaja desc limit 1", "fechcie");
            if (fechini != string.Empty && fechcie == string.Empty)
            {
                libreriabase.cargabox2(ref cmbpventa, "detalle", ref cmbcpventa, "cpventa", "ptoventa", false,"cpventa");
                libreriabase.cargabox2(ref cmbfpago1, "detalle", ref cmbcfpago1, "cfpago", "formadepago", false,"cfpago");
                //libreriabase.cargabox2(ref cmbfpago2, "detalle", ref cmbcfpago2, "cfpago", "formadepago", false,"");
                cmbfpago2.SelectedIndex = 0;
                cmbcfpago2.SelectedIndex = 0;
                cmbfpago1.SelectedIndex = 0;
                cmbfpago2.SelectedIndex = 0;
                txtccliente.Text = libreria.rellena("0", 4);
                abmproceso.datoscliente(ref cmbtkt, ref cmbctkt, ref txtccliente, ref btnitka, ref btnitkc, ref cmbcpventa, ref lblrsocial, ref lbliva, false);
                abmproceso.refrescomanda(ref dgvcomanda, ref cmbcpventa, ref txtccliente);
                abmproceso.totalcomanda(ref cmbcpventa, ref txtsubtotal, ref txtdto, ref txtdto, ref txttotal,ref txtccliente,ref txtXiva, ref txtIva);
                //abmproceso.refrescomanda(ref dgvcomanda, ref cmbcpventa);
            }
        }
        ///<summary>
        ///Halla el total de la comanda teniendo en cuenta si un rubro tiene descuento
        ///</summary>
        public static void totalcomanda(ref ComboBox cmbcpventa, ref TextBox txtsubtotal, ref TextBox txtxdto, ref TextBox txtdto, 
                                        ref TextBox txttotal, ref TextBox txtcCliente, ref TextBox txtXiva, ref TextBox txtIva)
        {
            MySqlConnection conectar = bdcomun.Conexion();
            string consulta = "SELECT SUM(auxmovimiento3.Cantidad * auxmovimiento3.Pventa) as subtotal, " +
                              "(SUM(auxmovimiento3.Cantidad * auxmovimiento3.Pventa) * rubros.Xdescuento / 100) as dto, " +
                              "SUM(auxmovimiento3.Cantidad * auxmovimiento3.Pventa) - " +
                              "(SUM(auxmovimiento3.Cantidad * auxmovimiento3.Pventa) * rubros.Xdescuento / 100) as total " +
                              "FROM auxmovimiento3 " +
                              "LEFT JOIN rubros on(rubros.Crubro = auxmovimiento3.Crubro) " +
                              "where cpventa='" + cmbcpventa.Text + "' and cliente='"+txtcCliente.Text+"'";
            MySqlDataReader reg = bdcomun.leereg(consulta, conectar);
            if (reg.HasRows)
            {
                reg.Read();

                txtsubtotal.Text = libreria.stringdecimalastring2dec(reg["subtotal"].ToString());
                //txtdto.Text = libreria.stringdecimalastring2dec(reg["dto"].ToString());
                //txttotal.Text = libreria.stringdecimalastring2dec(reg["total"].ToString());
            }
            reg.Close();
           
            conectar.Close();

            int pos = txtxdto.Text.IndexOf('.');
            if (pos != -1)
                txtxdto.Text = txtxdto.Text.Substring(0, pos);

            decimal xdto = Convert.ToDecimal(txtxdto.Text);
            txtdto.Text = libreria.porcentaje(txtsubtotal.Text, xdto);
            txttotal.Text = libreria.incrementaporc(txtsubtotal.Text, xdto, "-");

            decimal xiva = Convert.ToDecimal(txtXiva.Text);
            txtIva.Text = libreria.porcentaje(txttotal.Text, xiva);
            txttotal.Text = libreria.incrementaporc(txttotal.Text, xiva, "+");


        }
        ///<summary>
        ///Muestra el dinero que falta para cubrir el total
        ///</summary>
        public static void restocomanda(ref TextBox txttotal, ref TextBox txtpago, ref TextBox txtpago1, ref TextBox txtresto, ref TextBox txtsaldocliente)
        {
            decimal var = libreria.stringadecimalconpunto(txttotal.Text) -
                          libreria.stringadecimalconpunto(txtpago.Text) -
                          libreria.stringadecimalconpunto(txtpago1.Text)-
                          libreria.stringadecimalconpunto(txtsaldocliente.Text);
            txtresto.Text = libreria.decimalastringconpunto(var);
        }
        ///<summary>
        ///Obtiene el cliente, iva y listado de precio y actualiza comanda
        ///</summary>
        public static void datoscliente(ref ComboBox cmbtkt, ref ComboBox cmbctkt, ref TextBox txtccliente, ref Button btnitka,
                                        ref Button btnitkc, ref ComboBox cmbcpventa, ref Label lblrsocial, 
                                        ref Label lbliva, bool actualizacomanda)
        {
            MySqlConnection conectar = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg("select * from cliente where codigo='" + txtccliente.Text + "'", conectar);
            if (reg.HasRows)
            {
                reg.Read();
                string iva = reg["iva"].ToString();
                switch (iva)
                {
                    case "F":
                        cmbctkt.SelectedIndex = 0;  //c b
                        btnitka.Tag = 0;
                        btnitkc.Tag = 1;
                        break;
                    case "I":
                        cmbctkt.SelectedIndex = 1;  //a
                        btnitka.Tag = 1;
                        btnitkc.Tag = 0;
                        break;
                    case "J":
                        cmbctkt.SelectedIndex = 2;  //r
                        btnitka.Tag = 0;
                        btnitkc.Tag = 1;
                        break;
                }
                if (txtccliente.Text=="0000")
                    lblrsocial.Text = reg["ndni"].ToString();
                else
                    lblrsocial.Text = reg["rsocial"].ToString();
                lbliva.Text = reg["iva"].ToString();
                //reg["lp"].ToString(); //listado precio
                //verificar si la mesa ya tiene datos y poner tipo de facturacion segun corresponda
                if (actualizacomanda)
                {
                    bdcomun.ejecuta("update auxmovimiento3 set cform='" + cmbctkt.Text + "', cliente='" + txtccliente.Text +
                                    "' where cpventa='" + cmbcpventa.Text + "'");
                    libreria.MessageBoxTemporal.Show("Cliente actualizado", configuracion.titulomensaje(), 1, false);
                }
            }
            else
            {
                libreria.MessageBoxTemporal.Show("No existe el Cliente", configuracion.titulomensaje(), 1, false);
            }
            reg.Close();
           
            conectar.Close();
        }
        ///<summary>
        ///Analiza el codigo de producto para poner la cantidad y el precio de venta
        ///</summary>
        public static void cprodexit(ref TextBox txtcprod, ref TextBox txtpventa, ref TextBox txtcantidad, ref Label lblproductodet)
        {
            string qpv = "0";
            string auxcprod = string.Empty, entero = string.Empty, deci = string.Empty, aux = string.Empty;
            decimal precio = 0, cantidad = 0, stockactual = 0;
            if (txtcprod.Text != string.Empty)
            {
                #region
                auxcprod = txtcprod.Text;
                if (abmproceso.qprecioventa(qpv, ref txtcprod, ref txtpventa, ref txtcantidad, ref lblproductodet) == false)
                {
                    txtcprod.Text = auxcprod;
                    qpv = txtcprod.Text.Substring(2, 1);
                    if (qpv != "0")
                        txtcprod.Text = txtcprod.Text.Substring(0, 2) + "0" + txtcprod.Text.Substring(3, 3);
                    else
                        txtcprod.Text = txtcprod.Text.Substring(0, 6);
                    if (abmproceso.qprecioventa(qpv, ref txtcprod, ref txtpventa, ref txtcantidad, ref lblproductodet) == false)
                    {
                        txtcprod.Text = string.Empty;
                        txtcantidad.Text = "0";
                        txtpventa.Text = "0";
                        libreria.MessageBoxTemporal.Show("El producto no existe cprodexitfalse", configuracion.titulomensaje(), 1, true);
                    }
                    else
                    {
                        aux = libreria.Right(txtcprod.Text, 7);
                        entero = libreria.Left(aux, 4);
                        deci = libreria.Right(aux, 3);
                        precio = libreria.stringadecimalconpunto(entero + "." + libreria.Left(deci, 2));
                        cantidad = precio / libreria.stringadecimalconpunto(txtpventa.Text);
                        txtcantidad.Text = libreria.decimalastringconpunto(cantidad);
                        txtcprod.BackColor = Color.LightGreen;
                    }
                }
                else
                {
                    stockactual = libreria.stringadecimalconpunto(bdcomun.contenidocampo("Select * from productos where cprod='" + txtcprod.Text + "'", "stact"));
                    if (stockactual <= 0)
                    {
                        txtcprod.Text = string.Empty;
                        libreria.MessageBoxTemporal.Show("El producto no tiene stock", configuracion.titulomensaje(), 2, true);
                    }
                }
                #endregion


            }
        }
        ///<summary>
        ///Obtiene el precio de venta del producto normal, oferta, merma segun qpv
        ///</summary>
        public static bool qprecioventa(string qpv, ref TextBox txtcprod, ref TextBox txtpventa, ref TextBox txtcantidad, ref Label lblproductodet)
        {
            bool resultado = false;
            txtcprod.Text = libreria.rellena(txtcprod.Text, 20);
            MySqlConnection conectar = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg("select * from productos where cprod='" + txtcprod.Text + "'", conectar);
            if (reg.HasRows)
            {
                reg.Read();
                lblproductodet.Text = reg["detalle"].ToString();
                switch (qpv)
                {
                    case "0": //normal
                        txtpventa.Text = reg["pventa"].ToString();
                        txtpventa.BackColor = Color.WhiteSmoke;
                        break;
                    case "9": //oferta
                        txtpventa.Text = reg["pventa1"].ToString();
                        txtpventa.BackColor = Color.Green;
                        break;
                    case "8":
                        txtpventa.Text = reg["pventa2"].ToString();
                        txtpventa.BackColor = Color.Gray;
                        break;
                    case "3":
                        break;
                }
                if (txtcantidad.Text == "0")
                    txtcantidad.Text = "1";
                reg.Close();
                resultado = true;
            }
            else
            {
                lblproductodet.Text = string.Empty;
                txtcprod.Focus();
            }
         
            conectar.Close();
            return resultado;
        }

        /// <summary>
        /// chequea los puestos de trabajo que tiene items cargados
        /// </summary>
        /// <param name="cmbcpventa"></param>
        /// <param name="chk"></param>
        public static void checpuestos(ComboBox cmbcpventa, CheckedListBox chk)
        {
            for (int i = 0; i < cmbcpventa.Items.Count; i++)
            {
                if (bdcomun.ejecuta("select * from auxmovimiento3 where cpventa='" + cmbcpventa.Items[i].ToString() + "'", "cform") == string.Empty)
                    chk.SetItemChecked(i, false);
                else
                    chk.SetItemChecked(i, true);
            }
        }

        /// <summary>
        /// borra un item de la comanda
        /// </summary>
        /// <param name="dato"></param>
        /// <param name="dgv"></param>
        public static void borraitem(string dato, ref DataGridView dgv, ComboBox cmbcpventa, ref TextBox txtccliente)
        {
            if (MessageBox.Show("Desea Borrar el Item?", configuracion.titulomensaje(), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bdcomun.ejecuta("delete from auxmovimiento3 where cprod='" + dato + "' and cpventa='" + cmbcpventa.Text +
                                "' and cliente='"+txtccliente.Text+"'");
                configuracion.mensaje("Item borrado");
                abmproceso.refrescomanda(ref dgv, ref cmbcpventa, ref txtccliente);
            }
            else
                configuracion.mensaje("Proceso cancelado");
        }
        public static void buscarcliente(ref DataGridView dgv)
        {
            string dato = InputDialog.mostrar("Ingrese Razón Social");
            string consulta = "select * from cliente where rsocial like '%" + dato + "%'";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }

        public static void buscarproducto(ref DataGridView dgv)
        {
            string dato = InputDialog.mostrar("Ingrese Producto");
            string consulta = "select * from productos where detalle like '%" + dato + "%'";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }
    }
}
