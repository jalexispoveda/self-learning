using BenchmarkDotNet.Attributes;
using DALMentoring.Mentoring.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DALMentoring.Mentoring
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class BenchmarkExecutorFinal
    {
        private static readonly ListManager list = new ListManager();

        [Benchmark]
        public void cargarLista()
        {
            list.cargarLista();
        }

        [Benchmark]
        public void cargarDiccionario()
        {
            list.cargarDiccionario();
        }

        [Benchmark]
        public void cargarHashTable()
        {
            list.cargarHashTable();
        }


        [Benchmark]
        public void findItemDiccionario()
        {
            list.findItemDictionary();
        }

        [Benchmark]
        public void findItemHash()
        {
            list.findItemHashTable();
        }

        [Benchmark]
        public void findItemList()
        {
            list.findItemList();
        }
    }
}
