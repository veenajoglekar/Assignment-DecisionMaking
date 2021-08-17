using System;
using System.Collections.Generic;
using System.Text;

namespace DecisionMakingStatement
{
    public class Comparison
    {
        public void compare()
        {
            int m;
            Console.Write("Enter a number: ");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("The value of n ={0}", m > 0 ? 1 : m == 0 ? 0 : -1  );
            
        }
    }
}
