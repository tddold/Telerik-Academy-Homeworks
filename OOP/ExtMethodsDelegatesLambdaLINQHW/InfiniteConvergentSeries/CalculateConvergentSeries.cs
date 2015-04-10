namespace InfiniteConvergentSeries
{
    using System;

    // Problem 20.* Infinite convergent series

    // By using delegates develop an universal static method to calculate the sum of infinite convergent series 
    // with given precision depending on a function of its term. By using proper functions for the term calculate with a 2-digit precision the sum of the infinite series:

    // 1 + 1/2 + 1/4 + 1/8 + 1/16 + …
    // 1 + 1/2! + 1/3! + 1/4! + 1/5! + …
    // 1 + 1/2 - 1/4 + 1/8 - 1/16 + …
    public class CalculateConvergentSeries
    {
        public static decimal NextMember(decimal start, decimal step)
        {
            return start * step;
        }

        public static decimal SumOfConvergentSeries(decimal start, decimal numberOfSteps, bool changeSing, decimal stepIncrease, Func<decimal, decimal, decimal> nextMember)
        {
            decimal oldSum = 0;
            decimal nextMemberOfSeries = NextMember(start, numberOfSteps);

            decimal currentSum = start + (1 / nextMemberOfSeries);

            if (changeSing)
            {
                nextMemberOfSeries = -nextMemberOfSeries;
            }

            numberOfSteps += stepIncrease;
            decimal difference = currentSum - oldSum;

            while (Math.Abs(difference) > 0.01M)
            {
                oldSum = currentSum;
                nextMemberOfSeries = NextMember(nextMemberOfSeries, numberOfSteps);
                currentSum = start + (1 / nextMemberOfSeries);

                if (changeSing)
                {
                    nextMemberOfSeries = -nextMemberOfSeries;
                }

                numberOfSteps += stepIncrease;
                difference = currentSum - oldSum;
            }

            return currentSum;
        }
    }
}
