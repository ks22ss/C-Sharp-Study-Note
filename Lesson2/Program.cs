using System.Collections.Generic;

//Array

//Array Declaration
int[] ints = {1,2,3,4,5};
string[] strs = { "1", "2", "3" };

//Array indexing
System.Console.WriteLine(ints[0]);
System.Console.WriteLine(ints[1]);
System.Console.WriteLine(ints[2]);

//Array indexing last element
System.Console.WriteLine(ints[ints.Length - 1]);


//Array reassign element
ints[0] = 9;
System.Console.WriteLine(ints[0]);


//Array Fix Size Declare
string[] strs_arr = new string[10];


//Generic List
List<int> list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
