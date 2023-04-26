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

namespace JuegoMedieval
{
    public partial class Form1 : Form
    {
        private static int PASOS_JUGADOR = 12;
        private static int SALTOS_JUGADOR = 90;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.A)
            {
                jugador.Left -= PASOS_JUGADOR;
                jugador.Image = JuegoMedieval.Properties.Resources.caminando_espalda_izq;

            }
            if(e.KeyCode == Keys.D)
            {
                jugador.Left += PASOS_JUGADOR;
                jugador.Image = JuegoMedieval.Properties.Resources.caminando_espalda_derecha;
            }

            if (e.KeyCode == Keys.S)
            {
                jugador.Top += SALTOS_JUGADOR-40;
                jugador.Image = JuegoMedieval.Properties.Resources.caminando_espalda_izq;
                colicionEscalones();

            }

            if (e.KeyCode == Keys.Space)
            {
                jugador.Top -= SALTOS_JUGADOR;
                jugador.Image = JuegoMedieval.Properties.Resources.saltando_espalda_derecha;
                
                colicionEscalones();
            }

            colicionParedes();

        }
        private void colicionEscalones()
        {
            int widthJugador = jugador.Bounds.Width;
            int posXJugador = jugador.Bounds.X;
            int posYJugador = jugador.Bounds.Y;

            int widthEscalon1 = escalon1.Bounds.Width;
            int heightEscalon1 = escalon1.Bounds.Height;

            int posXEscalon1 = escalon1.Bounds.X;
            int posYEscalon1 = escalon1.Bounds.Y;

            bool posX = (posXJugador + widthJugador) >= posXEscalon1 && (posXJugador + widthJugador) >= posXEscalon1 + widthEscalon1;
            bool posY = (posYJugador >= posYEscalon1 && posYJugador < posYEscalon1 + heightEscalon1);
            if (posX && posY)
            {
                MessageBox.Show("OOPS!");
            }
        }

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

            if (jugador.Bounds.IntersectsWith(piso.Bounds))
            {
                movementPlayer.Enabled = false;
                jugador.Image = JuegoMedieval.Properties.Resources.caminando_espalda_derecha;
                jugador.Location = new Point(paredIzquierdaCompleta.Location.X + 20, jugador.Location.Y + 2);

                // Verificar si el jugador ha tocado el piso
                if (jugador.Top < piso.Top)
                {
                    // Establecer la posición del jugador en el piso
                    jugador.Top = piso.Top - jugador.Height;
                }
            }
            Console.WriteLine("Posicion del Jugador (X,Y): " + jugador.Location);

        }
        // para imprimir las posiciones de las paredes necesarias, ademas de la posicion del jugador
        private void debugeoPorConsola()
        {
            Console.WriteLine("Posicion pared izq: " + paredIzquierdaCompleta.Location);
            Console.WriteLine("Posicion pared Derecha: " + paredDerechaEscalon1.Location);
            Console.WriteLine("Posicion Jugador : " + jugador.Location);
        }

        private void movementPlayer_Tick(object sender, EventArgs e)
        {
            jugador.Top += SALTOS_JUGADOR-40;
            colicionEscalones();
        }
    }
}
