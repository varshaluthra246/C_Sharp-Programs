using System;
//single inheritance
public class Constructor_overloading2
{
public void m1(int i) //method with int argument
{
Console.WriteLine(i + " :method with int argument");
}

public void m1(float f) //method with float argument
{
Console.WriteLine(f + " :method with float argument");
}
}
class B 
{
public static void Main(String[] args)
{
Constructor_overloading2 a = new Constructor_overloading2();
a.m1(4);
a.m1(5.8f);
Console.ReadLine();
}
} 
