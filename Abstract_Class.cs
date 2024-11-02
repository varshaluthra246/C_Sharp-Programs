using System;
//method_overriding
// ERROR: Cannot create an instance of the abstract class or interface 'Abstract_Class'
public abstract class Abstract_Class
{
public abstract void m1();
public void m2()
{
Console.WriteLine("M2");
}
}
class B: Abstract_Class
{
public override void m1()
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
b.m2();
Console.ReadLine();
}
} 
