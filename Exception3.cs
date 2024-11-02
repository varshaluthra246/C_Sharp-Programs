using System;
//A previous catch clause already catches all exceptions of this or of a super type
        ('System.Exception')

//order of catch exceptions really matters -- super exception must be at last
//look at example -- exception4 
public class Exception3
{
public static void Main(String[] args)
{
int i = 10;
int j = Convert.ToInt32(Console.ReadLine());
int result = 0;
try
{
 result = i/j;
}
catch(Exception e)
{
Console.WriteLine( "divide by 0 is not allowed "+ " " + e);
}
catch(IndexOutOfRangeException ie)
{
Console.WriteLine("Testing");
Console.ReadLine();
}
Console.WriteLine("result is:" + result);
Console.ReadLine();
}
}