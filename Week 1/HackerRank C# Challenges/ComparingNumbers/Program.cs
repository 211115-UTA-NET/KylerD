// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a value for X:");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a value for Y:");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > Y)
{
    Console.WriteLine("X is greater than Y");
}
else if (X == Y)
{
    Console.WriteLine("X is equal to Y");
}
else if (X < Y)
{
    Console.WriteLine("X is less than Y");
}