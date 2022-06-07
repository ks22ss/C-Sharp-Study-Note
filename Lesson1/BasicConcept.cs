
// How to print in console?
System.Console.WriteLine("  /|");
System.Console.WriteLine(" / |");
System.Console.WriteLine("/__|");

// This is Comments
/*
 Muti line Comments
 */

// Basic Data Types and Variables
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