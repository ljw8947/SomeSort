using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeSort
{
    public class QuickSort:BaseSort
    {
        protected override Data[] Sort(Data[] sourceData)
        {
            return QuickSortImplement(sourceData, 0, sourceData.Length-1);
        }

        private Data[] QuickSortImplement(Data[] sourceData,int start,int end)
        {
            if(start<end)
            {
                Print(sourceData);
                int mid = Partition(sourceData, start, end);
                QuickSortImplement(sourceData, start, mid - 1);
                QuickSortImplement(sourceData, mid + 1, end);
                
            }
            return sourceData;
        }

        private int Partition(Data[] sourceData,int start,int end)
        {
            int leftEnd=start-1;
            for (int i = start; i < end; i++)
            {
                if (sourceData[i].Value < sourceData[end].Value)
                {
                    DataSwitch(sourceData[++leftEnd], sourceData[i]);
                }
            }
            DataSwitch(sourceData[++leftEnd],sourceData[end]);
            return leftEnd;
        }
    }
}
