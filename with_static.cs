using System;
public class with_static
{
static int count = 0;
void add()
{
count++;
Console.WriteLine("total students :" +count);
}
public static void Main(String[] args)
{
with_static s1 = new with_static
(); 
 with_static s2 = new with_static
(); 
s1.add();
s2.add();
Console.ReadLine();
}
} 