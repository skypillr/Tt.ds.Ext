using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tt.Ds.Test
{
    public class TestCBubbleSort: ITest
    {
        Timing tim = new Timing();
     
        public void Test()
        {
            CArray array = CArray.InitInstanceByRand(SortData.SEED, SortData.COUNT);
            array.ISort = new CBubbleSort();

            Console.WriteLine("starting BubbleSort...\nbefore sort:");
            array.DisplayElements();

            #region 计时区间
            tim.StartTime();
            array.Sort();
            tim.StopTime();
            #endregion

            Console.WriteLine("\nafter bubble sort:");
            array.DisplayElements();
            Console.WriteLine("\ntime costed of bubble sort:"+ tim.GetResult().Milliseconds+"ms");
        
        }
    }
}
