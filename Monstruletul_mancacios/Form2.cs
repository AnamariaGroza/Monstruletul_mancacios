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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.ShowDialog();
        }

        private void iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void instructiuni_Click(object sender, EventArgs e)
        {
            Instructiuni f = new Instructiuni();
            this.Visible = false;
            f.ShowDialog();
            this.Close();
        }
    }
}
