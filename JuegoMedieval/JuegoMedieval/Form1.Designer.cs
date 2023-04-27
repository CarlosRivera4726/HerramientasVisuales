using System.Drawing;

namespace JuegoMedieval
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.jugador = new System.Windows.Forms.PictureBox();
            this.piso = new System.Windows.Forms.PictureBox();
            this.paredDerechaEscalon1 = new System.Windows.Forms.PictureBox();
            this.paredIzquierdaCompleta = new System.Windows.Forms.PictureBox();
            this.movementPlayer = new System.Windows.Forms.Timer(this.components);
            this.paredDerechaCompleta = new System.Windows.Forms.PictureBox();
            this.escalon1 = new System.Windows.Forms.PictureBox();
            this.escalon2 = new System.Windows.Forms.PictureBox();
            this.escalon3 = new System.Windows.Forms.PictureBox();
            this.escalon4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.jugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paredDerechaEscalon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paredIzquierdaCompleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paredDerechaCompleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escalon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escalon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escalon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escalon4)).BeginInit();
            this.SuspendLayout();
            // 
            // jugador
            // 
            this.jugador.BackColor = System.Drawing.Color.Transparent;
            this.jugador.Image = global::JuegoMedieval.Properties.Resources.caminando_espalda_izq;
            this.jugador.Location = new System.Drawing.Point(31, 416);
            this.jugador.Name = "jugador";
            this.jugador.Size = new System.Drawing.Size(42, 60);
            this.jugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jugador.TabIndex = 0;
            this.jugador.TabStop = false;
            // 
            // piso
            // 
            this.piso.BackColor = System.Drawing.Color.Transparent;
            this.piso.Location = new System.Drawing.Point(0, 480);
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(224, 77);
            this.piso.TabIndex = 1;
            this.piso.TabStop = false;
            // 
            // paredDerechaEscalon1
            // 
            this.paredDerechaEscalon1.BackColor = System.Drawing.Color.Transparent;
            this.paredDerechaEscalon1.Location = new System.Drawing.Point(159, 411);
            this.paredDerechaEscalon1.Name = "paredDerechaEscalon1";
            this.paredDerechaEscalon1.Size = new System.Drawing.Size(65, 69);
            this.paredDerechaEscalon1.TabIndex = 2;
            this.paredDerechaEscalon1.TabStop = false;
            // 
            // paredIzquierdaCompleta
            // 
            this.paredIzquierdaCompleta.BackColor = System.Drawing.Color.Transparent;
            this.paredIzquierdaCompleta.Location = new System.Drawing.Point(1, 1);
            this.paredIzquierdaCompleta.Name = "paredIzquierdaCompleta";
            this.paredIzquierdaCompleta.Size = new System.Drawing.Size(31, 479);
            this.paredIzquierdaCompleta.TabIndex = 3;
            this.paredIzquierdaCompleta.TabStop = false;
            // 
            // movementPlayer
            // 
            this.movementPlayer.Tick += new System.EventHandler(this.movementPlayer_Tick);
            // 
            // paredDerechaCompleta
            // 
            this.paredDerechaCompleta.BackColor = System.Drawing.Color.Transparent;
            this.paredDerechaCompleta.Location = new System.Drawing.Point(224, -9);
            this.paredDerechaCompleta.Name = "paredDerechaCompleta";
            this.paredDerechaCompleta.Size = new System.Drawing.Size(46, 565);
            this.paredDerechaCompleta.TabIndex = 4;
            this.paredDerechaCompleta.TabStop = false;
            // 
            // escalon1
            // 
            this.escalon1.BackColor = System.Drawing.Color.Transparent;
            this.escalon1.Location = new System.Drawing.Point(82, 398);
            this.escalon1.Name = "escalon1";
            this.escalon1.Size = new System.Drawing.Size(142, 13);
            this.escalon1.TabIndex = 5;
            this.escalon1.TabStop = false;
            // 
            // escalon2
            // 
            this.escalon2.BackColor = System.Drawing.Color.Transparent;
            this.escalon2.Location = new System.Drawing.Point(27, 285);
            this.escalon2.Name = "escalon2";
            this.escalon2.Size = new System.Drawing.Size(142, 13);
            this.escalon2.TabIndex = 6;
            this.escalon2.TabStop = false;
            // 
            // escalon3
            // 
            this.escalon3.BackColor = System.Drawing.Color.Transparent;
            this.escalon3.Location = new System.Drawing.Point(82, 174);
            this.escalon3.Name = "escalon3";
            this.escalon3.Size = new System.Drawing.Size(142, 13);
            this.escalon3.TabIndex = 7;
            this.escalon3.TabStop = false;
            // 
            // escalon4
            // 
            this.escalon4.BackColor = System.Drawing.Color.Transparent;
            this.escalon4.Location = new System.Drawing.Point(27, 61);
            this.escalon4.Name = "escalon4";
            this.escalon4.Size = new System.Drawing.Size(142, 13);
            this.escalon4.TabIndex = 8;
            this.escalon4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(112)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(267, 555);
            this.Controls.Add(this.escalon4);
            this.Controls.Add(this.escalon3);
            this.Controls.Add(this.escalon2);
            this.Controls.Add(this.escalon1);
            this.Controls.Add(this.paredDerechaCompleta);
            this.Controls.Add(this.paredIzquierdaCompleta);
            this.Controls.Add(this.paredDerechaEscalon1);
            this.Controls.Add(this.piso);
            this.Controls.Add(this.jugador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.jugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paredDerechaEscalon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paredIzquierdaCompleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paredDerechaCompleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escalon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escalon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escalon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escalon4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox jugador;
        private System.Windows.Forms.PictureBox piso;
        private System.Windows.Forms.PictureBox paredDerechaEscalon1;
        private System.Windows.Forms.PictureBox paredIzquierdaCompleta;
        private System.Windows.Forms.Timer movementPlayer;
        private System.Windows.Forms.PictureBox paredDerechaCompleta;
        private System.Windows.Forms.PictureBox escalon1;
        private System.Windows.Forms.PictureBox escalon2;
        private System.Windows.Forms.PictureBox escalon3;
        private System.Windows.Forms.PictureBox escalon4;
    }
}

