using System;
//single inheritance
public class Constructor_overloading
{
public void m1() //method without any arguments
{
Console.WriteLine("Method without parameter");
}

public void m1(int i, int j) //method with 2 arguments
{
Console.WriteLine(i + j);
}
}
class B 
{
public static void Main(String[] args)
{
Constructor_overloading a = new Constructor_overloading();
a.m1();
a.m1(5,8);
Console.ReadLine();
}
} 
