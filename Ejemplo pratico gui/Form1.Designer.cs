namespace Ejemplo_pratico_gui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblbigbox = new System.Windows.Forms.Label();
            this.lblbox = new System.Windows.Forms.Label();
            this.btnsesion = new System.Windows.Forms.Button();
            this.picpizza = new System.Windows.Forms.PictureBox();
            this.picsombrero = new System.Windows.Forms.PictureBox();
            this.lblcrispy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lbloferta = new System.Windows.Forms.Label();
            this.lbllinea = new System.Windows.Forms.Label();
            this.txtnume = new System.Windows.Forms.TextBox();
            this.lblejemplo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.picpizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picsombrero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbigbox
            // 
            this.lblbigbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblbigbox.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblbigbox.Location = new System.Drawing.Point(2, 442);
            this.lblbigbox.Name = "lblbigbox";
            this.lblbigbox.Size = new System.Drawing.Size(277, 44);
            this.lblbigbox.TabIndex = 0;
            this.lblbigbox.Text = "BIG PARTY ";
            this.lblbigbox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblbox
            // 
            this.lblbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblbox.Font = new System.Drawing.Font("Arial", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblbox.Location = new System.Drawing.Point(2, 476);
            this.lblbox.Name = "lblbox";
            this.lblbox.Size = new System.Drawing.Size(289, 160);
            this.lblbox.TabIndex = 1;
            this.lblbox.Text = "BOX";
            this.lblbox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnsesion
            // 
            this.btnsesion.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnsesion.Location = new System.Drawing.Point(32, 12);
            this.btnsesion.Name = "btnsesion";
            this.btnsesion.Size = new System.Drawing.Size(155, 58);
            this.btnsesion.TabIndex = 2;
            this.btnsesion.Text = "Iniciar  Sesion\r\n";
            this.btnsesion.UseVisualStyleBackColor = true;
            this.btnsesion.Click += new System.EventHandler(this.btnsesion_Click);
            // 
            // picpizza
            // 
            this.picpizza.Image = ((System.Drawing.Image) (resources.GetObject("picpizza.Image")));
            this.picpizza.Location = new System.Drawing.Point(321, 521);
            this.picpizza.Name = "picpizza";
            this.picpizza.Size = new System.Drawing.Size(84, 99);
            this.picpizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picpizza.TabIndex = 3;
            this.picpizza.TabStop = false;
            // 
            // picsombrero
            // 
            this.picsombrero.Image = ((System.Drawing.Image) (resources.GetObject("picsombrero.Image")));
            this.picsombrero.Location = new System.Drawing.Point(46, 369);
            this.picsombrero.Name = "picsombrero";
            this.picsombrero.Size = new System.Drawing.Size(158, 60);
            this.picsombrero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picsombrero.TabIndex = 4;
            this.picsombrero.TabStop = false;
            // 
            // lblcrispy
            // 
            this.lblcrispy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblcrispy.BackColor = System.Drawing.Color.Red;
            this.lblcrispy.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblcrispy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcrispy.Location = new System.Drawing.Point(12, 574);
            this.lblcrispy.Name = "lblcrispy";
            this.lblcrispy.Size = new System.Drawing.Size(289, 46);
            this.lblcrispy.TabIndex = 5;
            this.lblcrispy.Text = "EXTRA CRISPY";
            this.lblcrispy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(637, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblprecio
            // 
            this.lblprecio.BackColor = System.Drawing.Color.White;
            this.lblprecio.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblprecio.Location = new System.Drawing.Point(416, 9);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(329, 70);
            this.lblprecio.TabIndex = 7;
            this.lblprecio.Text = "RED DAYS";
            this.lblprecio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbloferta
            // 
            this.lbloferta.BackColor = System.Drawing.Color.White;
            this.lbloferta.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbloferta.Location = new System.Drawing.Point(404, 39);
            this.lbloferta.Name = "lbloferta";
            this.lbloferta.Size = new System.Drawing.Size(329, 70);
            this.lbloferta.TabIndex = 8;
            this.lbloferta.Text = "$14.99";
            this.lbloferta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbllinea
            // 
            this.lbllinea.BackColor = System.Drawing.Color.Firebrick;
            this.lbllinea.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbllinea.ForeColor = System.Drawing.Color.White;
            this.lbllinea.Location = new System.Drawing.Point(321, 79);
            this.lbllinea.Name = "lbllinea";
            this.lbllinea.Size = new System.Drawing.Size(377, 44);
            this.lbllinea.TabIndex = 9;
            this.lbllinea.Text = "SOLO VALIDO EN LINEA";
            this.lbllinea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnume
            // 
            this.txtnume.Location = new System.Drawing.Point(321, 425);
            this.txtnume.Multiline = true;
            this.txtnume.Name = "txtnume";
            this.txtnume.Size = new System.Drawing.Size(292, 71);
            this.txtnume.TabIndex = 10;
            // 
            // lblejemplo
            // 
            this.lblejemplo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblejemplo.Location = new System.Drawing.Point(356, 373);
            this.lblejemplo.Name = "lblejemplo";
            this.lblejemplo.Size = new System.Drawing.Size(201, 41);
            this.lblejemplo.TabIndex = 11;
            this.lblejemplo.Text = "Ingrese su numero de telefono";
            this.lblejemplo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.lblejemplo);
            this.Controls.Add(this.txtnume);
            this.Controls.Add(this.lbllinea);
            this.Controls.Add(this.lbloferta);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblcrispy);
            this.Controls.Add(this.picsombrero);
            this.Controls.Add(this.picpizza);
            this.Controls.Add(this.btnsesion);
            this.Controls.Add(this.lblbox);
            this.Controls.Add(this.lblbigbox);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.Text = "Pizza Hut";
            ((System.ComponentModel.ISupportInitialize) (this.picpizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picsombrero)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblejemplo;

        private System.Windows.Forms.TextBox txtnume;

        private System.Windows.Forms.Label lbllinea;

        private System.Windows.Forms.Label lbloferta;

        private System.Windows.Forms.Label lblprecio;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Label lblcrispy;

        private System.Windows.Forms.PictureBox picsombrero;

        private System.Windows.Forms.PictureBox picpizza;

        private System.Windows.Forms.Button btnsesion;

        private System.Windows.Forms.Label lblbox;

        private System.Windows.Forms.Label lblbigbox;

        #endregion
    }
}