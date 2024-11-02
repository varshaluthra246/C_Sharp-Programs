using System;
using System.Collections.Generic;
using System.Collections;
class Collections7
{
public static void Main(String[] args)
{
var student = new LinkedList<string>();
student.AddLast("E");
student.AddLast("F");
student.AddFirst("D");
LinkedListNode<string> node = student.Find("F");
student.AddAfter(node,"G");
student.AddBefore(node,"B");

foreach(var sname in student)
{
Console.WriteLine(sname);
}
Console.ReadLine();
}
}