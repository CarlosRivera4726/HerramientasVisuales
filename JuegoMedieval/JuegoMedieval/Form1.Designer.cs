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
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.movementEnemy_left_1 = new System.Windows.Forms.Timer(this.components);
            this.movementEnemy_right_1 = new System.Windows.Forms.Timer(this.components);
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.corazon2 = new System.Windows.Forms.PictureBox();
            this.corazon1 = new System.Windows.Forms.PictureBox();
            this.corazon3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.jugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paredDerechaEscalon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paredIzquierdaCompleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paredDerechaCompleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escalon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escalon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escalon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escalon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corazon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corazon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corazon3)).BeginInit();
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
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.Image = global::JuegoMedieval.Properties.Resources.output_onlinegiftools;
            this.enemy1.Location = new System.Drawing.Point(181, 335);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(41, 61);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 9;
            this.enemy1.TabStop = false;
            // 
            // movementEnemy_left_1
            // 
            this.movementEnemy_left_1.Interval = 1000;
            this.movementEnemy_left_1.Tick += new System.EventHandler(this.movementEnemy_left_1_Tick);
            // 
            // movementEnemy_right_1
            // 
            this.movementEnemy_right_1.Interval = 1000;
            this.movementEnemy_right_1.Tick += new System.EventHandler(this.movementEnemy_right_1_Tick);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(29, 522);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(49, 13);
            this.lblPuntaje.TabIndex = 10;
            this.lblPuntaje.Text = "Puntaje: ";
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.Image = global::JuegoMedieval.Properties.Resources.output_onlinegiftools___copia;
            this.enemy2.Location = new System.Drawing.Point(32, 224);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(41, 60);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 11;
            this.enemy2.TabStop = false;
            // 
            // corazon2
            // 
            this.corazon2.Image = global::JuegoMedieval.Properties.Resources.unnamed;
            this.corazon2.Location = new System.Drawing.Point(199, 519);
            this.corazon2.Name = "corazon2";
            this.corazon2.Size = new System.Drawing.Size(19, 17);
            this.corazon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.corazon2.TabIndex = 12;
            this.corazon2.TabStop = false;
            // 
            // corazon1
            // 
            this.corazon1.Image = global::JuegoMedieval.Properties.Resources.unnamed;
            this.corazon1.Location = new System.Drawing.Point(174, 519);
            this.corazon1.Name = "corazon1";
            this.corazon1.Size = new System.Drawing.Size(19, 17);
            this.corazon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.corazon1.TabIndex = 13;
            this.corazon1.TabStop = false;
            // 
            // corazon3
            // 
            this.corazon3.Image = global::JuegoMedieval.Properties.Resources.unnamed;
            this.corazon3.Location = new System.Drawing.Point(224, 519);
            this.corazon3.Name = "corazon3";
            this.corazon3.Size = new System.Drawing.Size(19, 17);
            this.corazon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.corazon3.TabIndex = 14;
            this.corazon3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(112)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(267, 555);
            this.Controls.Add(this.corazon3);
            this.Controls.Add(this.corazon1);
            this.Controls.Add(this.corazon2);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.enemy1);
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
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corazon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corazon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corazon3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.Timer movementEnemy_left_1;
        private System.Windows.Forms.Timer movementEnemy_right_1;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox corazon2;
        private System.Windows.Forms.PictureBox corazon1;
        private System.Windows.Forms.PictureBox corazon3;
    }
}

