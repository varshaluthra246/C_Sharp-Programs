using System;
using System.Collections;
using System.Collections.Generic;
class Collections4
{
public static void Main(String[] args)
{
Queue<int> queue1  = new Queue<int>(); 
queue1.Enqueue(1);
queue1.Enqueue(2);
queue1.Enqueue(3);
queue1.Enqueue(4);

foreach(var j in queue1)
{
Console.WriteLine(j);
}
queue1.Dequeue();
Console.WriteLine("After removing of one element");
foreach(var j in queue1)
{
Console.WriteLine(j);
}
Console.ReadLine();
}
}