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
    public partial class StalinWay : Form
    {
        public StalinWay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stalinarsenal Stalin = new Stalinarsenal();
            Stalin.Show();
            Hide();
        }
    }
}
