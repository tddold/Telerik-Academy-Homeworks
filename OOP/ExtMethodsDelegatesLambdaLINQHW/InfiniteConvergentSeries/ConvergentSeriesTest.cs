namespace InfiniteConvergentSeries
{
    using System;

    public class ConvergentSeriesTest
    {
        public static void Main()
        {
            decimal firstSum = CalculateConvergentSeries
                .SumOfConvergentSeries(1, 2, false, 0, (x, y) => CalculateConvergentSeries.NextMember(x, y));

            Console.WriteLine(firstSum);

            decimal secondSum = CalculateConvergentSeries
                .SumOfConvergentSeries(1, 2, false, 1, (x, y) => CalculateConvergentSeries.NextMember(x, y));

            Console.WriteLine(secondSum);

            decimal thirdSum = CalculateConvergentSeries
                .SumOfConvergentSeries(1, 2, true, 0, (x, y) => CalculateConvergentSeries.NextMember(x, y));

            Console.WriteLine(thirdSum);
        }
    }
}
