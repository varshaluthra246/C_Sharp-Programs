using System;
using System.Collections; 
using System.Collections.Generic;
class Collections6
{
public static void Main(String[] args)
{
var student = new SortedSet<string>(); //HashSet is created that can store String elements
student.Add("Mohan");
student.Add("varsha");
student.Add("Aman");
student.Add("kashish");
student.Add("rohan");
student.Add("rohan"); //duplicate element
foreach(var sname in student)
{
Console.WriteLine(sname);
}
Console.WriteLine("enter student name to delete");
string s = Console.ReadLine();
student.Remove(s);
Console.WriteLine("After deletion");
foreach(var sname in student)
{
Console.WriteLine(sname);
}
Console.ReadLine();
}
}