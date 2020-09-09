using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeildAssignment
{
    class MultiDimenArrayDemo
    {
        static void Main()
        {
            int[,] arr = new int[3, 3];//declaration of 2D array  
            arr[0, 1] = 15;//initialization  
            arr[1, 1] = 20;
            arr[2, 0] = 18;
            //int[,] arr = { { 18, 28, 30 }, { 41, 25, 6 }, { 0, 78, 19 } };//declaration and initialization  

            //traversal  
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();//new line at each row  
            }
        }
    }
}
