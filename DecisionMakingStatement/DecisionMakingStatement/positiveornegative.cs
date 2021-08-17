using System;
using System.Collections.Generic;
using System.Text;

namespace DecisionMakingStatement
{
    public class positiveornegative
    {
        public void PositiveNegative()
        {
            int num;
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            if(num > 0)
            {
                Console.WriteLine("{0} is a positive number",num);
            }
            else
            {
                Console.WriteLine("{0} is a negative number",num);

            }

        }
    }
}
