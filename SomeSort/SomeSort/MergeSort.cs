using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeSort
{
    public class MergeSort : BaseSort
    {
        protected override Data[] Sort(Data[] sourceData)
        {
            Sort(sourceData, 0, sourceData.Length - 1);
            return sourceData;
        }

        private void Sort(Data[] sourceData, int start, int end)
        {
            if (start < end)
            {
                int mid = (end +start) / 2;
                Sort(sourceData, start, mid);
                Sort(sourceData, mid+1, end);
                Merge(sourceData, start, mid, end);
            }
        }

        private Data[] Merge(Data[] sourceData,int start,int mid,int end)
        {
            Data[] temp = new Data[end - start + 1];
            int i = start, j = mid+1,k=0;
            while (i <= mid && j <= end)
            {
                if(sourceData[i].Value<sourceData[j].Value)
                {
                    temp[k++] = sourceData[i++];
                }
                else
                {
                    temp[k++]=sourceData[j++];
                }
            }
            //前面的分组肯定比后面的分组小
            while(i <= mid)
            {
                temp[k++]=sourceData[i++];
            }

            while(j <= end)
            {
                temp[k++]=sourceData[j++];
            }
            for(i=start,k=0;k<temp.Length;k++,i++)
            {
                sourceData[i]=temp[k];
            }
            
            Print(sourceData);

            return sourceData;
        }
    }
}
