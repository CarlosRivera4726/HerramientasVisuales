// See https://aka.ms/new-console-template for more information

using System;

namespace Ejercicio1y2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // pedimos numero
            /*TODO: DESCOMENTAR PARA EL EJERCICIO WHILE
             * Console.Write("Ingresa un número para multiplicar: ");
            int numeroAMultiplicar = int.Parse(Console.ReadLine());
            int LIMITE = 1;
            while (LIMITE > 0 && LIMITE <= 10)
            {
                Console.WriteLine($"{numeroAMultiplicar} X {LIMITE} = {LIMITE * numeroAMultiplicar}");
                LIMITE++;
            
            */

            /* TODO: DESCOMENTAR PARA EL EJERCICIO DO WHILE
            // determinamos si un numero es positivo y negativo, y tener un contador
            // si coloca cero se finaliza la ejecucion
            int negativos=0, positivos=0;
            bool isZero = false;
            do
            {
                Console.Write("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());
                if(numero > 0)
                {
                    positivos++;
                }else if(numero < 0)
                {
                    negativos++;
                }
                else
                {
                    isZero = true;
                }
            } while (!isZero);

            Console.WriteLine($"Positivos: {positivos}, Negativos: {negativos}");
            */

            // ciclo for
            int ancho, alto;
            bool hasRelleno = false;
            char relleno = '*';

            ancho = int.Parse(Console.ReadLine());
            alto = int.Parse(Console.ReadLine());

            for (int i = 0; i < ancho; i++)
            {
                for(int j = 0; j < alto; j++)
                {
                    Console.Write(relleno);
                    if (!hasRelleno)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}



