using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int i, num = 20, sum = 0;

                i = 1;
                while (i <= num)
                {
                    sum = sum + i;
                    i++;
                }

                Console.WriteLine("Sum of first" + num +
                " natural numbers = " + sum);
            }
        }
    }
    
}
