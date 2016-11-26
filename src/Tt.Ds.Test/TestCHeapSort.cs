using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tt.Ds.Test
{
    public class TestCHeapSort: ITest
    {
        Timing tim = new Timing();
     
        public void Test()
        {
            CHeapArray array =  CHeapArray.InitInstanceByRand(SortData.SEED, SortData.COUNT);
            //array.Insert(82);
            //array.Insert(77);
            //array.Insert(29);
            //array.Insert(54);
            //array.Insert(2);
            //array.Insert(58);
            //array.Insert(31);
            //array.Insert(71);
            //array.Insert(78);
            array.ISort = new CHeapSort(array.Count);

            Console.WriteLine("starting HeapSort...\nbefore sort:");
            array.DisplayElements();

            #region 计时区间
            tim.StartTime();
            array.Sort();
            tim.StopTime();
            #endregion

            Console.WriteLine("\nafter heap sort:");
            array.DisplayElements();
            Console.WriteLine("\ntime costed of heap sort:" + tim.GetResult().Milliseconds+"ms");
        
        }
    }
}
