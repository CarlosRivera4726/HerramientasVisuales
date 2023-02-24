using System;
using System.Collections;

namespace EjercicioEnum
{
    class Program
    {

    
        enum DIAS_SEMANA
        {
            LUNES,
            MARTES,
            MIERCOLES,
            JUEVES,
            VIERNES,
            SABADO,
            DOMINGO
        }
        enum MESES
        {
            ENERO,
            FEBRERO,
            MARZO,
            ABRIL,
            MAYO,
            JUNIO,
            JULIO,
            AGOSTO,
            SEPTIEMBRE,
            OCTUBRE,
            NOVIEMBRE,
            DICIEMBRE
        }

        static void Main(string[] args)
        {
            

            try
            {
                ArrayList diasReuniones = new ArrayList();
                
                string[] diasSeleccionados = menuOpciones().Split(',');

                foreach(string dias in diasSeleccionados)
                {
                    diasReuniones.Add((DIAS_SEMANA)int.Parse(dias)-1);
                }

                Console.WriteLine("Dias de reuniones: ");
                foreach(DIAS_SEMANA dias in diasReuniones)
                {
                    Console.WriteLine(dias);
                }


            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                Console.ReadKey();
            }

            

        }

        private static string menuOpciones()
        {
            Console.Write("Selecciona los dias de reuniones, separados por coma ex(1,3,6): " +
                "\n1) " + DIAS_SEMANA.LUNES +
                "\n2) " + DIAS_SEMANA.MARTES +
                "\n3) " + DIAS_SEMANA.MIERCOLES +
                "\n4) " + DIAS_SEMANA.JUEVES +
                "\n5) " + DIAS_SEMANA.VIERNES +
                "\n6) " + DIAS_SEMANA.SABADO +
                "\n7) " + DIAS_SEMANA.DOMINGO +
                "\nIngrese un valor: ");
            return Console.ReadLine();
        }
    }
}
