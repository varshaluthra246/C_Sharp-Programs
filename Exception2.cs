using System;
//enter 0;
//Abnormal exception
public class Exception2
{
public static void Main(String[] args)
{
int i = 10;
int j = Convert.ToInt32(Console.ReadLine());
int result = 0;
try
{
 result = i/j;
}
catch(Exception e)
{
Console.WriteLine( "divide by 0 is not allowed "+ " " + e);
}
Console.WriteLine("result is: " + result);
Console.ReadLine();
}
}