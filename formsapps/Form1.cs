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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stalin_Click(object sender, EventArgs e)
        {
            StalinWay S = new StalinWay();
            S.Show();
            Hide();
        }

        private void hitler_Click(object sender, EventArgs e)
        {
            HitlerWay H = new HitlerWay();
            H.Show();
            Hide();
        }
    }
}
