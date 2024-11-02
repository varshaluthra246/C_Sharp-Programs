using System;
//throw kwyword
public class notvalidage : Exception
{
public notvalidage(string s): base(s)
{

}
}
class Exception6
{
static void checkage(int i)
{
if(i<18)
{
throw new notvalidage("age is not valid");
}
}
public static void Main(String[] args)
{
try{
 checkage(16);
}
catch(notvalidage ne)
{
Console.WriteLine(ne);
}
Console.ReadLine();
}
}