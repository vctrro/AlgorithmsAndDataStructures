using StackAndQueue;

Console.WriteLine("Hello, World!");

Stack stack = new Stack();

stack.Push(12);
stack.Push(44);
stack.Push("Data");

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());

Queue queue = new();

queue.Push(12);
queue.Push(44);
queue.Push("Data");
queue.Push("Data1");

Console.WriteLine(queue.Pop());
Console.WriteLine(queue.Pop());
Console.WriteLine(queue.Pop());
queue.Clear();
Console.WriteLine(queue.Pop());
