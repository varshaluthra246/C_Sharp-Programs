using System;
public class without_static
{
int count = 0;
void add()
{
count++;
Console.WriteLine("total students :" +count);
}
public static void Main(String[] args)
{
without_static s1 = new without_static
(); 
 without_static s2 = new without_static
(); 
s1.add();
s2.add();
Console.ReadLine();
}
} 