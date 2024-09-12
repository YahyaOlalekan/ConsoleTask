// See https://aka.ms/new-console-template for more information

// Task 1: Declare and initialize variables
string name = "John Doe";
int age = 25;
bool isAdmin = true;

// Print the values to the console
Console.WriteLine("Task 1:");
Console.WriteLine("Name: " + name);
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Is Admin: {isAdmin}");
Console.WriteLine();

// Task 2: Check if a number is even or odd
Console.WriteLine("Task 2:");
Console.Write("Enter an integer: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"{number} is an even number");
}
else
{
    Console.WriteLine($"{number} is an odd number");
}
Console.WriteLine();

// Task 3: Print numbers from 1 to 10 using a for loop
Console.WriteLine("Task 3:");
Console.WriteLine("Numbers from 1 to 10 are:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine();

// Task 4: Declare and initialize an array, print sum of elements
Console.WriteLine("Task 4:");
int[] numbers = { 2, 4, 6, 8, 10 };
int sum = 0;

Console.WriteLine("Elements of the given array are: ");
foreach (int num in numbers)
{
    Console.WriteLine(num);
    sum += num;
}

Console.WriteLine("Sum of array elements: " + sum);
Console.WriteLine();

// Task 5: Call the Greet method
Console.WriteLine("Task 5:");
Greet("Alice");
    

    // Task 5: Method to print a personalized greeting
static void Greet(string name)
{
    //Console.WriteLine("Hello, " + name + "!");
    Console.WriteLine($"Hello {name}!");
}