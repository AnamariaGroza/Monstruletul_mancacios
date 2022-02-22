namespace Monstruletul_mancacios
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_vieti = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_puncte = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.star = new System.Windows.Forms.PictureBox();
            this.candy1 = new System.Windows.Forms.PictureBox();
            this.candy = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.wood = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.star)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_vieti
            // 
            this.lbl_vieti.AutoSize = true;
            this.lbl_vieti.BackColor = System.Drawing.Color.Black;
            this.lbl_vieti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vieti.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_vieti.Location = new System.Drawing.Point(646, 9);
            this.lbl_vieti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vieti.Name = "lbl_vieti";
            this.lbl_vieti.Size = new System.Drawing.Size(23, 25);
            this.lbl_vieti.TabIndex = 7;
            this.lbl_vieti.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(591, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vieti:";
            // 
            // lbl_puncte
            // 
            this.lbl_puncte.AutoSize = true;
            this.lbl_puncte.BackColor = System.Drawing.Color.Black;
            this.lbl_puncte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_puncte.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_puncte.Location = new System.Drawing.Point(91, 9);
            this.lbl_puncte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_puncte.Name = "lbl_puncte";
            this.lbl_puncte.Size = new System.Drawing.Size(23, 25);
            this.lbl_puncte.TabIndex = 9;
            this.lbl_puncte.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Puncte:";
            // 
            // star
            // 
            this.star.Image = global::Monstruletul_mancacios.Properties.Resources.star;
            this.star.Location = new System.Drawing.Point(255, 12);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(64, 57);
            this.star.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star.TabIndex = 11;
            this.star.TabStop = false;
            this.star.Tag = "star";
            // 
            // candy1
            // 
            this.candy1.Image = global::Monstruletul_mancacios.Properties.Resources.candy;
            this.candy1.Location = new System.Drawing.Point(360, 89);
            this.candy1.Name = "candy1";
            this.candy1.Size = new System.Drawing.Size(53, 52);
            this.candy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.candy1.TabIndex = 10;
            this.candy1.TabStop = false;
            this.candy1.Tag = "candy1";
            // 
            // candy
            // 
            this.candy.Image = global::Monstruletul_mancacios.Properties.Resources.candy;
            this.candy.Location = new System.Drawing.Point(124, 89);
            this.candy.Name = "candy";
            this.candy.Size = new System.Drawing.Size(53, 52);
            this.candy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.candy.TabIndex = 3;
            this.candy.TabStop = false;
            this.candy.Tag = "candy";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Monstruletul_mancacios.Properties.Resources.character;
            this.player.Location = new System.Drawing.Point(265, 517);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(138, 122);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // wood
            // 
            this.wood.Image = global::Monstruletul_mancacios.Properties.Resources.wood;
            this.wood.Location = new System.Drawing.Point(-8, 628);
            this.wood.Name = "wood";
            this.wood.Size = new System.Drawing.Size(700, 50);
            this.wood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wood.TabIndex = 1;
            this.wood.TabStop = false;
            // 
            // background
            // 
            this.background.Image = global::Monstruletul_mancacios.Properties.Resources.background;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(700, 700);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 2;
            this.background.TabStop = false;
            this.background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.background_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.star);
            this.Controls.Add(this.candy1);
            this.Controls.Add(this.lbl_puncte);
            this.Controls.Add(this.lbl_vieti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.candy);
            this.Controls.Add(this.player);
            this.Controls.Add(this.wood);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monstrulețul mâncăcios";
            ((System.ComponentModel.ISupportInitialize)(this.star)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox wood;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox candy;
        private System.Windows.Forms.Label lbl_vieti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_puncte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox candy1;
        private System.Windows.Forms.PictureBox star;
    }
}

