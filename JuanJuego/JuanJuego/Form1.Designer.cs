namespace JuanJuego
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
            this.jugador = new System.Windows.Forms.PictureBox();
            this.piso = new System.Windows.Forms.PictureBox();
            this.enemigo = new System.Windows.Forms.PictureBox();
            this.movimiento_enemigo = new System.Windows.Forms.Timer(this.components);
            this.bala = new System.Windows.Forms.PictureBox();
            this.bala_jugador = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.jugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bala)).BeginInit();
            this.SuspendLayout();
            // 
            // jugador
            // 
            this.jugador.BackColor = System.Drawing.Color.Transparent;
            this.jugador.Image = global::JuanJuego.Properties.Resources.prota_descansando;
            this.jugador.Location = new System.Drawing.Point(0, 266);
            this.jugador.Name = "jugador";
            this.jugador.Size = new System.Drawing.Size(68, 53);
            this.jugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jugador.TabIndex = 0;
            this.jugador.TabStop = false;
            // 
            // piso
            // 
            this.piso.BackColor = System.Drawing.Color.Transparent;
            this.piso.Location = new System.Drawing.Point(3, 321);
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(957, 44);
            this.piso.TabIndex = 1;
            this.piso.TabStop = false;
            // 
            // enemigo
            // 
            this.enemigo.BackColor = System.Drawing.Color.Transparent;
            this.enemigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemigo.Image = global::JuanJuego.Properties.Resources.jefe_fase1;
            this.enemigo.Location = new System.Drawing.Point(891, 251);
            this.enemigo.Name = "enemigo";
            this.enemigo.Size = new System.Drawing.Size(58, 64);
            this.enemigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemigo.TabIndex = 2;
            this.enemigo.TabStop = false;
            // 
            // movimiento_enemigo
            // 
            this.movimiento_enemigo.Tick += new System.EventHandler(this.movimiento_enemigo_Tick);
            // 
            // bala
            // 
            this.bala.BackColor = System.Drawing.Color.Transparent;
            this.bala.Image = global::JuanJuego.Properties.Resources.prota_disparando;
            this.bala.Location = new System.Drawing.Point(74, 266);
            this.bala.Name = "bala";
            this.bala.Size = new System.Drawing.Size(58, 50);
            this.bala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bala.TabIndex = 3;
            this.bala.TabStop = false;
            this.bala.Visible = false;
            // 
            // bala_jugador
            // 
            this.bala_jugador.Tick += new System.EventHandler(this.bala_jugador_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuanJuego.Properties.Resources.fondo6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 364);
            this.Controls.Add(this.bala);
            this.Controls.Add(this.enemigo);
            this.Controls.Add(this.piso);
            this.Controls.Add(this.jugador);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.jugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox jugador;
        private System.Windows.Forms.PictureBox piso;
        private System.Windows.Forms.PictureBox enemigo;
        private System.Windows.Forms.Timer movimiento_enemigo;
        private System.Windows.Forms.PictureBox bala;
        private System.Windows.Forms.Timer bala_jugador;
    }
}

