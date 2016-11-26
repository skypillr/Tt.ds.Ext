using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tt.Ds
{
    public class CSelectionSort : ISortArray
    {
        public void Sort(CArray array)
        {
            for (int i = 0; i <= array.Upper; i++)
            {
                //在i处设置最小值
                int minIndex = i;
                //遍历寻找最小值
                for (int j = i+1; j <= array.Upper; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                CArray.Swap(array,i,minIndex);
            }
        }
    }
}
