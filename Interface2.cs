using System;
//Interface
public interface Interface2
{
 void m1();
}
public interface A1{
 void m1();
}
class B: Interface2, A1
{
public void m1()
{
Console.WriteLine("M1");
}
}
class C
{
public static void Main(String[] args)
{
B b = new B();
b.m1();

Console.ReadLine();
}
} 
