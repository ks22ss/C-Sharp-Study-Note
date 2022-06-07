//Conditional Statement

bool boolean_expression = 2 > 1;

if (boolean_expression)
{
    System.Console.WriteLine("2 is larger than 1");
}
else
{
    System.Console.WriteLine("2 is not larger than 1");
}



//Mutiple Conditional Statement 
int age = 30;

if (age < 18)
{
    System.Console.WriteLine("Teen");
}
else if (age >= 18 && age < 25)
{
    System.Console.WriteLine("Young Adult");
}
else if (age >= 25 && age < 60)
{
    System.Console.WriteLine("Adult");
}
else
{
    System.Console.WriteLine("Elder");
}

//While Loop
int i = 0;
while (i < 5)
{
    System.Console.WriteLine(i);
    i++;
}

int j = 0;
do
{
    Console.WriteLine(j);
    j++;
}
while (i < 5);


//For Loop
for (int a = 0; a < 5; a++)
{
    Console.WriteLine(a);
}

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (string car in cars)
{
    Console.WriteLine(car);
}

//Break and Continue

for (int a = 0; a < 10; a++)
{
    if (a == 4)
    {
        break;//1,2,3 stop..
    }
    Console.WriteLine(a);
}



for (int a = 0; a < 10; a++)
{
    if (a == 4)
    {
        continue;//skip 4
    }
    Console.WriteLine(a);
}


//short hand
if (10 > 9)
    Console.WriteLine("Short Hand");