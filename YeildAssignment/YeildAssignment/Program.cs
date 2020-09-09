using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeildAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var i in GetData())
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadLine();
        }
        static IEnumerable<string> GetData()
        {
            yield return "A";
            yield return "B";
            yield return "C";
            //yield break;
            yield return "D";
            yield return "E";
        }
    }
}
    

