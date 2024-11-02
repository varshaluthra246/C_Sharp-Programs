using System;
//enter 0;
//Abnormal exception
public class Exception1
{
public static void Main(String[] args)
{
int i = 10;
int j = Convert.ToInt32(Console.ReadLine());
int result = i/j;
Console.WriteLine("result is: " + result);
Console.ReadLine();
}
}