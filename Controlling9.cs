using System;
public class Controlling9
{
public static void Main(String[] args)
{
for(int i =1 ; i<=4;i++)
{
for(int j=1; j <=4; j++)
{
if(i==2 && j==2)
{
continue;
}
Console.WriteLine(i + " " +j);
}
}
Console.WriteLine("After the loop");
Console.ReadLine();
}
}

