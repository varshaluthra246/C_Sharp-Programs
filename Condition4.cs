using System;
public class Condition4
{
public static void Main(String[] args)
{
Console.WriteLine("Enter First Number:");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Second Number:");
int j = Convert.ToInt32(Console.ReadLine());
int result = 0;
Console.WriteLine("Enter the operation to perform +, -, /, *");
Char op = Convert.ToChar(Console.ReadLine());
switch(op)
{
case '+' : result = i+j;
break;

case '-' : result = i-j;
break;

case '*' : result = i*j;
break;

case '/' : result = i/j;
break;

default: Console.WriteLine("Wrong Input");
break;
}
Console.WriteLine("result is:" + result);
Console.ReadLine();
}
}