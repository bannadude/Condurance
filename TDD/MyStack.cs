using System;
using System.Collections.Generic;

namespace TDD
{
    internal class MyStack
    {
        Stack<object> stack_items;


        public MyStack()
        {
            stack_items = new Stack<object>();
        }

        public void push(object item)
        {
            stack_items.Push(item);
        }

        public object pop()
        {
            try
            {
                return stack_items.Pop();
            }
            catch
            {
                throw new Exception("my exception");
            }
        }
    }
}