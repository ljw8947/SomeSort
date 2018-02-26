using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeSort
{
    public class SelectionSort:BaseSort
    {
        protected override Data[] Sort(Data[] sourceData)
        {
            Data smallest = new Data();
            for(int i=0;i<sourceData.Length-1;i++)
            {
                //从后选择
                smallest = sourceData[i];
                for(int j=i+1;j<sourceData.Length;j++)
                {
                    if(smallest.Value>sourceData[j].Value)
                    {
                        DataSwitch(smallest, sourceData[j]);
                    }
                }
                if(smallest!=sourceData[i])
                {
                    DataSwitch(smallest, sourceData[i]);
                }

                Console.WriteLine("\nRound [{0}] sort result:", i);
                Print(sourceData);
            }
            return sourceData;
        }
    }
}
