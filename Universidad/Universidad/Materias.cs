using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    public class Materias
    {
        private string nombreMateria;
        Estudiante estudiante;
        private double nota1;
        private double nota2;
        private double nota3;
        private double definitiva;

        public Materias(string nombreMateria, Estudiante estudiante, double nota1, double nota2, double nota3, double definitiva)
        {
            NombreMateria = nombreMateria;
            Estudiante = estudiante;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
            Definitiva = definitiva;
        }

        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }
        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }

        public double Definitiva { get => definitiva; set => definitiva = value; }

        public Estudiante Estudiante { get => estudiante; set => estudiante = value; }

        public override string ToString()
        {
            return $"Materia: {NombreMateria}, {Estudiante.ToString()} {Environment.NewLine}Nota 1: {Nota1} Nota 2: {Nota2} Nota 3: {Nota3} Definitva: {Definitiva}";
        }

    }
}
