// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter either 'Y' or 'N':");
string entry = Console.ReadLine();

bool resultY = entry.Equals("Y");
bool resultY1 = entry.Equals("y");
bool resultN = entry.Equals("N");
bool resultN1 = entry.Equals("n");

if (resultY || resultY1)
{
    Console.WriteLine("Yes!");
}
else if (resultN || resultN1)
{
    Console.WriteLine("No!");
}
else
{
    Console.WriteLine("Fail");
}