using System;

class Program
{
    static void Main()
    {
        //Error por falta de corchetes alrededor de la declaracion de la matriz
        int[,] matriz = new int[3, 2];

        matriz[0, 0] = 1;
        matriz[0, 1] = 2;
        matriz[1, 0] = 3;
        matriz[1, 1] = 4;
        matriz[2, 0] = 5;
        matriz[2, 1] = 6;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
         Console.WriteLine("Elemento en la posicion [ {0}, {1} ]: {2}", i, j, matriz[i, j]);  
            }
        }
        //Falta el punto y coma en Console ReadLine
        Console.ReadLine();
    }
}
