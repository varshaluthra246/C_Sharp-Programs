using System;
public class Simple_Funtion
{
public void m1()
{
Console.WriteLine("Simple Function Call");
}
public static void Main(String[] args)
{
Simple_Funtion e1 = new Simple_Funtion(); //creating object of class
e1.m1(); //calling the function m1 using object e1
Console.ReadLine();
}
} 