using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tt.Ds
{
    public class CHeapSort : ISortArray
    {
        CArray tmpArray;

        public CHeapSort(int size)
        {
            tmpArray = new CArray(size);
        }
        public void Sort(CArray array)
        {
            if (array == null)
            {
                throw new Exception("请初始化Array");
            }
            for (int i = 0; i <=array.Upper; i++)
            {
                tmpArray.Insert(((CHeapArray)array).RemoveRoot());
            }
            for (int i = tmpArray.NumElements-1,j=0; i >=0 ; i--,j++)
            {
                array[j] = tmpArray[i];
            }
            

        }

       
    }
}
