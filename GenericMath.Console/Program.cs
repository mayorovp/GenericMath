using System;
using System.Diagnostics;

namespace GenericMath.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTest("  Generic", new MatrixOps<int>());
            RunTest(" Concrete", new MatrixOpsInt());
            RunTest("Generated", MathRewriter.GetInstance<MatrixOps<int>>());
        }

        static int[,]
            a = new int[1000, 1000],
            b = new int[1000, 1000],
            c = new int[1000, 1000];


        private static int MAX_COUNT;
        private static void RunTest(string name, MatrixOps<int> ops)
        {
            Stopwatch sw;

            if (MAX_COUNT == 0)
            {
                for (sw = Stopwatch.StartNew(); sw.Elapsed.TotalSeconds < 1; MAX_COUNT++)
                    ops.Add(a, b, c);

                System.Console.WriteLine($"MAX_COUNT = {MAX_COUNT}");
            }
            else
            {
                for (int i = 0; i < 5; i++)
                    ops.Add(a, b, c);
            }

            System.Console.Write($"{name}... ");
            sw = Stopwatch.StartNew();
            for (int i = 0; i < MAX_COUNT; i++)
                ops.Add(a, b, c);
            sw.Stop();

            System.Console.WriteLine(sw.Elapsed);
            GC.Collect();
        }
    }
}
