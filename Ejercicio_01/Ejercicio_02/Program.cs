using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Program
    {
        static public void Leer(int[] N)
        {

            for (int i = 0; i < N.Length; i++)
            {
                int peso;
                do
                {

                    Console.Write("Ingrese el peso del cliente " + (i + 1) + ": ");
                    peso = int.Parse(Console.ReadLine());
                    if (peso < 0)
                    {
                        Console.WriteLine("Error, el valor del peso debe de ser positivo");
                    }
                }
                while (peso < 0);

                N[i] = peso;
            }
        }
        static public void Numero_Per(int[] N)
        {
            int Cont = 0;
            int Con = 0;
            int Co = 0;
            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] < 53)
                    Cont++;

                if (N[i] >= 53 && N[i] < 60)
                    Con++;
                if (N[i] >= 60)
                    Co++;
            }
            Console.WriteLine($"El numero de persona de contextura delgada son :{Cont}");
            Console.WriteLine($"El numero de persona de contextura mediana son :{Con}");
            Console.WriteLine($"El numero de persona de contextura gruesa son :{Co}");

        }

        static void Main(string[] args)
        {
            int[] N = new int[10];
            Leer(N);
            Numero_Per(N);
            Console.ReadKey();
        }
    }
}
