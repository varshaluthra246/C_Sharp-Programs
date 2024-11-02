using System;
public class Out_parameter
{
//use of Out_parameter
public void m1(out int i)
{
i = 5; 
i = i+10;
}

public static void Main(String[] args)
{
int i = 6;
Out_parameter e1 = new Out_parameter();
Console.WriteLine(" before calling the function : " +i);
e1.m1(out i);
Console.WriteLine(" after calling the function : " +i);
Console.ReadLine();
}
} 