using System;
namespace arreglodoble
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Declara la tabla");
      int [,] tabla = declareTable(5,4);

      Console.WriteLine("Lee el valor (2,3) en la matriz");
      readTableCell(tabla,2,3);
    }
    public static int[,] declareTable (int rows,int columns)
    {
      int[,] matriz = new int [rows,columns];
      for (int i=0;i <rows;i++)
      {
        for (int j=0; j<columns; j++)
        {
          Console.WriteLine(matriz[i,j]);
        }
        Console.WriteLine();
      }
      return matriz;
      }
      public static int readTableCell(int[,]matriz,int row,int column)
      {
        int leer =  matriz[row,column];
        Console.WriteLine(leer);
        return leer;
      }

      public static int writeTableCell (int[,]matriz,int row,int column,int num)
      {
        matriz[row,column]=num;
        return matriz[row,column];
      }

    }
  }
