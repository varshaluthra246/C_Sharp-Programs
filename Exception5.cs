using System;
//enter 0;
//Abnormal exception
public class Exception5
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
finally
{
Console.WriteLine("Finally Block");
}
Console.WriteLine("result is: " + result);
Console.ReadLine();
}
}