using System;
public class Controlling1
{
public static void Main(String[] args)
{
Console.WriteLine("Counting from 1 to 20:");
for(int i=1;i<=20;i++)
{
Console.WriteLine(i);
}
Console.WriteLine(" table of 2:");

for(int i=2;i<=20;i=i+2)
{
Console.WriteLine(i);
}
Console.ReadLine();
}
}