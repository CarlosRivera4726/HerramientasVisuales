using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Struct
{
    struct Vigilante
    {
        private string nombre { get; set; }
        private string apellido { get; set; }
        private string arma { get; set; }

        public Vigilante(string nombre, string apellido, string arma)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.arma = arma;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Arma
        {
            get { return arma; }
            set { arma = value; }
        }

        public override string ToString()
        {
            return $"Vigilante: " +
                $"\nNombre: {this.nombre}" +
                $"\nApellido: {this.apellido}" +
                $"\nArma: {this.arma}\n";
        }
    }
    class Program
    {

        private static ArrayList vigilantes = new ArrayList();
        private static string[] datosPersonales = new string[3];
        private static bool isValid = false;
        static void Main(string[] args)
        {

            bool isActive = true;
            //funcion para agregar
            agregar(isActive);

            // una vez finalizada la funcion de agregar, mostramos los vigilantes agregados.
            mostrarVigilantes();

            // funcion para modificar
            modificarVigilantes(isActive);

            // funcion para eliminar 
            eliminarVigilantes(isActive);
            //parar el finalizado de la consola
            Console.ReadKey();
            
        }

        private static void eliminarVigilantes(bool isDeleted)
        {
            do
            {
                Console.WriteLine("*******Eliminar Vigilantes**** ");
                // pedimos el index del vigilante a eliminar
                Console.Write("Ingresa el index del vigilante: ");
                int indexVigilante = int.Parse(Console.ReadLine()) - 1;
                // verificamos que el index ingresado sea valido
                isValid = ((indexVigilante >= 0) && (indexVigilante <= vigilantes.Count));
                if (!isValid)
                {
                    Console.WriteLine("ERROR: INDEX INVALIDO");
                    break;
                }
                // buscamos y mostramos el vigilante en el array list por el index establecido
                mostrarVigilante(indexVigilante);
                vigilantes.RemoveAt(indexVigilante);

                Console.WriteLine("*********VIGILANTES RESTANTES*******");
                mostrarVigilantes();
                isDeleted = continuarEjecucion("Desea seguir eliminado a los vigilantes? (si o no): ");

            } while (isDeleted);
            }
        private static void modificarVigilantes(bool isModified)
        {
            do {
                Console.WriteLine("*******Modificar Vigilantes**** ");
                // pedimos el index del vigilante a modificar
                Console.Write("Ingresa el index del vigilante: ");
                int indexVigilante = int.Parse(Console.ReadLine()) - 1;
                // verificamos que el index ingresado sea valido
                isValid = ((indexVigilante > -1) && (indexVigilante <= vigilantes.Count));
                if (!isValid)
                {
                    Console.WriteLine("ERROR: INDEX INVALIDO");
                    break;
                }
                // busca el vigilante en el array list por el index establecido
                mostrarVigilante(indexVigilante);
                datosPersonales = pedirDatos();
                
                string nombreNuevo = datosPersonales[0];
                string apellidoNuevo = datosPersonales[1];
                string armaNuevo = datosPersonales[2];

                if (nombreNuevo.Length < 1 && apellidoNuevo.Length < 1 && armaNuevo.Length < 1)
                {
                    Console.WriteLine("No ha ingresado datos para modificar!");
                    mostrarVigilante(indexVigilante);
                }
                // creamos el objeto de tipo vigilante el cual tiene los datos anteriores y reemplazamos
                Vigilante vigilante = (Vigilante)vigilantes[indexVigilante];
                // creamos las condiciones necesarias para las combinaciones
                vigilante.Nombre = nombreNuevo;
                vigilante.Apellido = apellidoNuevo;
                vigilante.Arma = armaNuevo;

                // reemplazamos el objeto
                vigilantes[indexVigilante] = vigilante;

                // volvemos a imprimir el objeto dado
                mostrarVigilante(indexVigilante);
                Console.WriteLine("***********TODOS LOS VIGILANTES REGISTRADOS**********");
                mostrarVigilantes();

                isModified = continuarEjecucion("Desea seguir modificando a los vigilantes? (si o no): ");
            } while (isModified);

        }
        private static void mostrarVigilante(int indexVigilante) => Console.WriteLine((indexVigilante + 1) + ") " + vigilantes[indexVigilante]);
            
        
        private static void mostrarVigilantes()
        {
            int index = 1;
            foreach (Vigilante vigilante in vigilantes)
            {
                Console.WriteLine($"{index}) {vigilante}");
                index++;
            }
        }

        private static void agregar(bool isAdd)
        {
            do{
                datosPersonales = pedirDatos();
                Vigilante vigi = new Vigilante(datosPersonales[0], datosPersonales[1], datosPersonales[2]);
                vigilantes.Add(vigi);

                isAdd = continuarEjecucion("Desea agregar más vigilantes? (si o no): ");
            } while (isAdd);
        }

        private static bool continuarEjecucion(string mensaje)
        {
            Console.Write(mensaje);
            string opcion = Console.ReadLine().ToLower();
            bool isContinue = (opcion.Equals("si") || opcion.Equals("s")) ? true : false;
            return isContinue;
        }

        private static string[] pedirDatos()
        {
            Console.Write("Escriba su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Escriba su apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Escriba su arma: ");
            string arma = Console.ReadLine();

            return new string[]{ nombre, apellido, arma};
        }
    }
}
