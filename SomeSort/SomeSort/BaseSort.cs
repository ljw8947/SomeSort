using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeSort
{
    public abstract class BaseSort
    {
        protected abstract Data[] Sort(Data[] sourceData);
        private Data temp = new Data();
        public void SortData(Data[] sourceData)
        {
            Console.WriteLine("source data:");
            Print(sourceData);
            var sortedData = Sort(sourceData);
            Console.WriteLine("\n\nsorted data:");
            Print(sortedData);
        }

        public void Print(Data[] dataArray)
        {
            Console.WriteLine();
            foreach(var item in dataArray)
            {
                Console.WriteLine(String.Format("Key:{0},Value:{1}", 
                    item == null ? -1 : item.Key, item == null ?-1 : item.Value));
            }
        }

        public void DataSwitch(Data a,Data b)
        {
            temp.Key = a.Key;
            temp.Value = a.Value;

            a.Key = b.Key;
            a.Value = b.Value;

            b.Key = temp.Key;
            b.Value = temp.Value;
        }

        public Data GetSmaller(Data a,Data b)
        {
            return a.Value<b.Value?a:b;
        }

    }
}
