using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            //numbers[5] = 42;

            //Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine();
            */

            //int[] numbers = new int[] { 4, 8, 15, 16, 23 };

            string[] names = new string[] { "Harvey", "Zippy", "Babadeez", "Voman" };
            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);                
            }

            Console.ReadLine();
            */

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

        }
    }
}
