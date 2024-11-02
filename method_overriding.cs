using System;
//method_overriding
public class method_overriding
{
public void m1()
{
Console.WriteLine("method of base class");
}
}
public class B: method_overriding
{
public void m1()
{
Console.WriteLine("method of derived class");
}
}
class C
{
public static void Main(String[] args)
{
B a = new B();
a.m1();

Console.ReadLine();
}
} 
