using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Monstruletul_mancacios
{
    public partial class Form1 : Form
    {
        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(Control c)
        {
            if (SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #endregion

        #region .. code for Flickering ..

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion
        SoundPlayer sunet = new SoundPlayer(Properties.Resources.ra);

        public Form1()
        {
            InitializeComponent();
            background.Controls.Add(player);
            player.BackColor = Color.Transparent;
            background.Controls.Add(candy);
            background.Controls.Add(label3);
            background.Controls.Add(label1);
            background.Controls.Add(lbl_vieti);
            background.Controls.Add(lbl_puncte);
            candy.BackColor = Color.Transparent;
            background.Controls.Add(candy1);
            candy1.BackColor = Color.Transparent;
            background.Controls.Add(star);
            star.BackColor = Color.Transparent;
            star.Top = -3500;
            label1.BackColor = Color.Transparent;
            lbl_puncte.BackColor = Color.Transparent;
            lbl_vieti.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }
        int puncte = 0, vieti = 3,viteza=8,viteza1=10,viteza_star=4;
        bool stop = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //miscare bomboana
            foreach (Control x in background.Controls)
            {
                if ((string)x.Tag == "candy")
                {
                    if (x.Top <= background.Height)
                    {
                        x.Top = x.Top + viteza;
                    }
                    else
                    {
                        Random nr = new Random();
                        int ya = nr.Next(80, 120);//coordonata pe verticala
                        int xa = nr.Next(425);//coordonata pe orizontala a bomboanei
                        x.Top = -ya;
                        x.Left = xa;
                    }
                }
                if ((string)x.Tag == "candy1")
                {
                    if (x.Top <= background.Height)
                    {
                        x.Top = x.Top + viteza1;
                    }
                    else
                    {
                        Random nr = new Random();
                        int ya = nr.Next(100, 300);//coordonata pe verticala
                        int xa = nr.Next(425);//coordonata pe orizontala a bomboanei
                        x.Top = -ya;
                        x.Left = xa;
                    }
                }
                //miscare stea
                if ((string)x.Tag == "star" && puncte!=0 )
                {
                    if (x.Top <= background.Height ) 
                    {
                        x.Top = x.Top + viteza_star;
                    }
                    else
                    {
                        Random nr = new Random();
                        int ya = nr.Next(3000);//coordonata pe verticala
                        int xa = nr.Next(425);//coordonata pe orizontala a stelei
                        x.Top = -ya;
                        x.Left = xa;
                    }
                }

            }
            lbl_vieti.Text = Convert.ToString(vieti);
            foreach (Control x in background.Controls)
            {

                if ((string)x.Tag == "candy" || (string)x.Tag=="candy1")
                {
                    if (wood.Bounds.IntersectsWith(x.Bounds))
                    {
                        lbl_vieti.Text = Convert.ToString(vieti);
                        vieti--;
                        Random nr = new Random();
                        int ya = nr.Next(100, 300);//coordonata pe verticala
                        int xa = nr.Next(425);//coordonata pe orizontala a bomboanei
                        x.Top = -ya;
                        x.Left = xa;
                    }
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        puncte++;
                        lbl_puncte.Text = Convert.ToString(puncte);
                        if (puncte % 20 == 0)
                            viteza += 2;
                        if (puncte % 7 == 0)
                            viteza1 += 1;
                        sunet.Play();

                        Random nr = new Random();
                        int ya = nr.Next(80, 120);//coordonata pe verticala
                        int xa = nr.Next(425);//coordonata pe orizontala a bomboanei
                        x.Top = -ya;
                        x.Left = xa;
                    }
                }
                if ((string)x.Tag == "star")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        vieti+=1;
                        puncte = puncte + 10;
                        lbl_puncte.Text = Convert.ToString(puncte);
                        Random nr = new Random();
                        int ya = nr.Next(3500);//coordonata pe verticala
                        int xa = nr.Next(425);//coordonata pe orizontala a bomboanei
                        x.Top = -ya;
                        x.Left = xa;
                    }
                }
                if (vieti == 0)
                {

                    stop = false;
                    timer1.Enabled = false;
                    this.Hide();
                    if (puncte < 250)
                    {
                        Final f = new Final();
                        Program.scor = puncte;
                        if (Program.scor > Program.max_scor)
                            Program.max_scor = Program.scor;
                        f.scor = Program.scor;
                        f.label1.Text = Convert.ToString(f.scor);
                        f.record.Text = Convert.ToString(Program.max_scor);
                        f.ShowDialog();
                    }
                    else
                    {
                        Final2 g = new Final2();
                        Program.scor = puncte;
                        if (Program.scor > Program.max_scor)
                            Program.max_scor = Program.scor;
                        g.label1.Text = Convert.ToString(puncte);
                        g.record.Text = Convert.ToString(Program.max_scor);
                        g.ShowDialog();
                    }
                }
            }


        }

        private void background_MouseMove(object sender, MouseEventArgs e)
        {
            if (stop == true)
            {
                Point position = e.Location;
                double pX = position.X;
                player.Left = (int)pX - (player.Width / 2);
            }
        }
    }
}
