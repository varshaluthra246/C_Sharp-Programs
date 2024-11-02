using System;
//single inheritance
public class single_inheritance //base class
{
public int i = 10;
}
public class B: single_inheritance
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
b1.m1();
Console.ReadLine();
}
} 