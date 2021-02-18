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
            //BenchmarkRunner.Run<BenchMarkExecutor>();
            //BenchmarkRunner.Run<BenchMarkExecutorDatabase>();
            BenchmarkRunner.Run<BenchmarkExecutorFinal>();

            //ListArrayTest listArrayTest = new ListArrayTest();
            //Console.WriteLine(listArrayTest.getArrayListItemEquals("Nombre96784985"));
            //Console.WriteLine(listArrayTest.getArrayListItem("Nombre96784985"));
            //Console.WriteLine(listArrayTest.getArrayListItemIndexOf("Nombre96784985"));

            //string itemToFind = "Nombre9678498";

            //ArrayTest arrayTest = new ArrayTest();

            //Console.WriteLine(arrayTest.getItemForeach(itemToFind));
            //Console.WriteLine(arrayTest.getItemFor(itemToFind));

            //ListExample listTest = new ListExample();

            //Console.WriteLine(listTest.findItemForEach(itemToFind));
            //Console.WriteLine(listTest.findItem(itemToFind));
            //Console.WriteLine(listTest.FindItemQueryable(itemToFind));

            //CountriesManager countriesManager = new CountriesManager();
            //var text = countriesManager.GetCountryEnumerableNotEquals("00DEF5E6-F085-4081-B4AE-2D81EF5405DB");
            //var test2 = countriesManager.GetCountryQueryableEquals("00DEF5E6-F085-4081-B4AE-2D81EF5405DB");


            ListManager lista = new ListManager();
            //lista.cargarDiccionario();
            //lista.cargarHashTable();

            //lista.findItemDictionary();
            //lista.findItemHashTable();
            //lista.findItemList();

            Console.ReadLine();


        }
    }
}
