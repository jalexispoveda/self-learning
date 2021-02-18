using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DALMentoring.Database
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class BenchMarkExecutorDatabase
    {
        private const string itemToFind = "00DEF5E6-F085-4081-B4AE-2D81EF5405DB";
        private static readonly CountriesManager countriesManager = new CountriesManager();

        [Benchmark]
        public void GetUserEnumerableEquals()
        {
            countriesManager.GetCountryEnumerableEquals(itemToFind);
        }

        [Benchmark]
        public void GetUserEnumerableNotEquals()
        {
            countriesManager.GetCountryEnumerableNotEquals(itemToFind);
        }

        [Benchmark]
        public void GetUserQueryableEquals()
        {
            countriesManager.GetCountryQueryableEquals(itemToFind);
        }

        [Benchmark]
        public void GetUserQueryableNotEquals()
        {
            countriesManager.GetCountryQueryableNotEquals(itemToFind);
        }
    }
}
