using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tt.Ds
{
    public class CQuickSort : ISortArray
    {



        public void Sort(CArray array)
        {
            QuickSort(array, 0, array.NumElements - 1);

        }

        void QuickSort(CArray array, int low, int high)
        {
            if (low < high)
            {
                int mid = Partition(array, low, high);
                QuickSort(array, low, mid - 1);
                QuickSort(array, mid + 1, high);
            }

        }
        /// <summary>
        /// 分隔2边左小右大,返回分隔index
        /// </summary>
        /// <param name="array"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        int Partition(CArray array, int low, int high)
        {
            //选取high作为中间值
            //i保存与high交换的index，即中间值的index
            //i 保存的值始终比highda
            int i = low;
            int pivot = array[high];

            for (int j = i; j <= high - 1; j++)
            {
                if (array[j] < pivot)
                {
                    //i的左边保存的都是小于pivot的
                    //右边以及自身保存的都大于等于pivot的
                    CArray.Swap(array, i, j);
                    i++;
                }
            }
            //互换时pivot处于中间
            CArray.Swap(array, i, high);

            return i;

        }


    }
}
