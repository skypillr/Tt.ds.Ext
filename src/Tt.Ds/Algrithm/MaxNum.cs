using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tt.Ds.Algrithm
{
    public class MaxNum
    {
        List<Node> LineNodes = new List<Node>();
        public MaxNum(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                LineNodes.Add(new Node(i, arr[i]));
            }
        }

        void Init()
        {
            int[] arr = new int[] { 1, 2, -8, -10, 90, 70, -2, 6, -6, 9, -9 };
            Console.WriteLine("Length:{0}", arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i.ToString() + " " + arr[i]);
                Node nod = new Node(i, arr[i]);
                nod.NodeBelong = LineNodes;
                LineNodes.Add(nod);
            }
        }
        public MaxNum()
        {
            Init();
        }
        public int FindMaxUntilIndex(int index)
        {
            if (index == 0)
            {
                LineNodes[0].MaxValue = LineNodes[0].Value;
                return LineNodes[0].Value;
            }
            int valueAtIndexBefore = LineNodes[index - 1].MaxValue = FindMaxUntilIndex(index - 1);
            int valueAtIndex = LineNodes[index].Value;
            int sum = valueAtIndexBefore + valueAtIndex;
            int max = 0;
            if (sum > valueAtIndex)
            {

                LineNodes[index].LineComposite.Add(LineNodes[index].Index);
                LineNodes[index].LineComposite.AddRange(LineNodes[index - 1].LineComposite.ToArray());

                max = LineNodes[index].MaxValue = sum;
            }
            else
            {
                LineNodes[index].LineComposite.Add(LineNodes[index].Index);

                max = LineNodes[index].MaxValue = valueAtIndex;
            }
            return max;
        }

        public void FindMax()
        {
            FindMaxUntilIndex(LineNodes.Count - 1);
            int index = -1;
            int value = 0;
            for (int i = 0; i < LineNodes.Count; i++)
            {
                if (LineNodes[i].MaxValue > value)
                {
                    index = i;
                    value = LineNodes[i].MaxValue;
                }
            }
            if (index >= 0)
            {
                LineNodes[index].Dispaly();
            }
        }
    }

    public class Node
    {
        public List<Node> NodeBelong { get; set; }
        public int Index { get; set; }
        public int Value { get; set; }

        public Node(int index, int value)
        {
            Index = index;
            Value = value;
            LineComposite = new List<int>();

        }
        public List<int> LineComposite { get; set; }

        public int MaxValue { get; set; }

        public void Dispaly()
        {
            if (NodeBelong == null) throw new Exception("nodeBelong is null");
            Console.WriteLine("index from {2} to {0} maxvalue {1}", Index, MaxValue, LineComposite[LineComposite.Count - 1]);
            for (int i = LineComposite.Count - 1; i >= 0; i--)
            {
                Console.WriteLine("Index at {0} value {1}", LineComposite[i], NodeBelong[LineComposite[i]].Value);
            }
            Console.WriteLine();
        }

    }
}