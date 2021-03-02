using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DALMentoring.Collections
{
    public class ListExample
    {
        public List<string> myList = new List<string>();

        public ListExample()
        {
            for (int i = 0; i < 10000000; i++)
            {
                myList.Add($"Nombre{i}");
            }

        }

        public string findItem(string itemToFind)
        {
            return myList.Find(x => x.Equals(itemToFind));
        }

        public string findItemForEach(string itemToFind)
        {
            foreach(var item in myList)
            {
                if (item.Equals(itemToFind))
                {
                    return item;
                }
            }
            return "Not found";
        }

        //public string FindItemQueryable(string itemToFind)
        //{
        //    IQueryable<string> data = myList.Where(x => x.Equals(itemToFind));
        //    return data.FirstOrDefault();
        //}
    }
}
