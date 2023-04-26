using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universidad
{
    public partial class Form1 : Form
    {
        ArrayList estudiantes = new ArrayList();
        ArrayList materias = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            if(txtNombreEstudiante.Text != "" || txtApellidoEstudiante.Text != "")
            {
                cBEstudiantes.Items.Clear();
                cBEstudiantes.Items.Add("Seleccione un Estudiante");
                txtEstudiantes.Clear();
                string nombre = txtNombreEstudiante.Text;
                string apellido = txtApellidoEstudiante.Text;
                // generamos el codigo de forma aleatoria
                Random random = new Random();
                int codigo = random.Next(1000,4000);
                estudiantes.Add(new Estudiante(nombre, apellido, codigo));
                int index = 1;
                foreach(Estudiante estudiante in estudiantes)
                {
                    string datoAgregado = index + ") " + estudiante;

                    cBEstudiantes.Items.Add(datoAgregado);
                    txtEstudiantes.Text += datoAgregado + Environment.NewLine;
                    index++;
                }
                 
            }
            else
            {
                MessageBox.Show("Rellene todos los campos de estudiante!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            txtMaterias.Clear();
            if((txtNombreMateria.Text != "" || txtNota1.Text != "" || txtNota2.Text != "" || txtNota3.Text != "") && cBEstudiantes.SelectedIndex != 0)
            {
                string nombreMateria = txtNombreMateria.Text;
                double nota1 = double.Parse(txtNota1.Text);
                double nota2 = double.Parse(txtNota2.Text);
                double nota3 = double.Parse(txtNota3.Text);
                double definitiva = (nota1 + nota2 + nota3) / 3;

                materias.Add(new Materias(nombreMateria, (Estudiante)estudiantes[cBEstudiantes.SelectedIndex - 1], nota1, nota1, nota3, definitiva));
                int index = 1;
                foreach(Materias materia in materias)
                {
                    txtMaterias.Text += index + ") " + materia.ToString();
                    index++;
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos de materias!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarMateria_Click(object sender, EventArgs e)
        {

        }
    }
}
