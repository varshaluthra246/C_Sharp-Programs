using System;
public class Call_by_value
{
//Call_by_value
public void m1(int val)
{
val = val + 10; //changing the variable value
Console.WriteLine("value in the called function is:" + val);
}
public static void Main(String[] args)
{
int val = 15;
Call_by_value e1 = new Call_by_value();
Console.WriteLine("Value before calling the function : " +val);
e1.m1(val);
Console.WriteLine("Value after calling the function : " +val);
Console.ReadLine();
}
} 