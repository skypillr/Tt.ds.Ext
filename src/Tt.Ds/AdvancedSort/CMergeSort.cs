using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tt.Ds
{
    public class CMergeSort : ISortArray
    {
        public void Sort(CArray array)
        {
            RecMerge(array,0,array.Upper);
        }

    
        void RecMerge(CArray array,int low,int high)
        {
            if (low == high)
            {
                return;
            }
            else {
                int mid = (low + high) / 2;
                int midPlus = mid + 1;
                RecMerge(array, low, mid);
                RecMerge(array, midPlus, high);
                Merge(array,low, midPlus, high);
            }
        }
        /// <summary>
        /// 合并
        /// </summary>
        /// <param name="array"></param>
        /// <param name="lowp">低index起始</param>
        /// <param name="highp">高index起始</param>
        /// <param name="ubound">高index顶部</param>
        void Merge(CArray array,int lowp,int highp,int ubound)
        {

            int mid = highp - 1;
            int lp_tmp = lowp;
            int hp_tmp = highp;

            int[] arrayTmp = new int[array.Count];

            int j = 0;
            while (lp_tmp <= mid&& hp_tmp<= ubound)
            {
                if (array[lp_tmp] <array[hp_tmp])
                {
                    arrayTmp[j]=array[lp_tmp];
                    lp_tmp++;
                    j++;
                }
                else {
                    arrayTmp[j]=array[hp_tmp];
                    hp_tmp++;
                    j++;
                }
            }
            while (lp_tmp <= mid)
            {
                arrayTmp[j]=array[lp_tmp];
                lp_tmp++;
                j++;
            }
            while (hp_tmp <= ubound)
            {
                arrayTmp[j]=array[hp_tmp];
                hp_tmp++;
                j++;
            }
            for (int i = lowp,k=0; i <= ubound; i++,k++)
            {
                array[i] = arrayTmp[k];
            }

        }
    }
}
