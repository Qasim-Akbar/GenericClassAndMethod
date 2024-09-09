using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassAndMethod
{
    internal class GenericStack<T>
    {
        private List<T> stack = new List<T>();

        public void Push(T item)

        {

            stack.Add(item);

        }

        public T Pop()

        {

            if (stack.Count == 0)

            {

                throw new InvalidOperationException("Cannot pop from an empty stack.");

            }

            T poppedItem = stack[stack.Count - 1];

            stack.RemoveAt(stack.Count - 1);

            return poppedItem;

        }

        public void Display()

        {
            Console.WriteLine("Current elements in the stack:");

            foreach (T item in stack)

            {

                Console.WriteLine(item);

            }

        }
    }
}
