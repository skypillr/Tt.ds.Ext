using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tt.Ds;
using Tt.Ds.Algrithm;
namespace Tt.Ds.Test
{
    public class TestGetMaxSerialNumInLine : ITest
    {
        public void Test()
        {
            MaxNum m = new MaxNum();
            m.FindMax();
        }
    }
}
