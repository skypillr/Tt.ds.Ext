using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tt.Ds
{
    public class CInsertionSort : ISortArray
    {
        public void Sort(CArray array)
        {
            for (int i = 1; i <= array.Upper; i++)
            {
                int tmp = array[i];//要插入的数据
                int j = i;//从i处开始

                while (j > 0 && array[j - 1] > tmp)//比插入数据大的往右移动
                {
                    array[j] = array[j - 1];//往右移动，腾出空间插入temp
                    j--;
                }

                array[j] = tmp;

            }
        }
    }
}
