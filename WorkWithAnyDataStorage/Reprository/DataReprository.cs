using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithAnyDataStorage.Data;

namespace WorkWithAnyDataStorage.Reprository
{
    public class DataReprository<T> where T : Entity
    {
        // load the data into the list
        private readonly List<T> items = new();

        public T GetByID(int id)
        {
            return items.Single(item=>item.ID == id);
        }

        public void Load(T item) 
        {
            item.ID = items.Count + 1;
            items.Add(item);
        }

        // save the data into the list, meaning write to console
        public void Save() 
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        // remove data from the list
        public void Remove(T item)
        {
            items.Remove(item);
        }

    }
}
