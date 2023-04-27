using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuanJuego
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private bool estaCaminando = false;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                movimiento_enemigo.Enabled = true;
                jugador.Left += 4;
                jugador.Image = JuanJuego.Properties.Resources.prota_caminando;
            }
            if(e.KeyCode == Keys.Space)
            {
                bala_jugador.Enabled = true;
                bala.Visible = true;
            }
            colision();
        }
        private void colision()
        {
            if (bala.Bounds.IntersectsWith(enemigo.Bounds))
            {
                enemigo.Enabled = false;
                movimiento_enemigo.Enabled = false;
                MessageBox.Show("Ganaste");
            }
        }

        private void movimiento_enemigo_Tick(object sender, EventArgs e)
        {
            enemigo.Left -= 4;
        }

        private void bala_jugador_Tick(object sender, EventArgs e)
        {
            bala.Left += 7;
        }
    }
}
