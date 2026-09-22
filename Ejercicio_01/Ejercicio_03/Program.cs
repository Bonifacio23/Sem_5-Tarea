using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Program
    {
        static public int[] Leer(int[] N)
        {
            Random edad = new Random();
            for (int i = 0; i < N.Length; i++)
            {
                N[i] = edad.Next(0, 120);
                Console.WriteLine($"Edad{i + 1}: {N[i]}");
            }
            return N;
        }
        static public void Imprimir(int[] N)
        {
            for (int i = 0; i < N.Length; i++)
            {
                Console.Write(N[i] + " ");
            }
            Console.WriteLine();
        }

        static public void Menor(int[] lista)
        {
            int indiceMenor = 0;
            for (int j = 1; j < lista.Length; j++)
            {
                if (lista[j] < lista[indiceMenor])
                {
                    indiceMenor = j;
                }
            }
            Console.WriteLine($"La menor edad es: {lista[indiceMenor]}");
        }
        static public void Numero_Per(int[] N)
        {
            int Cont = 0;
            for (int i = 0; i < N.Length; i++)
            {

                if (N[i] >= 30 && N[i] < 50)
                    Cont++;
            }
            Console.WriteLine($"El numero de persona que tienen entre 35 y 50 años es :{Cont}");

        }
        static public void Buscar(int[] N)
        {
            Console.WriteLine("ingrese la edad a buscar: ");
            int b = int.Parse(Console.ReadLine());
            bool encontrado = false;

            for (int i = 0; i < N.Length; i++)
            {
                if (b == N[i])
                {
                    Console.WriteLine($"Edad encontrada: {N[i]}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Edad no encontrada");
            }
        }
        static void Main(string[] args) { 

                Console.WriteLine("Ingrese el numero de personas: ");
                int n = int.Parse(Console.ReadLine());
                int[] N = new int[n];
                N = Leer(N);
                Numero_Per(N);
                Menor(N);
                Console.WriteLine("Desea buscar una edad en el arreglo [s/n]");
                String p = Console.ReadLine().ToLower();
                if (p == "s")
                    Buscar(N);
                else
                {
                    Console.WriteLine("ok");
                }




            }
        
    }
}
