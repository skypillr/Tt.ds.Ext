using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tt.Ds.Test
{
    public class TestCMergeSort : ITest
    {
        Timing tim = new Timing();
        public void Test()
        {
            CArray array = CArray.InitInstanceByRand(SortData.SEED, SortData.COUNT);
            array.ISort = new CMergeSort();

            Console.WriteLine("starting MergeSort...\nbefore sort:");
            array.DisplayElements();

            #region 计时区间
            tim.StartTime();
            array.Sort();
            tim.StopTime();
            #endregion

            Console.WriteLine("\nafter merge sort shell:");
            array.DisplayElements();
            Console.WriteLine("\ntime costed of merge sort:" + tim.GetResult().Milliseconds + "ms");
        }
    }
}
