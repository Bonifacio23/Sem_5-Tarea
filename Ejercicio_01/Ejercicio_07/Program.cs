using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    internal class Program
    {
        static public void Frecuencia(int[] N)
        {
            int notaMasRepetida = N[0];
            int mayorFrecuencia = 0;

            for (int i = 0; i < N.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < N.Length; j++)
                {
                    if (N[i] == N[j])
                    {
                        c++;
                    }
                }
                Console.WriteLine($"el numero {N[i]} se repitio {c}");

                if (c > mayorFrecuencia)
                {
                    mayorFrecuencia = c;
                    notaMasRepetida = N[i];
                }
            }

            Console.WriteLine($"La nota que mas se repitio fue {notaMasRepetida} con {mayorFrecuencia} veces");
        }
        static public int[] Leer(int[] N)
        {
            Random nota = new Random();
            for (int i = 0; i < N.Length; i++)
            {
                N[i] = nota.Next(0,21);
                Console.WriteLine($"Nota[{i + 1}]: {N[i]}");
            }
            return N;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de alumnos: ");
            int a = int.Parse(Console.ReadLine());
            int[] N = new int[a];
            Leer(N);
            Frecuencia(N);

        }
    }
}
