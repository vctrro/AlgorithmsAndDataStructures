using System;

namespace Stack
{
    

    public class MyStack
    {
        private Cell? head;

        public void Push(object data)
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

        public object Pop()
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

        private class Cell
        {
            public Cell(object data)
            {
                Data = data;
            }

            public object Data { get; private set; }
            public Cell Next { get; set; }
        }
    }
}

