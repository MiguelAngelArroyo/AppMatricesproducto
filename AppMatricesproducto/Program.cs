using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMatricesproducto
{
    class Program
    {
        static void Main(string[] args)
        {
            //matrices multidimencionales rectangulares
            int[,] A = new int[3,3];
            int[,] B = new int[3,2];
            int[,] C = new int[3,2];
            leer(A);
            imprimir(A);
            Console.WriteLine();
            leer(B);
            imprimir(B);
            Console.WriteLine();
            Console.WriteLine();
            multi(A, B, C);
            imprimir(C);
            Console.ReadKey();
        }
        public static void multi(int[,] A, int[,] B, int[,]C)
        {
            for (int i = 0; i < A.GetLength(0); i++) 
            {
                for (int j = 0; j < B.GetLength(1); j++) 
                {
                    C[i, j] = 0;
                    for (int k = 1; k < C.GetLength(0); k++) 
                    {
                        C[i, j] = C[i, j] + A[i, k] * B[k, j];
                    }
                }
            }
        }
        public static void leer(int [,] matriz)
        {
            Console.WriteLine("\ningrese los elementos de la matriz:");
            for(int i=0;i<matriz.GetLength(0);i++)
            {
                for(int j=0;j<matriz.GetLength(1);j++)
                {
                    string aux;
                    Console.Write(" [ {0}, {1} ] ", i, j);
                    aux = Console.ReadLine();
                    matriz[i, j] = Int32.Parse(aux);
                }
                Console.WriteLine();
            }
        }
        public static void imprimir(int[,] matriz)
        {
            Console.WriteLine("\nimprecion de la matriz");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(" {0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
