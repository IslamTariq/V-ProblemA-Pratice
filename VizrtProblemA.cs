using System;
using System.Collections.Generic;


namespace VizrtProblemA
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var line = Console.ReadLine();
            (int N, int M) = ParseValues(line);
            int max = Math.Max(N, M);
            int min = Math.Min(N, M);
            int firstValue = ((int)Math.Round(min / 2.0) * 2) + 1;
            int numberOfValues = max - min + 1;

            for(int i = 0; i < numberOfValues; i++)
            {
                Console.WriteLine(firstValue + i);
                
            }
            
            return 0;
        }

        public static (int N, int M) ParseValues(string values)
        {
            string[] splittedValue = values.Split(' ');
            int n = int.Parse(splittedValue[0]);
            int m = int.Parse(splittedValue[1]);
            return (n, m);
        }

    }
}