using System;

namespace PatternProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            NumPattern np = new NumPattern();
            np.printPattern();
            NumDiamondPattern ndp = new NumDiamondPattern();
            ndp.printPattern();
            StarPattern sp = new StarPattern();
            sp.printPattern();

//dummy
        }
    }

    public class NumPattern { 
        public void printPattern()
        {
            String str = "";
            int count = 1;
            for(int i = 1; i <= 4; i++)
            {
                for(int j=1; j <= i; j++)
                {
                    str = str + count + " ";
                    count++;
                }
                Console.WriteLine(str);
                str = "";
            }
        }
    }

    public class StarPattern
    {
        public void printPattern()
        {
            String str = "";
            for (int i = 1; i <= 4; i++)
            {
                for(int k=1; k <= 4 - i; k++)
                {
                    str += " ";
                }
                for (int j = 1; j <= i; j++)
                {
                    str += "* ";
                }
               
                Console.WriteLine(str);
                str = "";
            }
        }
    }

    public class NumDiamondPattern
    {
        public void printPattern()
        {
            String str = "";
            int count = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 1; k <= 4- i; k++)
                {
                    str += " ";
                }
                for (int j = 1; j <= i; j++)
                {
                    str += count + " ";
                    count++;
                }
               
                Console.WriteLine(str);
                str = "";
            }
        }
    }

}
