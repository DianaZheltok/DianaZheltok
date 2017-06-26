using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while ( i <= 100)
            {
                String num = i.ToString();
                if (i % 3 == 0)
                {
                    Console.Write("3*" + i / 3);
                }
                else
                {
                    Console.Write(" " + num + " ");               
                }
                i++;
            }
            Console.Write("\nPress any key...");
            Console.ReadKey();
        }
    }

}