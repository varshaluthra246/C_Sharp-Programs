using System;
public class Opps1
{
//Object Oriented programming System
int id;
String name;

public void add(int i, String s)
{
id = i; 
name = s;
}

public void show()
{
Console.WriteLine("ID is:" + id + "Student name is:" +name);
}

public static void Main(String[] args)
{
Opps1 s1 = new Opps1(); //creating object by calling constructor
Opps1 s2 = new Opps1();
s1.add(1,"Varsha");
s2.add(2, "Mohan");
s1.show();
s2.show();
s1.show();
Console.ReadLine();
}
} 