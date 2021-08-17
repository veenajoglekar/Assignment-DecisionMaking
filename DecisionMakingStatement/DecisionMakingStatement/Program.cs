using System;

namespace DecisionMakingStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Equal eq = new Equal();
            eq.EqualNum();

            EvenOrOdd evenodd = new EvenOrOdd();
            evenodd.EvenOdd();

            positiveornegative posnev = new positiveornegative();
            posnev.PositiveNegative();

            LeapYear leap = new LeapYear();
            leap.Leap();

            VoteCasting vote = new VoteCasting();
            vote.Vote();

            Comparison cmp = new Comparison();
            cmp.compare();

            Height height = new Height();
            height.HeightCompare();

            ThreeNumCompare cmpThree = new ThreeNumCompare();
            cmpThree.compare();
        }
    }
}
