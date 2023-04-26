namespace Universidad
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cBEstudiantes = new System.Windows.Forms.ComboBox();
            this.txtMaterias = new System.Windows.Forms.TextBox();
            this.btnBuscarMateria = new System.Windows.Forms.Button();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidoEstudiante = new System.Windows.Forms.TextBox();
            this.txtEstudiantes = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.btnModificarEstudiante = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnEliminarEstudiante = new System.Windows.Forms.Button();
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cBEstudiantes);
            this.panel1.Controls.Add(this.txtMaterias);
            this.panel1.Controls.Add(this.btnBuscarMateria);
            this.panel1.Controls.Add(this.btnModificarMateria);
            this.panel1.Controls.Add(this.btnEliminarMateria);
            this.panel1.Controls.Add(this.btnAgregarMateria);
            this.panel1.Controls.Add(this.txtNota3);
            this.panel1.Controls.Add(this.lblNota3);
            this.panel1.Controls.Add(this.txtNota2);
            this.panel1.Controls.Add(this.lblNota2);
            this.panel1.Controls.Add(this.txtNota1);
            this.panel1.Controls.Add(this.lblNota1);
            this.panel1.Controls.Add(this.txtNombreMateria);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(408, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 580);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(62, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estudiante:";
            // 
            // cBEstudiantes
            // 
            this.cBEstudiantes.FormattingEnabled = true;
            this.cBEstudiantes.Items.AddRange(new object[] {
            "Seleccione un Estudiante"});
            this.cBEstudiantes.Location = new System.Drawing.Point(136, 160);
            this.cBEstudiantes.Name = "cBEstudiantes";
            this.cBEstudiantes.Size = new System.Drawing.Size(152, 21);
            this.cBEstudiantes.TabIndex = 5;
            this.cBEstudiantes.Tag = "";
            // 
            // txtMaterias
            // 
            this.txtMaterias.Location = new System.Drawing.Point(43, 265);
            this.txtMaterias.Multiline = true;
            this.txtMaterias.Name = "txtMaterias";
            this.txtMaterias.ReadOnly = true;
            this.txtMaterias.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMaterias.Size = new System.Drawing.Size(318, 202);
            this.txtMaterias.TabIndex = 6;
            // 
            // btnBuscarMateria
            // 
            this.btnBuscarMateria.Location = new System.Drawing.Point(124, 208);
            this.btnBuscarMateria.Name = "btnBuscarMateria";
            this.btnBuscarMateria.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMateria.TabIndex = 8;
            this.btnBuscarMateria.Text = "Buscar";
            this.btnBuscarMateria.UseVisualStyleBackColor = true;
            this.btnBuscarMateria.Click += new System.EventHandler(this.btnBuscarMateria_Click);
            // 
            // btnModificarMateria
            // 
            this.btnModificarMateria.Location = new System.Drawing.Point(205, 208);
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Size = new System.Drawing.Size(75, 23);
            this.btnModificarMateria.TabIndex = 9;
            this.btnModificarMateria.Text = "Modificar";
            this.btnModificarMateria.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Location = new System.Drawing.Point(286, 208);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMateria.TabIndex = 10;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(43, 208);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMateria.TabIndex = 7;
            this.btnAgregarMateria.Text = "Agregar";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(136, 134);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(43, 20);
            this.txtNota3.TabIndex = 4;
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota3.ForeColor = System.Drawing.Color.White;
            this.lblNota3.Location = new System.Drawing.Point(84, 135);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(46, 15);
            this.lblNota3.TabIndex = 1;
            this.lblNota3.Text = "Nota 3:";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(136, 108);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(43, 20);
            this.txtNota2.TabIndex = 3;
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota2.ForeColor = System.Drawing.Color.White;
            this.lblNota2.Location = new System.Drawing.Point(84, 108);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(46, 15);
            this.lblNota2.TabIndex = 1;
            this.lblNota2.Text = "Nota 2:";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(136, 82);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(43, 20);
            this.txtNota1.TabIndex = 2;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota1.ForeColor = System.Drawing.Color.White;
            this.lblNota1.Location = new System.Drawing.Point(84, 82);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(46, 15);
            this.lblNota1.TabIndex = 1;
            this.lblNota1.Text = "Nota 1:";
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(136, 56);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(152, 20);
            this.txtNombreMateria.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(75, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materias";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtApellidoEstudiante);
            this.panel2.Controls.Add(this.txtEstudiantes);
            this.panel2.Controls.Add(this.lblApellido);
            this.panel2.Controls.Add(this.btnBuscarEstudiante);
            this.panel2.Controls.Add(this.txtNombreEstudiante);
            this.panel2.Controls.Add(this.btnModificarEstudiante);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.btnEliminarEstudiante);
            this.panel2.Controls.Add(this.btnAgregarEstudiante);
            this.panel2.Location = new System.Drawing.Point(1, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 580);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(150, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estudiantes";
            // 
            // txtApellidoEstudiante
            // 
            this.txtApellidoEstudiante.Location = new System.Drawing.Point(137, 82);
            this.txtApellidoEstudiante.Name = "txtApellidoEstudiante";
            this.txtApellidoEstudiante.Size = new System.Drawing.Size(152, 20);
            this.txtApellidoEstudiante.TabIndex = 2;
            // 
            // txtEstudiantes
            // 
            this.txtEstudiantes.Location = new System.Drawing.Point(41, 265);
            this.txtEstudiantes.Multiline = true;
            this.txtEstudiantes.Name = "txtEstudiantes";
            this.txtEstudiantes.ReadOnly = true;
            this.txtEstudiantes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEstudiantes.Size = new System.Drawing.Size(318, 202);
            this.txtEstudiantes.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(76, 82);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(122, 208);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEstudiante.TabIndex = 4;
            this.btnBuscarEstudiante.Text = "Buscar";
            this.btnBuscarEstudiante.UseVisualStyleBackColor = true;
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Location = new System.Drawing.Point(137, 55);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(152, 20);
            this.txtNombreEstudiante.TabIndex = 1;
            // 
            // btnModificarEstudiante
            // 
            this.btnModificarEstudiante.Location = new System.Drawing.Point(203, 208);
            this.btnModificarEstudiante.Name = "btnModificarEstudiante";
            this.btnModificarEstudiante.Size = new System.Drawing.Size(75, 23);
            this.btnModificarEstudiante.TabIndex = 5;
            this.btnModificarEstudiante.Text = "Modificar";
            this.btnModificarEstudiante.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(76, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnEliminarEstudiante
            // 
            this.btnEliminarEstudiante.Location = new System.Drawing.Point(284, 208);
            this.btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            this.btnEliminarEstudiante.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarEstudiante.TabIndex = 6;
            this.btnEliminarEstudiante.Text = "Eliminar";
            this.btnEliminarEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(41, 208);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEstudiante.TabIndex = 3;
            this.btnAgregarEstudiante.Text = "Agregar";
            this.btnAgregarEstudiante.UseVisualStyleBackColor = true;
            this.btnAgregarEstudiante.Click += new System.EventHandler(this.btnAgregarEstudiante_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaterias;
        private System.Windows.Forms.Button btnBuscarMateria;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBEstudiantes;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtApellidoEstudiante;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtEstudiantes;
        private System.Windows.Forms.Button btnBuscarEstudiante;
        private System.Windows.Forms.Button btnModificarEstudiante;
        private System.Windows.Forms.Button btnEliminarEstudiante;
        private System.Windows.Forms.Button btnAgregarEstudiante;
    }
}

