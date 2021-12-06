// See https://aka.ms/new-console-template for more information
Console.WriteLine("Fizz = Divisible by 3");
Console.WriteLine("Buzz = Divisible by 5");
Console.WriteLine("Fizz-Buzz = Divisible by 3 and 5");

for (int i = 1; i <= 1000; i++)
{
    if ((i % 3 == 0) && (i % 5 != 0))
        Console.WriteLine(i + ": Fizz");
    else if ((i % 3 != 0) && (i % 5 == 0))
        Console.WriteLine(i + ": Buzz");
    else if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine(i + ": Fizz-Buzz!");
    else
        Console.WriteLine(i + ":");
}