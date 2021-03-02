using BenchmarkDotNet.Running;
using DALMentoring.Collections;
using DALMentoring.Database;
using DALMentoring.Mentoring;
using DALMentoring.Mentoring.Helpers;
using System;

namespace Mentoring
{
    class Program
    {
        static void Main(string[] args)
        {
            //BenchmarkRunner.Run<BenchMarkExecutorCollections>();
            //BenchmarkRunner.Run<BenchMarkExecutorDatabase>();
            BenchmarkRunner.Run<BenchmarkExecutorGenerics>();
            Console.ReadLine();
        }
    }
}
