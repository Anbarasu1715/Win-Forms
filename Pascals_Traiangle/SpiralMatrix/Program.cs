using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n:");
            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];
            Console.WriteLine("Enter matrix:");
            for (int i=0;i<n;i++) {
                arr[i] = new int[n];
                for (int j=0;j<n;j++) {
                    arr[i][j] = int.Parse(Console.ReadLine());
                }
            }
            spiral(arr);
            Console.ReadKey();
        }



        public static void spiral(int[][] matrix)
        {
            int[] num = new int[matrix.Length*matrix.Length];
            int index = 0;
            int rowStart = 0, colStart = 0, rowEnd = matrix[0].Length - 1, colEnd = matrix.Length - 1;
            while (rowStart <= rowEnd && colStart <= colEnd)
            { 
                    for (int i = rowStart; i <= rowEnd; i++)
                    {
                        num[index++]=matrix[colStart][i];
                    }
                    colStart++;

                    if (colStart > colEnd)
                        break;
                    for (int j = colStart; j <= colEnd; j++)
                    {
                        num[index++]=matrix[j][rowEnd];
                    }
                    rowEnd--;

                    if (rowStart > rowEnd)
                        break;
                    for (int k = rowEnd; k >= rowStart; k--)
                    {
                        num[index++]=(matrix[colEnd][k]);
                    }
                    colEnd--;

                    if (colStart > colEnd)
                        break;
                    for (int m = colEnd; m >= colStart; m--)
                    {
                        num[index++]=(matrix[m][rowStart]);
                    }
                    rowStart++;
                    if (rowStart > rowEnd)
                        break;

                }

                for (int i = 0; i < num.Length; i++)
                {
                    Console.Write(num[i] + "  ");
                }
            }
    }
}
