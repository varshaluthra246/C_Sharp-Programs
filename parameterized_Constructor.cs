using System;
public class parameterized_Constructor
{
//parameterized_Constructor
parameterized_Constructor()
{
Console.WriteLine("Default constructor");
}
parameterized_Constructor(int i, int j)
{
Console.WriteLine(i+j);
}

public static void Main(String[] args)
{
parameterized_Constructor
 s1 = new parameterized_Constructor
(5,6); 
parameterized_Constructor
 s2 = new parameterized_Constructor
(); 
Console.ReadLine();
}
} 