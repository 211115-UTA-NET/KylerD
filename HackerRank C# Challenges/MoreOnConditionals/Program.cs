// See https://aka.ms/new-console-template for more information
Console.WriteLine("Insert the length of side A:");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert the length of side B:");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert the length of side C:");
int sideC = Convert.ToInt32(Console.ReadLine());

if (sideA == sideB && sideB == sideC)
{
    Console.WriteLine("EQUILATERAL");
}
else if (sideA == sideB || sideA == sideC || sideB == sideC)
{
    Console.WriteLine("ISOSCELES");
}
else
{
    Console.WriteLine("SCALENE");
}