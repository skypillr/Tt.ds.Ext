using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tt.Ds.Test
{
    public class TestCInsertionSort : ITest
    {
        Timing tim = new Timing();
        public void Test()
        {
            CArray array = CArray.InitInstanceByRand(SortData.SEED, SortData.COUNT);
            array.ISort = new CInsertionSort();

            Console.WriteLine("starting InsertionSort...\nbefore sort:");
            array.DisplayElements();

            #region 计时区间
            tim.StartTime();
            array.Sort();
            tim.StopTime();
            #endregion

            Console.WriteLine("\nafter insertion sort:");
            array.DisplayElements();
            Console.WriteLine("\ntime costed of insertion sort:" + tim.GetResult().Milliseconds + "ms");
        }
    }
}
