using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascals_Traiangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRows=int.Parse(Console.ReadLine());
            int[][] result= generatePascalsTriangle(numRows);
            for (int i= 0;i<numRows;i++) {
                for (int b=1;b<numRows-i;b++) {
                    Console.Write(" ");
                }
                for (int j= 0;j < result[i].Length;j++) {
                    Console.Write(result[i][j]+" ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }

        public static int[][] generatePascalsTriangle(int numRows) {
            int value = 1;
            int[][] arr = new int[numRows][];
            for (int i=0;i< numRows; i++) {
                //Console.WriteLine("-----");
                arr[i] = new int[i+1];
                    for (int j=0;j<=i;j++) {
                        if (i == 0 || j == 0)
                        {
                            value = 1;
                        }
                        else
                            value = value * (i - j + 1) / j;
                        //Console.Write(value+" ");
                    arr[i][j] = value;
                    }
                    //Console.WriteLine();
                
            }
            return arr;
        }
    }
}
