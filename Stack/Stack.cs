using System;

namespace StackAndQueue
{
    public class Stack
    {
        protected Cell? head;

        public virtual void Push(object data)
        {
            if (head == null)
            {
                head = new Cell(data);
            }
            else
            {
                var next = head;
                head = new Cell(data);
                head.Next = next;
            }
        }

        public virtual object? Pop()
        {
            object? data = null;
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                data = head.Data;
                head = head.Next;
            }

            return data;
        }

        public virtual void Clear()
        {
            head = null;
        }
    }
}

