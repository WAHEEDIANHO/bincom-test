//Task 1
Console.WriteLine("=====Task 1=====");
string name = "John Doe";
int age = 25;
bool isAdmin = true;

Console.WriteLine($"name is {name}");
Console.WriteLine($"age is {age}");
Console.WriteLine($"isAdmin {isAdmin}");

//Task 2
Console.WriteLine("=====Task 2=====");
Console.WriteLine("=====Enter any number=======");
int inp = int.Parse(Console.ReadLine()!);
if(inp%2 == 0) Console.WriteLine("Even");
else Console.WriteLine("Odd"); 


//Task 3
Console.WriteLine("=====Task 3=====");
for(int i=1; i<=10; i++) Console.WriteLine(i);
//Task 4
Console.WriteLine("=====Task 4=====");
int[] intArray = [2, 4, 6, 8, 10];
Console.WriteLine($"The sum of the elements is {intArray.Sum()}");
foreach(int num in intArray) Console.WriteLine(num);

//Task 5
Console.WriteLine("=====Task 5=====");
Greet("Alice");
static void Greet(string name) 
{
    Console.WriteLine($"Hello {name}!");
}

