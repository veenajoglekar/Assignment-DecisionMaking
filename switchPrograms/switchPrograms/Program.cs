using System;

namespace switchPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Grade gr = new Grade();
            gr.computeGrade();
            DigitWord dw = new DigitWord();
            dw.convertDigit();
        }

    }

    public class Grade{
        public void computeGrade()
        {
            string grade;
            Console.Write("Enter the Grade: ");
            grade = Console.ReadLine();
            switch (grade)
            {
                case "E" : Console.WriteLine("You have choosen : Excellent"); break;
                case "V" : Console.WriteLine("You have choosen : Very Good"); break;
                case "G" : Console.WriteLine("You have choosen : Good"); break;
                case "A" : Console.WriteLine("You have choosen : Average"); break;
                case "F" : Console.WriteLine("You have choosen : Fail"); break;
            }
        }
    }

    public class DigitWord { 
        public void convertDigit()
        {
            int digit;
            Console.Write("Enter the Digit: ");
            digit = int.Parse(Console.ReadLine());
            switch (digit) {
                case 0: Console.WriteLine("Zero");break;
                case 1: Console.WriteLine("One");break;
                case 2: Console.WriteLine("Two");break;
                case 3: Console.WriteLine("Three");break;
                case 4: Console.WriteLine("Four");break;
                case 5: Console.WriteLine("Five");break;
                case 6: Console.WriteLine("Six");break;
                case 7: Console.WriteLine("Seven");break;
                case 8: Console.WriteLine("Eight");break;
                case 9: Console.WriteLine("Nine");break;
            }


        }
    }


}
