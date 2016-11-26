using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tt.Ds
{
    public class CArray
    {
        #region 私有成员
        protected int[] arr;
        protected int upper = -1;
        protected int numElements;
        ISortArray iSort;
        #endregion

        #region 静态方法
        /// <summary>
        /// 初始化固定大小的数组
        /// </summary>
        /// <param name="seed"></param>
        /// <param name="size">数组大小</param>
        /// <returns></returns>
        public static CArray InitInstanceByRand(int seed, int size)
        {
            CArray array = new CArray(size);
            Random rnd = new Random(seed);
            for (int i = 0; i <= array.Upper; i++)
            {
                array.Insert((int)(rnd.NextDouble() * size));
            }
            return array;
        }

        /// <summary>
        /// 交换数值
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Swap(CArray array, int iIndex, int jIndex)
        {
            if (array.ValidIndex(iIndex) && array.ValidIndex(jIndex))
            {
                int tmp = array.arr[iIndex];
                array.arr[iIndex] = array.arr[jIndex];
                array.arr[jIndex] = tmp;
            }
        }
        #endregion

        #region 属性

        public ISortArray ISort
        {
            get
            {
                return iSort;
            }
            set
            {
                iSort = value;
            }
        }

        public int Upper
        {
            get
            {
                return upper;
            }
        }
        public int Count
        {
            get
            {
                return upper+1;
            }
        }

        public int NumElements
        {
            get
            {
                return numElements;
            }
        }

        #endregion

        #region 构造方法
        public CArray(int size)
        {
            arr = new int[size];
            upper = size - 1;
            numElements = 0;
        }
        public CArray()
        {
            arr = new int[10];
            upper = 10 - 1;
            numElements = 0;
        }
        #endregion

        #region 成员方法

        public virtual bool Insert(int item)
        {
            try
            {
                arr[numElements] = item;
                numElements++;
            }
            catch (Exception)
            {

                return false;
            }
           
            return true;
        }

        bool ValidIndex(int index)
        {
            bool flag = false;
            if (this.Upper == -1)
            {
                throw new Exception("请初始化数组");
            }
            else
            {
                if (index <= -1 || index > this.Upper)
                {
                    throw new Exception("索引超出范围");
                }
                else
                {
                    flag = true;
                }
            }
            return flag;
        }
        public int this[int i]
        {
            get
            {
                int val = 0;
                if (ValidIndex(i))
                {
                    val = arr[i];
                }
                return val;
            }
            set
            {
                if (ValidIndex(i))
                {
                    arr[i] = value;
                }
            }
        }
        public void DisplayElements()
        {
            for (int i = 0; i <= upper; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public void Clear()
        {
            for (int i = 0; i <= upper; i++) arr[i] = 0;
            numElements = 0;
        }

        public void Sort()
        {
            if (iSort == null)
            {
                throw new Exception("Sort not implemented!");
            }
            iSort.Sort(this);
        }
        #endregion

    }
}
