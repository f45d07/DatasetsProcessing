using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace DatasetsProcessing
{
    public partial class OverlayWindow : Form
    {
        Bitmap mask;

        public OverlayWindow(string ImgPath, string MaskPath)
        {
            InitializeComponent();
            mask = null;
            //BoxImg.Controls.Add(BoxMask);
            BoxMask.Parent = BoxImg;
            BoxMask.Location = Point.Empty;
            BoxImg.Load(ImgPath);
            BoxMask.Load(MaskPath);
        }

        public void Update(string ImgPath, string MaskPath)
        {
            mask = null;
            BoxImg.Load(ImgPath);
            BoxMask.Load(MaskPath);
            this.trackBar_Scroll(null, null);
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            if (mask == null) mask = (Bitmap)BoxMask.Image.Clone();
            BoxMask.BackColor = Color.Transparent;
            BoxMask.Image = SetAlpha((Bitmap)mask, trackBar.Value);
        }

        static Bitmap SetAlpha(Bitmap bmpIn, int alpha)
        {
            Bitmap bmpOut = new Bitmap(bmpIn.Width, bmpIn.Height);
            float a = alpha / 255f;
            Rectangle r = new Rectangle(0, 0, bmpIn.Width, bmpIn.Height);

            float[][] matrixItems = {
        new float[] {1, 0, 0, 0, 0},
        new float[] {0, 1, 0, 0, 0},
        new float[] {0, 0, 1, 0, 0},
        new float[] {0, 0, 0, a, 0},
        new float[] {0, 0, 0, 0, 1}};

            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);

            ImageAttributes imageAtt = new ImageAttributes();
            imageAtt.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            using (Graphics g = Graphics.FromImage(bmpOut))
                g.DrawImage(bmpIn, r, r.X, r.Y, r.Width, r.Height, GraphicsUnit.Pixel, imageAtt);

            return bmpOut;
        }
    }
}
