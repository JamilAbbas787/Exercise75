using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize75
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                double number;
                double.TryParse(input , out number);

                if (number > 0)
                {
                    double root = number / 3;
                    int i;
                    for (i = 0; i < 32; i++)
                        root = (root + number / root) / 2;
                    Console.WriteLine($"Square root:{root}");
                    break;
                    
                }
                else
                {
                    continue;
                }

            } while (true);

            Console.ReadKey();
        }
    }
}
