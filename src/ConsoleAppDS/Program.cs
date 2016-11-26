using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tt.Ds;
using Tt.Ds.Test;

namespace ConsoleAppDS
{
    public class Program
    {
   
        public static void Main(string[] args)
        {
            //unsafe {
            //    int* a;
               
            //    int b = 10;
            //    a = &b;
            //    Console.WriteLine("0x{0:x}",(int)a);
            //}

            string strDel = "-------------------------------";

            Console.WriteLine(strDel);
            ITest test = new TestCBubbleSort();
            test.Test();

            Console.WriteLine(strDel);
            test = new TestCSelectionSort();
            test.Test();

            Console.WriteLine(strDel);
            test = new TestCInsertionSort();
            test.Test();

            Console.WriteLine(strDel);
            test = new TestCInsertionSortShell();
            test.Test();

            Console.WriteLine(strDel);
            test = new TestCMergeSort();
            test.Test();

            Console.WriteLine(strDel);
            test = new TestCHeapSort();
            test.Test();

            Console.WriteLine(strDel);
            test = new TestCQuickSort();
            test.Test();

            Console.WriteLine(strDel);
            test = new TestGetMaxSerialNumInLine();
            test.Test();

            Console.Read();
        }
    }
}
