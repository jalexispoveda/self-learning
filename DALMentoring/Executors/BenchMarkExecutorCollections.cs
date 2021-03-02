using BenchmarkDotNet.Attributes;

namespace DALMentoring.Collections
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class BenchMarkExecutorCollections
    {
        private const string itemToFind = "Nombre9678498";
        private static readonly ArrayTest arrayTest = new ArrayTest();
        private static readonly ListArrayTest listArrayTest = new ListArrayTest();
        private static readonly ListExample listTest = new ListExample();

        [Benchmark]
        public void FindItemForeachArray()
        {
            arrayTest.getItemForeach(itemToFind);
        }

        [Benchmark]
        public void FindItemForArray()
        {
            arrayTest.getItemFor(itemToFind);
        }

        [Benchmark]
        public void FindItemForeachList()
        {
            listTest.findItemForEach(itemToFind);
        }

        [Benchmark]
        public void FindItemLinqList()
        {
            listTest.findItem(itemToFind);
        }


        [Benchmark]
        public void FindItemArrayList()
        {
            listArrayTest.getArrayListItem(itemToFind);
        }

        [Benchmark]
        public void FindItemArrayListUsingEquals()
        {
            listArrayTest.getArrayListItemEquals(itemToFind);
        }

        [Benchmark]
        public void FindItemArrayListUsingIndexOf()
        {
            listArrayTest.getArrayListItemIndexOf(itemToFind);
        }
    }
}
