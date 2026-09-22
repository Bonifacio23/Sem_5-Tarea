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
                Console.WriteLine($"Edad{i + 1}: [{N[i]}]");
            }
            return N;
        }
        static public void Menor(int[] lista)
        {
            int n = lista.Length;
            for (int i = 0; i < n; i++)
            {
                int menor = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (lista[j] < lista[menor])
                        menor = j;
                }
                int temp = lista[i];
                lista[i] = lista[menor];
                lista[menor] = temp;
                Console.WriteLine($"La menor edad es [{i + 1}]: {lista[i]}");
            }
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
            for (int i = 0; i < N.Length; i++)
            {
                if (b == N[i])
                    Console.WriteLine($"Edad encontrada: {N[i]}");
                else
                    Console.WriteLine("edad no encontrada");
                break;
            }
        }
        static void Main(string[] args) { 

                Console.WriteLine("Ingrese el numero de personas: ");
                int n = int.Parse(Console.ReadLine());
                int[] N = new int[n];
                N = Leer(N);
                Numero_Per(N);
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
