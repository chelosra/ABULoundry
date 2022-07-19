using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loundry
{
    class abmmovimientos
    {
        public static void refresh(ref DataGridView dgv, DateTimePicker fechadesde, DateTimePicker fechahasta)
        {
            string fdesde = libreria.fechaamysql(fechadesde.Value.ToString());
            string fhasta = libreria.fechaamysql(fechahasta.Value.ToString());

            string consulta = "select date_format(fechform, '%Y-%m-%d')fechform, nrocaja, formularios.detalle as form, nroform, Productos.detalle as prod, movimiento.pventa," +
                "cantidad, stock, movimiento.crubro, Cliente.Rsocial as Cliente, proveedores.rsocial " +
                "from movimiento " +
                "inner join formularios on (formularios.cform = movimiento.cform) " +
                "left join productos on (productos.cprod = movimiento.cprod) " +
                "left join proveedores on (proveedores.cprov = movimiento.cprov) " +
                "left join cliente on (cliente.codigo = movimiento.cliente) " +
                "where fechform between '" + fdesde + "' and '" + fhasta + "' "+
                "order by pk";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            /*
            string[] campos2 = { "crubro", "detalle", "xmostrador", "xminorista", "xmayorista" };
            string[] nombres = { "Código Rubro", "Rubro", "% Venta Mostrador", "% Venta Minorista", "% Venta Mayorista" };
            configuracion.dgvocultacolumna(ref dgv, campos2, nombres);
            string[] campos = { "xmostrador", "xminorista", "xmayorista", "xdescuento" };
            configuracion.dgvocultacolumna(ref dgv, campos);
            */
        }

        public static void refreshopciones(ref DataGridView dgv,string consulta)
        {
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            /*
            string[] campos2 = { "crubro", "detalle", "xmostrador", "xminorista", "xmayorista" };
            string[] nombres = { "Código Rubro", "Rubro", "% Venta Mostrador", "% Venta Minorista", "% Venta Mayorista" };
            configuracion.dgvocultacolumna(ref dgv, campos2, nombres);
            string[] campos = { "xmostrador", "xminorista", "xmayorista", "xdescuento" };
            configuracion.dgvocultacolumna(ref dgv, campos);
            */
        }

    }
}
