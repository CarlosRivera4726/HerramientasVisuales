using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    public class Estudiante
    {
        private string nombre;
        private string apellido;
        private int codigo;

        public Estudiante(string nombre, string apellido, int codigo)
        {
            Nombre = nombre; 
            Apellido = apellido;
            Codigo = codigo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; } 

        public int Codigo { get => codigo; set => codigo = value; }

        public override string ToString()
        {
            return $"Estudiante: {Nombre} {Apellido}, Codigo: {Codigo}";
        }
    }
}
