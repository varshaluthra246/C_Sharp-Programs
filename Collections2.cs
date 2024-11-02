using System;
using System.Collections;
using System.Collections.Generic;
class Collections2
{
public static void Main(String[] args)
{
Stack<int> stack1  = new Stack<int>(); 
stack1.Push(1);
stack1.Push(2);
stack1.Push(3);
stack1.Push(4);

foreach(var j in stack1)
{
Console.WriteLine(j);
}
Console.ReadLine();
}
}