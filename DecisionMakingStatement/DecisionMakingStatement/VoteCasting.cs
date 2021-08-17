using System;
using System.Collections.Generic;
using System.Text;

namespace DecisionMakingStatement
{
    public class VoteCasting
    {
        public void Vote()
        {
            int age;
            Console.Write("Enter a age: ");
            age = int.Parse(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote");
            }
            else
            {
                Console.WriteLine("You are not eligible for casting your vote");

            }



        }
    }
}
