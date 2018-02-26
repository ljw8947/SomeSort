using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourceData = SourceDataGenerator.GetSourceDataArray();
            BaseSort bubbleSort = new CountingSort();
            bubbleSort.SortData(sourceData);

            Console.ReadKey();
        }
    }
}
