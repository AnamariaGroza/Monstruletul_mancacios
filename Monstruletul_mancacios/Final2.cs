using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monstruletul_mancacios
{
    public partial class Final2 : Form
    {
        public Final2()
        {
            InitializeComponent();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.ShowDialog();
            this.Close();
        }

        private void iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
