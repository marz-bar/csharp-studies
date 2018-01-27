using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Workbook
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            for (int i = 0; i < 6; i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            int max = Int32.MinValue;
            int temp;
            
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    temp = arr[i][k] + arr[i][k + 1] + arr[i][k + 2]
                        + arr[i + 1][k + 1]
                        + arr[i + 2][k] + arr[i + 2][k + 1] + arr[i + 2][k + 2];
                    max = Math.Max(max, temp);
                }

            }
            Console.WriteLine(max);
            
        }
    }

}
