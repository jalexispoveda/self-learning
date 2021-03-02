using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DALMentoring.Collections
{
    public class ListArrayTest
    {
        private ArrayList arrayList = new ArrayList(3);

        public ListArrayTest()
        {
            for (int i = 0; i < 10000000; i++)
            {
                arrayList.Add($"Nombre{i}");
            }
        }

        [Benchmark]
        public string getArrayListItem(string itemToFind) { 
            foreach(var item in arrayList)
            {
                if(item.ToString() == itemToFind)
                {
                    return item.ToString();
                }
            }
            return "Not found";
        }

        [Benchmark]
        public string getArrayListItemEquals(string itemToFind)
        {
            foreach (var item in arrayList)
            {
                if (item.ToString().Equals(itemToFind))
                {
                    return item.ToString();
                }
            }
            return "Not found";
        }

        [Benchmark]
        public string getArrayListItemIndexOf(string itemToFind)
        {
            int index = arrayList.IndexOf(itemToFind);
            if(index < 0)
            {
                return "Not Found";
            }
            return arrayList[index].ToString();
        }
    }
}
