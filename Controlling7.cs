using System;
public class Controlling7
{
public static void Main(String[] args)
{
for(int i =1 ; i<=10;i++)
{
for(int j=1;j<=5;j++)
{
if(j==3)
break;
Console.WriteLine(i + " " +j);
}
}
Console.WriteLine("After the loop");
Console.ReadLine();
}

}

