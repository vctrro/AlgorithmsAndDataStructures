using Stack;

Console.WriteLine("Hello, World!");

MyStack stack = new MyStack();

stack.Push(12);
stack.Push(44);
stack.Push("Data");

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());



