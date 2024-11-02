using System;
public class destructor
{
//destructor
destructor()
{
Console.WriteLine("Default");
}
~destructor()
{
Console.WriteLine("destructor");
Console.ReadLine();	
}

public static void Main(String[] args)
{
destructor
 s1 = new destructor
(); 
 
Console.ReadLine();
}
} 