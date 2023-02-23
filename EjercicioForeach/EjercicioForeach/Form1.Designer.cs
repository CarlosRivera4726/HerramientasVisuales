
namespace EjercicioForeach
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.PName = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNombres = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.PName.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(91, 46);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(151, 20);
            this.txtNombres.TabIndex = 1;
            // 
            // PName
            // 
            this.PName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PName.Controls.Add(this.btnAgregar);
            this.PName.Controls.Add(this.lblNombre);
            this.PName.Controls.Add(this.txtNombres);
            this.PName.Location = new System.Drawing.Point(0, 2);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(285, 213);
            this.PName.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(103, 99);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblNombres);
            this.panel2.Controls.Add(this.btnOrdenar);
            this.panel2.Location = new System.Drawing.Point(291, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 213);
            this.panel2.TabIndex = 3;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(115, 49);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(0, 13);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Visible = false;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(118, 99);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 0;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 222);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PName.ResumeLayout(false);
            this.PName.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Panel PName;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Button btnOrdenar;
    }
}

