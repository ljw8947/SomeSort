using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeSort
{
    /// <summary>
    /// Bubble Sort
    /// </summary>
    public class BubbleSort : BaseSort
    { 

        protected override Data[] Sort(Data[] sourceData)
        {
            for(int i = 0; i < sourceData.Length - 1; i++)
            {
                for(int j = 0; j < sourceData.Length - 1 - i; j++)
                {
                    if(sourceData[j].Value>sourceData[j+1].Value)
                    {
                        DataSwitch(sourceData[j], sourceData[j + 1]);
                    }
                }
                Console.WriteLine(string.Format("\nround [{0}] sort result:", i));
                Print(sourceData);
            }
            return sourceData;
        }
    }
}
