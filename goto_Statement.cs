using System;
public class goto_Statement
{
public static void Main(String[] args)
{
l1:
Console.WriteLine("Number is less than 10");
Console.WriteLine("Enter the Number");
int i = Convert.ToInt32(Console.ReadLine());
if(i<10)
{
goto l1;
}
else
{
Console.WriteLine("Number is greater than 10");
}
Console.ReadLine();
}
}

