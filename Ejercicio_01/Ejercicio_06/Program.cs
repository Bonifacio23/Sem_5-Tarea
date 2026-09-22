using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static public void Generar(int[] N)
    {
        Random rnd = new Random();
        for (int i = 0; i < N.Length; i++)
        {
            N[i] = rnd.Next(25, 501);
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

    static public void OrdenarAscendente(int[] N)
    {
        int n = N.Length;
        for (int i = 0; i < n; i++)
        {
            int menor = i;
            for (int j = i + 1; j < n; j++)
            {
                if (N[j] < N[menor])
                {
                    menor = j;
                }
            }
            int aux = N[i];
            N[i] = N[menor];
            N[menor] = aux;
        }
    }

    static public int ContarEntreRango(int[] N, int min, int max)
    {
        int contador = 0;
        for (int i = 0; i < N.Length; i++)
        {
            if (N[i] >= min && N[i] <= max)
            {
                contador++;
            }
        }
        return contador;
    }

    static public int ContarImpares(int[] N)
    {
        int contador = 0;
        for (int i = 0; i < N.Length; i++)
        {
            if (N[i] % 2 != 0)
            {
                contador++;
            }
        }
        return contador;
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad de personas (maximo 200): ");
        int n = int.Parse(Console.ReadLine());

        int[] N = new int[n];
        Generar(N);

        Console.WriteLine("Listado de montos generados:");
        Imprimir(N);

        OrdenarAscendente(N);
        Console.WriteLine("Listado ordenado ascendentemente:");
        Imprimir(N);

        int enRango = ContarEntreRango(N, 100, 300);
        int impares = ContarImpares(N);

        Console.WriteLine("Personas que gastaron entre 100 y 300 soles: " + enRango);
        Console.WriteLine("Cantidad de montos impares: " + impares);

        Console.ReadKey();
    }
}