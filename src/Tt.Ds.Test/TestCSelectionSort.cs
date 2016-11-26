using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tt.Ds.Test
{
    public class TestCSelectionSort : ITest
    {
        Timing tim = new Timing();
        public void Test()
        {
           

            CArray array = CArray.InitInstanceByRand(SortData.SEED, SortData.COUNT);
            array.ISort = new CSelectionSort();

            Console.WriteLine("starting SelectionSort...\nbefore sort:");
            array.DisplayElements();
           
            #region 计时区间
            tim.StartTime();
            array.Sort();
            tim.StopTime();
            #endregion

            Console.WriteLine("\nafter selection sort:");
            array.DisplayElements();
            Console.WriteLine("\ntime costed of selection sort:"+ tim.GetResult().Milliseconds+"ms");
           
        }
    }
}
