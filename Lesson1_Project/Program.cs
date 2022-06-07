// We are building a calculator using C# console

System.Console.WriteLine("Input the 1st number:");
string? a = System.Console.ReadLine();
System.Console.WriteLine("Input the 2nd number:");
string? b = System.Console.ReadLine();


System.Console.WriteLine($"The answer is {a+b}");


//Explicit Type Conversion Integer only
System.Console.WriteLine("Input the 1st number(integer):");
int num1 = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Input the 2nd number(integer):");
int num2 = System.Convert.ToInt32(System.Console.ReadLine());


System.Console.WriteLine($"The answer is {num1 + num2}");


//Explicit Type Conversion Integer and Double
System.Console.WriteLine("Input the 1st number(integer):");
double num3 = System.Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Input the 2nd number(integer):");
double num4 = System.Convert.ToDouble(System.Console.ReadLine());


System.Console.WriteLine($"The answer is {num3 + num4}");

