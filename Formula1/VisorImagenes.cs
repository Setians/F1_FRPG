using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Formula1
{
    public partial class VisorImagenes : Form
    {
        public VisorImagenes()
        {
            InitializeComponent();
        }
        int i = 3;
        private void VisorImagenes_Load(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
            timer1.Start();
            string imagepath = Path.Combine(Application.StartupPath, @"..\..\..\" + "imagenes\\image (2).jpg");
            pictureBox1.Image = Image.FromFile(imagepath);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 1)
            {
                string imagepath = Path.Combine(Application.StartupPath, @"..\..\..\" + "imagenes\\image (1).jpg");
                pictureBox1.Image = Image.FromFile(imagepath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                i++;
            }
            else if (i == 2)
            {
                string imagepath = Path.Combine(Application.StartupPath, @"..\..\..\" + "imagenes\\image (2).jpg");
                pictureBox1.Image = Image.FromFile(imagepath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                i++;
            }
            else if (i == 3)
            {
                string imagepath = Path.Combine(Application.StartupPath, @"..\..\..\" + "imagenes\\image.jpg");
                pictureBox1.Image = Image.FromFile(imagepath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                i = 1;
            }
        }
    }
}
