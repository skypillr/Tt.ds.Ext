using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tt.Ds.Test
{
    public class TestCQuickSort : ITest
    {
        Timing tim = new Timing();
        public void Test()
        {
           

            CArray array = CArray.InitInstanceByRand(SortData.SEED, SortData.COUNT);
            array.ISort = new CQuickSort();

            Console.WriteLine("starting QuickSort...\nbefore sort:");
            array.DisplayElements();
           
            #region 计时区间
            tim.StartTime();
            array.Sort();
            tim.StopTime();
            #endregion

            Console.WriteLine("\nafter quick sort:");
            array.DisplayElements();
            Console.WriteLine("\ntime costed of quick sort:" + tim.GetResult().Milliseconds+"ms");
           
        }
    }
}
