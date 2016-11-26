using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tt.Ds
{
    public class CHeapArray : CArray
    {
        public CHeapArray() : base()
        {

        }
        public CHeapArray(int size) : base(size)
        {

        }
        public new static CHeapArray InitInstanceByRand(int seed, int size)
        {
            CHeapArray array = new CHeapArray(size);
            Random rnd = new Random(seed);
            for (int i = 0; i <= array.Upper; i++)
            {
                array.Insert((int)(rnd.NextDouble() * size));
            }
            return array;
        }
        public int CurIndex
        {
            get
            {
                return NumElements-1;
            }
        }
        /// <summary>
        /// 将当前最后插入的节点indexed at curIndex 移动到合适的位置
        /// </summary>
        /// <param name="heapArray"></param>
        /// <param name="curIndex"></param>
        public void ShiftUp(int curIndex)
        {
            int parent = (curIndex - 1) / 2;//父节点位置
            int bottom = arr[curIndex];
            while ((curIndex > 0) && (arr[parent] <
            bottom))//父节点比自己大就网上移动，父节点下移直到移不动或者当前节点已经是顶点  这个是大顶堆
            {
                arr[curIndex] = arr[parent];
                curIndex = parent;
                parent = (parent - 1) / 2;
            }
            arr[curIndex] = bottom;
        }

        /// <summary>
        /// 将indexTop节点下移，重新调整heap
        /// </summary>
        /// <param name="indexTop"></param>
        public void ShiftDown(int indexTop)
        {
            int largerChild;
            int top = arr[indexTop];//存放当前要移动的值

            int leftChild = 2 * indexTop + 1;
            while (leftChild <NumElements)//有子节点
            {
               
                int rightChild = leftChild + 1;//根据父节点得右子节点
                if (rightChild < NumElements)//有左右子节点
                {
                    #region 获取左右子节点较大的
                    if (arr[leftChild] < arr[rightChild])
                    {
                        largerChild = rightChild;
                    }
                    else
                    {
                        largerChild = leftChild;
                    }
                    #endregion
                }
                else//只有左节点
                {
                    largerChild = leftChild;
                }

                //停止比较
                if (top >= arr[largerChild])
                {
                    break;
                }

                #region 下移
                arr[indexTop] = arr[largerChild];
                indexTop = largerChild;
                #endregion

                leftChild = 2 * indexTop + 1;
            }
            arr[indexTop] = top;
        }

       /// <summary>
       /// 插入合适的位置
       /// </summary>
       /// <param name="item"></param>
       /// <returns></returns>
        public override bool Insert(int item)
        {
            if (CurIndex == Upper)
                return false;
            base.Insert(item);
            ShiftUp(CurIndex);
            return true;
        }

        /// <summary>
        /// 移除root
        /// </summary>
        /// <returns></returns>
        public int RemoveRoot()
        {
            int root = arr[0];
            arr[0] = arr[CurIndex];//用最后一个元素去填充
            numElements--;
            ShiftDown(0);
            return root;
        }
    }
}
