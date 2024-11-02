using System;
//method_overriding
public class method_overriding2
{
public virtual void m1()
{
Console.WriteLine("method of base class");
}
}
public class B: method_overriding2
{
public override void m1()
{
Console.WriteLine("method of derived class");
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
