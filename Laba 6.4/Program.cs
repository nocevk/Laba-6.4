using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6._4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть послідовність чисел (0 для завершення):");
            ReverseSequence();
        }

        static void ReverseSequence()
        {
            int number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                ReverseSequence(); 
                Console.WriteLine(number); 
            }
        }
    }
}




