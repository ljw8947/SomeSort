using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeSort
{
    public class InsertionSort:BaseSort
    {
        protected override Data[] Sort(Data[] sourceData)
        {
            for(var i=1;i<sourceData.Length;i++)
            {
                //向前插入
                for(var j=i;j>0;j--)
                {
                    if(sourceData[j].Value<sourceData[j-1].Value)
                    {
                        DataSwitch(sourceData[j-1], sourceData[j]);
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine("Round [{0}] sort result:", i);
                Print(sourceData);
            }
            return sourceData;
            
        }
    }
}
