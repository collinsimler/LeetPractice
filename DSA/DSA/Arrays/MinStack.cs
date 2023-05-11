using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    public class MinStack
    {
        private Stack<int> stack1;
        private ArrayList stack = new();
        public int Count;


        public MinStack()
        {
            Count = 0;

        }

        public void Push(int val)
        {
            stack[Count] = val;
            Count++;
        }

        public void Pop()
        {
            stack[Count] = null;
            Count--;
        }

        public int Top()
        {
            return (int)stack[Count];
        }

        public int GetMin()
        {
            ArrayList tempStack = new();

            for (int i = 0; i < Count; i++)
            {
                tempStack[i] = stack[i];
            }

            for (int i = 0; i < Count - 1; i++)
            {
                this.Pop();
            }

            int min = this.Top();

            stack = tempStack; // reset stack

            return min;
            
        }

    }
}
