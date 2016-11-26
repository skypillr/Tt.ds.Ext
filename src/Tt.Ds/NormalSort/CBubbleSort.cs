using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tt.Ds
{
    public class CBubbleSort : ISortArray
    {
        /// <summary>
        /// 冒泡排序具体实现
        /// </summary>
        /// <param name="array"></param>
        public void Sort(CArray array)
        {
            //外层将最大值置后
            for (int i = array.Upper; i >=1 ; i--)
            {
                for (int j = 0; j <= array.Upper-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        CArray.Swap(array,j,j+1);
                        
                    }
                }
            }
        }
    }
}
