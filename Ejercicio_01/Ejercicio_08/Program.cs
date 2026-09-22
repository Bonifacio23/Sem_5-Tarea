using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    internal class Program
    {
        static public void Generar(int[] N)
        {
            Random rnd = new Random();
            for (int i = 0; i < N.Length; i++)
            {
                N[i] = rnd.Next(0, 200);
            }
        }
        static public void Imprimir(int[] N)
        {
            for (int i = 0; i < N.Length; i++)
            {
                Console.Write(N[i] + " ");
            }
            Console.WriteLine();
        }
        static public int Sumadig(int numero)
        {
            int suma = 0;
            while (numero > 0)
            {
                suma = suma + numero % 10;
                numero = numero / 10;
            }
            return suma;
        }
        static public int ContarDivisiblesEntre3(int[] N)
        {
            int contador = 0;
            for (int i = 0; i < N.Length; i++)
            {
                int suma = Sumadig(N[i]);
                if (suma % 3 == 0)
                {
                    contador++;
                }
            }
            Console.WriteLine("La cantidad de numeros divisibles entre 3 es: " + contador);
            return contador;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de numeros, menores a 200: ");
            int n = int.Parse(Console.ReadLine());
            int[] N = new int[n];
            Generar(N);
            Imprimir(N);
            ContarDivisiblesEntre3(N);
                
        }
    }
}
