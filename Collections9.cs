using System;
using System.Collections.Generic;

class Collections8 {
	static public void Main() {
		
		Dictionary<int, string> My_dict =
					new Dictionary<int, string>();
			
		My_dict.Add(1,"Aman");
		My_dict.Add(2,"Mohan");
		My_dict.Add(3,"Rohan");
			
		// Before Remove() method
		foreach(KeyValuePair<int, string> ele in My_dict)
		{
			Console.WriteLine("{0} and {1}",
						ele.Key, ele.Value);
		}
		Console.WriteLine();
			
		// Using Remove() method
		My_dict.Remove(1123);
			
		// After Remove() method
		foreach(KeyValuePair<int, string> ele in My_dict)
		{
			Console.WriteLine("{0} and {1}",
						ele.Key, ele.Value);
		}
		Console.WriteLine();
			
			
		// Using Clear() method
		My_dict.Clear();
			
		Console.WriteLine("Total number of key/value "+
		"pairs present in My_dict:{0}", My_dict.Count);
		
	}
}
