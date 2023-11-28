using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsapps
{
    public partial class Stalinarsenal : Form
    {
        public Stalinarsenal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rows = 3;
            int cols = 3;
            int spacing = 10;
            int imageWidth = 200;
            int imageHeight = 200;

            for (int i = 0; i < imageList2.Images.Count; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = imageList2.Images[i];
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Size = new Size(imageWidth, imageHeight);

                int row = i / cols;
                int col = i % cols;

                int x = col * (imageWidth + spacing);
                int y = row * (imageHeight + spacing);

                pictureBox.Location = new Point(x, y);
                this.Controls.Add(pictureBox);
            }
        }
    }
}
