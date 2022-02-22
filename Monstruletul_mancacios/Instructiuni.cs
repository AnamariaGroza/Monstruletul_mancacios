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
    public partial class Instructiuni : Form
    {
        public Instructiuni()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Visible = false;
            f.ShowDialog();
            this.Close();
        }
    }
}
