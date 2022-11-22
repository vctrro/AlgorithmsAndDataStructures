using System;

namespace StackAndQueue
{
    public class Cell
    {
        public Cell(object data)
        {
            Data = data;
        }

        public object Data { get; }
        public Cell? Next { get; set; }
    }
}

