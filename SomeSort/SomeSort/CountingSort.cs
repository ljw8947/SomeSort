using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeSort
{
    public class CountingSort:BaseSort
    {
        protected override Data[] Sort(Data[] sourceData)
        {

            int maxValue = sourceData.Max(x => x.Value);

            Data[] resultData = new Data[sourceData.Length];
            
            //关键字计数
            int[] equal = new int[maxValue+1];
            for (int i = 0; i < sourceData.Length; i++)
            {
                equal[sourceData[i].Value]++;
            }

            Console.WriteLine("\nEqual:{0}\n",string.Join(",",equal));

            //小于关键字数量计数
            int[] less = new int[maxValue+1];
            for(int i=0;i<equal.Length;i++)
            {
                for(int j=i-1;j>=0;j--)
                {
                    less[i] += equal[j];
                }
            }
            Console.WriteLine("\nLess:{0}\n", string.Join(",", equal));

            for(int i=0;i<sourceData.Length;i++)
            {
                resultData[less[sourceData[i].Value]] = sourceData[i];
                less[sourceData[i].Value]++;
                Print(resultData);
            }
            return resultData;
            
            

        }

        

    }
}
