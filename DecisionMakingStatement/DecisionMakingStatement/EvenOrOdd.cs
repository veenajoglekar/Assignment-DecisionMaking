using System;
using System.Collections.Generic;
using System.Text;

namespace DecisionMakingStatement
{
    public class EvenOrOdd
    {
        public void EvenOdd()
        {
            int num;
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("{0} is an even number", num);
            }
            else
            {
                Console.WriteLine("{0} is an odd number", num);

            }
        }

    }
}
