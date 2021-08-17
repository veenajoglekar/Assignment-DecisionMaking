using System;
using System.Collections.Generic;
using System.Text;

namespace DecisionMakingStatement
{
    public class Equal
    {
        public void EqualNum()
        {
            int num1, num2;
            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            if(num1==num2)
            {
                Console.WriteLine("{0} and {1} are equal", num1, num2);
            }else
            {
                Console.WriteLine("{0} and {1} are not equal", num1, num2);

            }
        }
    }
}
