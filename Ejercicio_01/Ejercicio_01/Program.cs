using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Program
    {

        static public int[] EliminarMenor(int[] notas)
        {
            int indiceMenor = 0;
            for (int j = 1; j < notas.Length; j++)
            {
                if (notas[j] < notas[indiceMenor])
                    indiceMenor = j;
            }
            int[] nuevo = new int[notas.Length - 1];
            int pos = 0;
            for (int j = 0; j < notas.Length; j++)
            {
                if (j != indiceMenor)
                {
                    nuevo[pos] = notas[j];
                    pos++;
                }
            }
            return nuevo;
        }
        static public void Leer(int[] N)
        {

            for (int i = 0; i < N.Length; i++)
            {
                int nota;
                do
                {

                    Console.Write("Ingrese nota " + (i + 1) + ": ");
                    nota = int.Parse(Console.ReadLine());
                    if (nota < 0 || nota > 20)
                    {
                        Console.WriteLine("Error, el valor de la nota debe de ser entre 0 y 20");
                    }
                }
                while (nota < 0 || nota > 20);
                N[i] = nota;
                }
        }
        static public void Imprimir(int[] N)
        {
            Console.WriteLine("Notas despues de eliminar la menor:");
            for (int i = 0; i < N.Length; i++)
            {
                Console.WriteLine(N[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] N = new int[6];
            Leer(N);
            N = EliminarMenor(N);
            Imprimir(N);
            Console.ReadKey();

        }
    }
}
