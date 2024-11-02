using System;
//single inheritance
public class multilevel_inheritance //base class
{
public void m1()
{
Console.WriteLine("Method of Base Class-->multilevel_inheritance");
}
public class B: multilevel_inheritance 
{

public void m2()
{
Console.WriteLine("Method of Base Class B");
}
}
class C: B
{
public void m3()
{
Console.WriteLine("Method of Base Class B");
}
}
class D
{
public static void Main(String[] args)
{
C c1 = new C();
c1.m1();
c1.m2();
c1.m3();
Console.ReadLine();
}
} 
}