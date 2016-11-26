using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tt.Ds
{
    public class CInsertionSortShell : ISortArray
    {
        public void Sort(CArray array)
        {
            //gap定义
            int[] gaps = new int[]{701, 301, 132, 57, 23, 10, 4, 1};

            for (int gi = 0; gi < gaps.Length; gi++)
            {
                //针对当前gap的所有元素进行插入排序
                for (int i = gaps[gi]; i <= array.Upper; )
                {
                    int tmp = array[i];//要插入的数据
                    int j = i;//从i处开始

                    while (j - gaps[gi] >= 0 && array[j - gaps[gi]] > tmp)//比插入数据大的往右移动
                    {
                        array[j] = array[j - gaps[gi]];//往右移动，腾出空间插入temp
                        j= j-gaps[gi];
                    }
                    array[j] = tmp;

                    i += gaps[gi];
                }
            }
            
        }
    }
}
