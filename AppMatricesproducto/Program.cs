﻿using System;
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
            Console.WriteLine();
            int[][,] matriz = new int[3][,];
            inicializar(matriz);
            Console.WriteLine();
            int[][][] m1 = new int[3][][];
            inicializar2(m1);
            Console.ReadKey();
        }
        public static void inicializar2(int [][][] m1)
        {
            m1[0]= new int [3,3,3];
            m1[1]= new int [3,3,2];
            m1[2]= new int [3,3,2];
            Console.WriteLine("\nMultiplicación de matrices utilizando arreglos multidimensionales escalonados");
            leer(m1[0]);
            leer(m1[1]);
            multi(m1[0], m1[1], m1[2]);
            imprimir(m1[2]);
        }
        public static void inicializar(int[][,] matriz)
        {
            matriz[0]= new int[3, 3];
            matriz[1]= new int[3, 2];
            matriz[2]= new int[3, 2];
            Console.WriteLine("\nMultiplicacion de matrices utilizando dimenciones escalonadas y rectangular");
            leer(matriz[0]);
            leer(matriz[1]);
            multi(matriz[0], matriz[1], matriz[2]);
            imprimir(matriz[2]);
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
