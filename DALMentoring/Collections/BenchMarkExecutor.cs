using BenchmarkDotNet.Attributes;

namespace DALMentoring.Collections
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class BenchMarkExecutor
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
        public void FindItemForList()
        {
            listTest.findItemForEach(itemToFind);
        }

        [Benchmark]
        public void FindItemLinqList()
        {
            listTest.findItem(itemToFind);
        }


        [Benchmark]
        public void getArrayListItem()
        {
            listArrayTest.getArrayListItem(itemToFind);
        }

        [Benchmark]
        public void getArrayListItemEquals()
        {
            listArrayTest.getArrayListItemEquals(itemToFind);
        }

        [Benchmark]
        public void getArrayListItemIndexOf()
        {
            listArrayTest.getArrayListItemIndexOf(itemToFind);
        }
    }
}
