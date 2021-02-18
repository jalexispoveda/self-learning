using FizzWare.NBuilder;
using FizzWare.NBuilder.Implementation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DALMentoring.Mentoring.Helpers
{
    public class ListManager
    {
        public List<Usuario> userList = new List<Usuario>();

        public List<Usuario> userLista = new List<Usuario>();
        public Dictionary<int, string> usersDictionary = new Dictionary<int, string>();
        public Hashtable usersHashTable = new Hashtable();

        public ListManager()
        {
            userList = Builder<Usuario>
                .CreateListOfSize(10000000).All().Build() as List<Usuario>;
        }

        public List<Usuario> cargarLista()
        {
            foreach (var item in userList)
            {
                userLista.Add(item);
            }
            return userLista;
        }

        public Dictionary<int, string> cargarDiccionario()
        {
            foreach(var item in userList)
            {
                usersDictionary.Add(item.IdUsuario, item.Name);
            }
            return usersDictionary;
        }

        public Hashtable cargarHashTable()
        {
            foreach (var item in userList)
            {
                usersHashTable.Add(item.IdUsuario, item.Name);
            }
            return usersHashTable;
        }

        public bool findItemDictionary()
        {
            if (usersDictionary.TryGetValue(9999999, out string myValue))
            {
                Console.WriteLine(myValue);
                return true;
            }
            return false;
        }


        public bool findItemHashTable()
        {
            var itemKey = usersHashTable.Keys.OfType<Int32>().Where(k => k == 9999999);
            Console.WriteLine(itemKey);
            if(itemKey != null)
            {
                return true;                
            }
            return false;

        }


        public bool findItemList()
        {
            var item = userList.Find(x => x.IdUsuario == 9999999);
            Console.WriteLine(item.Name);
            if (item != null)
            {
                return true;
            }
            return false;

        }
    }
}
