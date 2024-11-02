using System;
public class Simple_Function3
{
//simple function to add 2 numbers
public int m1(int i, int j)
{
int result = i+j;
return result;
}
public static void Main(String[] args)
{
Simple_Function3 e1 = new Simple_Function3(); //creating object of class
int ans =e1.m1(10,15); //calling the function m1 using object e1
Console.WriteLine("sum of 2 numbers:" +ans);
Console.ReadLine();
}
} 