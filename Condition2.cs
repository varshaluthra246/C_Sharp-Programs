using System;
public class Condition2
{
public static void Main(String[] args)
{
Console.WriteLine("Enter the number to test:");
int i = Convert.ToInt32(Console.ReadLine());
if(i%2==0)
{
Console.WriteLine("its an even number");
}
else
{
Console.WriteLine("Its an odd number");
}
Console.ReadLine();
}
}
