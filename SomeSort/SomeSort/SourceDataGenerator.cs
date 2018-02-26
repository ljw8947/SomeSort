using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeSort
{
    public class SourceDataGenerator
    {
        private static int arrayLength = 10;

        static Random randomer = new Random(DateTime.Now.Millisecond);
        public static  Data[] GetSourceDataArray()
        {
            Data[] dataArr = new Data[arrayLength];
            for(var i=0;i<dataArr.Length;i++)
            {
                Data data = new Data();
                int key = 0;
                do
                {
                    key = randomer.Next(1, 20);
                } while (dataArr.FirstOrDefault(x =>x!=null&& x.Key == key) != null);
                data.Key = key;
                data.Value = data.Key;
                dataArr[i] = data;
            }
            return dataArr;
        }
    }
}
