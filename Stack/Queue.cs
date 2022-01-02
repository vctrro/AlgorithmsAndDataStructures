using System;

namespace StackAndQueue
{
    public class Queue : Stack
    {
        private Cell? tail;

        public override void Push(object data)
        {
            if (tail == null)
            {
                tail = new Cell(data);
                head = tail;
            }
            else
            {
                tail.Next = new Cell(data);
                tail = tail.Next;
            }
        }

        public override object? Pop()
        {
            object? data = null;
            if (head != null)
            {
                data = head.Data;
                head = head.Next;
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }

            return data;
        }

        public override void Clear()
        {
            base.Clear();
            tail = null;
        }

    }
}

