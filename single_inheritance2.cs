using System;
//single inheritance
public class single_inheritance2 //base class
{
public int i = 10;
public void m2()
{
Console.WriteLine("Method of Base Class");
}
public class B: single_inheritance2
{
int j = 20;
public void m1()
{
Console.WriteLine(i + j);
}
}
class C
{
public static void Main(String[] args)
{
B b1 = new B();
b1.m2();
Console.ReadLine();
}
} 
}