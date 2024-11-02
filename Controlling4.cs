using System;
public class Controlling4
{
public static void Main(String[] args)
{
int i=1;
Console.WriteLine("i		j");
Console.WriteLine(" ");

while(i<=2)
{
int j=1;
while(j<=3)
{
Console.WriteLine(i+"		"+j);
j++;
}
i++;
}
Console.ReadLine();
}
}