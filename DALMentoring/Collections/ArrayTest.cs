using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DALMentoring.Collections
{
    public class ArrayTest
    {
        private string[] array;
        public ArrayTest()
        {
            array = new string[10000000];
            for(int i = 0; i < 10000000; i++)
            {
                array[i] = $"Nombre{i}";
            }
            //array[0] = "Alex";    
            //array[1] = "Carlos";
            //array[2] = "Pedro";
            //array[3] = "Raul";
            //array[4] = "Pepe";
            //array[5] = "Jose";            
        }

        [Benchmark]
        public string getItemForeach(string itemName)
        {
            foreach (var item in array)
            {
                if(item == itemName)
                {
                    return item;
                }
            }
            return "Not found";
        }

        [Benchmark]
        public string getItemFor(string itemName)
        {
            for(int i = 0; i < array.Length; i++)
                if (array[i] == itemName)
                {
                    return array[i];
                }
            return "Not found";

        }
    
    }
}
