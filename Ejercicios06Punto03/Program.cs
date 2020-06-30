using System;

namespace Ejercicios06Punto03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Pasar nros base 10 a Binario";
            var contador = 0;
            double nroBinario = 0;
            var nroDecimal = 0;
            var noSalir = true;
            Console.Write("Ingrese un número en base 10:");
            while (!int.TryParse(Console.ReadLine(), out nroDecimal))
            {
                Console.WriteLine("Trate otra vez con un nro entero");
            }

            do
            {
                var resto = nroDecimal % 2;
                nroBinario =nroBinario +resto * Math.Pow(10,contador);
                nroDecimal = nroDecimal / 2;
                contador++;
                if (nroDecimal < 2)
                {
                    nroBinario = nroBinario + nroDecimal * Math.Pow(10, contador);
                    noSalir = false;
                }
            } while (noSalir);
            Console.WriteLine($"Equivalente en binario es= {nroBinario}");
        }
    }
}
