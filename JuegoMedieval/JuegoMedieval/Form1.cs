using SharpDX.Direct2D1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Media;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.DirectWrite;

namespace JuegoMedieval
{
    public partial class Form1 : Form
    {
        private static int posXJugador = 0;
        private static int posYJugador = 0;
        private int puntaje = 0;
        private static int PASOS_JUGADOR = 12;
        private static int SALTOS_JUGADOR = 35;
        // limitamos los saltos dados! min-> 1 max-> 2
        private static int min_saltos = 1;
        private static int max_saltos = 3;
        private int contSaltos = 0;
        public Form1()
        {
            InitializeComponent();
            movementEnemy_left_1.Enabled = true;
            posXJugador = jugador.Location.X;
            posYJugador = jugador.Location.Y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                jugador.Left -= PASOS_JUGADOR;
                jugador.Image = JuegoMedieval.Properties.Resources.caminando_espalda_izq;

            }
            if(e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                jugador.Left += PASOS_JUGADOR;
                jugador.Image = JuegoMedieval.Properties.Resources.caminando_espalda_derecha;
            }

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                jugador.Top += SALTOS_JUGADOR/4;
                jugador.Image = JuegoMedieval.Properties.Resources.caminando_espalda_izq;

                colisionEscalones(escalon1);
                colisionEscalones(escalon2);
                colisionEscalones(escalon3);
                colisionEscalones(escalon4);
                colisionPiso(piso);
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                contSaltos++;
                if(contSaltos >= min_saltos && contSaltos <= max_saltos) {

                    jugador.Top -= SALTOS_JUGADOR;
                    jugador.Image = JuegoMedieval.Properties.Resources.saltando_espalda_derecha;

                    colisionEscalones(escalon1);
                    colisionEscalones(escalon2);
                    colisionEscalones(escalon3);
                    colisionEscalones(escalon4);
                }
                else
                {
                    MessageBox.Show("Superaste el # de saltos");
                    movementPlayer.Enabled = true;
                    contSaltos = 0;
                }

            }
            if (e.KeyCode == Keys.Space)
            {
                jugador.Image = JuegoMedieval.Properties.Resources.movimiento_ataque_espalda_dercha;
                if (jugador.Bounds.IntersectsWith(enemy1.Bounds))
                {
                    puntaje++;
                    lblPuntaje.Text = "Puntaje: " + puntaje;
                    enemy1.Enabled = false;
                    enemy1.Visible = false;
                    movementEnemy_left_1.Enabled = false;
                    movementEnemy_right_1.Enabled = false;
                }
                contSaltos = 0;
            }

            colicionParedes();

        }

        #region COLISION ESCALONES
        private void colisionEscalones(PictureBox escalon)
        {
            if (jugador.Bounds.IntersectsWith(escalon.Bounds))
            {
                if (jugador.Bottom >= escalon.Top)
                {
                    Console.WriteLine("TOCO LA PARTE DE ARRIBA DEL ESCALON");
                    jugador.Location = new Point(escalon.Bounds.X+20, escalon.Bounds.Y - 60);
                    contSaltos = 0;
                    movementPlayer.Enabled = false;
                    return;
                }
                if (jugador.Top <= escalon.Bottom)
                {
                    Console.WriteLine("TOCO LA PARTE DE ABAJO DEL ESCALON");

                }

            }
            else
            {
                // verificamos que este en un espacio libre
            }
           // if()
        }
        #endregion
        private void colisionPiso(PictureBox piso)
        {
            if (jugador.Bounds.IntersectsWith(piso.Bounds))
            {
                movementPlayer.Enabled = false;
                jugador.Location = new Point(piso.Location.X+20, jugador.Location.Y - 15);
            }
        }

        #region colicionParedes
        private void colicionParedes()
        {
            if (jugador.Bounds.IntersectsWith(paredDerechaEscalon1.Bounds))
            {
                jugador.Image = JuegoMedieval.Properties.Resources.caminando_espalda_izq;
                jugador.Location = new Point(paredDerechaEscalon1.Location.X-40, jugador.Location.Y);
            }
            if (jugador.Bounds.IntersectsWith(paredIzquierdaCompleta.Bounds))
            {
                jugador.Image = JuegoMedieval.Properties.Resources.caminando_espalda_derecha;
                jugador.Location = new Point(paredIzquierdaCompleta.Location.X+20, jugador.Location.Y);
                
            }

            if (jugador.Bounds.IntersectsWith(paredDerechaCompleta.Bounds))
            {
                jugador.Image = JuegoMedieval.Properties.Resources.caminando_espalda_izq;
                jugador.Location = new Point(paredDerechaCompleta.Location.X - 30, jugador.Location.Y);

            }

            
            Console.WriteLine("Posicion del Jugador (X,Y): " + jugador.Location);

        }
        #endregion
        // para imprimir las posiciones de las paredes necesarias, ademas de la posicion del jugador

        #region MOVEMENT_TICK
        private void movementPlayer_Tick(object sender, EventArgs e)
        {
            jugador.Top += SALTOS_JUGADOR/2;
            colisionEscalones(escalon1);
            colisionEscalones(escalon2);
            colisionEscalones(escalon3);
            colisionEscalones(escalon4);
            colisionPiso(piso);
        }
        #endregion

        #region DEBUG
        private void debugeoPorConsola(PictureBox localizacion)
        {
            Console.WriteLine("Localizacion: " + localizacion.Location);
        }
        #endregion

        private void perdido()
        {
            if (enemy1.Bounds.IntersectsWith(jugador.Bounds))
            {
                MessageBox.Show("has perdido", "Loss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                jugador.Location = new Point(posXJugador, posYJugador);
            }
        }
        private void movementEnemy_left_1_Tick(object sender, EventArgs e)
        {
            //debugeoPorConsola(enemy1);
            enemy1.Left -= 8;
            if(enemy1.Location.X <= 101)
            {
                movementEnemy_right_1.Enabled = true;
                movementEnemy_left_1.Enabled = false;
                enemy1.Image = JuegoMedieval.Properties.Resources.output_onlinegiftools___copia;
            }
            perdido();
            
        }
        // Paint it black

        private void movementEnemy_right_1_Tick(object sender, EventArgs e)
        {
            //debugeoPorConsola(enemy1);
            enemy1.Left += 8;
            if(enemy1.Location.X >= 173)
            {
                movementEnemy_right_1.Enabled = false;
                movementEnemy_left_1.Enabled = true;
                enemy1.Image = JuegoMedieval.Properties.Resources.output_onlinegiftools;
            }

            perdido();

        }
    }
}
