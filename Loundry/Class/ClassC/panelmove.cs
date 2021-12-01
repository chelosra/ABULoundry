using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Threading;


namespace Loundry
{
    class panelmove
    {
        public static string desliza(Panel panel, int x, int y, int incr)
        {
            panel.Tag = 1;
            if (panel.Tag.Equals(1))
            {
                //trae
                panel.Location = new Point(panel.Location.X, panel.Location.Y);

                for (int i = y; i >= x; i = i - incr)
                {
                    panel.Location = new Point(i, panel.Location.Y);
                    Thread.Sleep(8);
                }
                panel.Tag = 0;
            }
            else
            {
                //lleva
                panel.Location = new Point(panel.Location.X, panel.Location.Y);
                for (int i = x; i < y; i = i + incr)
                {
                    panel.Location = new Point(i, panel.Location.Y);
                }
                panel.Visible = false;
            }
            return "";
        }
    }
}
