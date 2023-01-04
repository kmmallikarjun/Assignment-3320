using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp2
{
    class Assign2
    {
        static void Main(string[] args)
        {
            int[] oe = { 1, 2, 3, 4, 5, 7, 5, 44, 55, 25, 12 };
            for(int i = 0; i < oe.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i+"  is the even no");
                }
                else
                {
                    Console.WriteLine(i+" is the odd no are ");
                }
            }
        }
    }
}
