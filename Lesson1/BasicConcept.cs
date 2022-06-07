
// How to print in console?
System.Console.WriteLine("  /|");
System.Console.WriteLine(" / |");
System.Console.WriteLine("/__|");

// This is Comments
/*
 Muti line Comments
 */

// Basic Data Types and Variables declaration
// [type] [variable name] = [value];
string name = "King";
char sex = 'M';
int age = 31;
double height = 177.2;
bool is_rich = false;

System.Console.WriteLine("My name is " + name);
System.Console.WriteLine("My sex is " + sex);
System.Console.WriteLine("I am " + age + " years old");
System.Console.WriteLine("I am " + height + " cm tall");
System.Console.WriteLine("Am I rich? " + is_rich);

//Print mutiple lines
System.Console.WriteLine("\n");
System.Console.WriteLine("Hello\nWorld.");

//Print '' in string
System.Console.WriteLine("\n");
System.Console.WriteLine("I am 'Wrapped' ");

//Escape Character
System.Console.WriteLine("\n");
System.Console.WriteLine("I am \"Wrapped\" ");

//string interpolation $""
string subject = "C#";
System.Console.WriteLine("\n");
System.Console.WriteLine($"I am learning {subject}");

//Composite formatting
string subject2 = "F#";
System.Console.WriteLine("\n");
System.Console.WriteLine("I am learning {0}, {1} and {2}", subject2, "C#", ".NET");


//Common String Methods:
string words = "Consider the following example:";

System.Console.WriteLine("\n");
System.Console.WriteLine(words.ToUpper());
System.Console.WriteLine(words.ToLower());
System.Console.WriteLine(words.Contains("the"));

//String indexing
System.Console.WriteLine(words[0]);
System.Console.WriteLine(words[1]);
System.Console.WriteLine(words[2]);

//String Method: IndexOf
System.Console.WriteLine(words.IndexOf("C")); //1st position
System.Console.WriteLine(words.IndexOf("e")); // 6th position (1st occurence)
System.Console.WriteLine(words.IndexOf("@")); //can't find return -1
System.Console.WriteLine(words.IndexOf("follow")); //f is in 13 position, so return 13

//String Method: Substring
System.Console.WriteLine(words.Substring(4)); //ider the following example: cut from 4th position
System.Console.WriteLine(words.Substring(4, 6)); //ider t: cut from 4th position and count 6 char


//Int divided by Int is Int
System.Console.WriteLine(5 / 2);//2

//Int divided by Double is Double
System.Console.WriteLine(5 / 2.2);//2.27272727272...

//Math
System.Console.WriteLine(System.Math.Abs(-10));//10
System.Console.WriteLine(System.Math.Floor(12.2));//12
System.Console.WriteLine(System.Math.Ceiling(12.2));//13
System.Console.WriteLine(System.Math.Pow(2,3));//8
System.Console.WriteLine(System.Math.Sqrt(16));//4
System.Console.WriteLine(System.Math.Max(2,99));//99
System.Console.WriteLine(System.Math.Min(2, 99));//2

//User Input
System.Console.WriteLine("Press any button to continue...");
string res = System.Console.ReadLine();
System.Console.WriteLine($"You have enter {res}");

// possible null value with "?" nullable
System.Console.WriteLine("Press any button to continue... no code warnings");
string? res_2 = System.Console.ReadLine();
System.Console.WriteLine($"You have enter {res_2}");


