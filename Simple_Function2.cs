using System;
public class Simple_Function2
{
//simple function to add 2 numbers
public void m1(int i, int j)
{
int result = i+j;
Console.WriteLine("sum of two numbers: " + result);
}
public static void Main(String[] args)
{
Simple_Function2 e1 = new Simple_Function2(); //creating object of class
e1.m1(10,15); //calling the function m1 using object e1
Console.ReadLine();
}
} 