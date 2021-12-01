using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loundry
{
    public partial class frmQR : Form
    {
        public frmQR()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            QrEncoder qr = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrc = new QrCode();
            qr.TryEncode(txtValor.Text, out qrc);
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400,QuietZoneModules.Zero),Brushes.Black,Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrc.Matrix, ImageFormat.Png, ms);
            var imagetemporal = new Bitmap(ms);
            var imagen = new Bitmap(imagetemporal, new Size(new Point(200, 200)));
            pictureBox1.BackgroundImage = imagen;
            
            //guardo imagen en disco
            imagen.Save("imagen.png", ImageFormat.Png);
            btnGuardar.Enabled = true;
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Image clone=(Image)pictureBox1.BackgroundImage.Clone();
            string archurl = @"c:\sracsharp\Loundry\Tmp\qr.png";
            clone.Save(archurl, ImageFormat.Png);
            /*
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.Filter = "Image PNG (*.png)|*.png";
            sfd.ShowDialog();
            if (!string.IsNullOrEmpty(sfd.FileName)) {
                clone.Save(sfd.FileName, ImageFormat.Png);
            }
            */
            clone.Dispose();
        }
    }
}
