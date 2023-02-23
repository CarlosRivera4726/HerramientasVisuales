using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioForeach
{
    public partial class Form1 : Form
    {
        ArrayList nombres = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nombres.Add(txtNombres.Text);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            lblNombres.Text = null;
            nombres.Sort();
            foreach(string nombre in nombres)
            {
                lblNombres.Text += nombre + ", ";
            }
            lblNombres.Visible = true;
        }
    }
}
