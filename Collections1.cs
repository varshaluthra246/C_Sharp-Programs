using System;
using System.Collections.Generic;
class Collections1
{
public static void Main(String[] args)
{
var student = new List<string>(); //List is created that can store String elements
student.Add("aman");
student.Add("varsha");
student.Add("mohan");
student.Add("kashish");
student.Add("rohan");
student.Add("rohan"); //list can contain duplicate elements
foreach(var sname in student)
{
Console.WriteLine(sname);
}
Console.ReadLine();
}
}