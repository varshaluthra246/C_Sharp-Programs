using System;
public class Condition3
{
public static void Main(String[] args)
{
Console.WriteLine("Enter student marks:");
int i = Convert.ToInt32(Console.ReadLine());
if(i>=75)
{
Console.WriteLine("A Grade");
}
else if(i>60 && i<75)
{
Console.WriteLine("B Grade");
}
else
{
Console.WriteLine("C Grade");
}
Console.ReadLine();
}
}