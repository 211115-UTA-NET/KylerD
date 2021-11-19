// See https://aka.ms/new-console-template for more information

byte byteEx = 100;
sbyte sbyteEx = -100;
int intEx = -1000000;
uint uintEx = 1000000;
short shortEx = 15000;
long longEx = -9999999999;
ulong ulongEx = 9999999999;
float floatEx = 3.33F;
double doubleEx = 3.14159;
char charEx = 'a';
bool boolEx = true;
//object objectEx = 500;
string stringEx = "String";
decimal decimalEx = 1.0M;

string string1 = "I control text";
string string2 = "12345";
int int1;
int int2;
bool bool1;
bool bool2;

bool1 = int.TryParse(string1, out int1);
bool2 = int.TryParse(string2, out int2);

if (bool1 == true && bool2 == true)
{
    Console.WriteLine("Both " + int1 + " and " + int2 + " were successfully converted to an integer!");
}
else if (bool1 == true)
{
    Console.WriteLine("Only " + int1 + " was converted to an integer.");
}
else if (bool2 == true)
{
    Console.WriteLine("Only " + int2 + " was converted to an integer.");
}
else
{
    Console.WriteLine("Neither " + int1 + " or " + int2 + " were successfully converted to an integer");
}

Console.WriteLine(byteEx);
Console.WriteLine(sbyteEx);
Console.WriteLine(intEx);
Console.WriteLine(uintEx);
Console.WriteLine(shortEx);
Console.WriteLine(longEx);
Console.WriteLine(ulongEx);
Console.WriteLine(floatEx);
Console.WriteLine(doubleEx);
Console.WriteLine(charEx);
Console.WriteLine(boolEx);
Console.WriteLine(stringEx);
Console.WriteLine(decimalEx);