using System;
using System.Collections.Generic;
using System.Text;

namespace DecisionMakingStatement
{
    class ThreeNumCompare
    {
        public void compare()
        {
            int num1, num2, num3;
            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the first number: ");
            num3 = int.Parse(Console.ReadLine());
            int highest = (num1 > num2) && num1 > num3 ? num1 : num2 > num1 && num2 > num3 ? num2 : num3;
            Console.WriteLine("{0} is the greatest among the three",highest);
        }
    }
}
