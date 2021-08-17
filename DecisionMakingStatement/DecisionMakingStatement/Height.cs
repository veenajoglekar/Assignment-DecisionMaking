using System;
using System.Collections.Generic;
using System.Text;

namespace DecisionMakingStatement
{
    public class Height
    {
        public void HeightCompare()
        {
            int height;
            Console.Write("Enter your height in cm: ");
            height = int.Parse(Console.ReadLine());

            if (height > 160)
            {
                Console.WriteLine("The person is tall");
            }
            else
            {
                Console.WriteLine("The person is dwarf");

            }
        }
    }
}
