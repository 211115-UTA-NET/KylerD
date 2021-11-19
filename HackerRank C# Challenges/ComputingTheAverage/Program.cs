// See https://aka.ms/new-console-template for more information
#Computes the average of given numbers!
Console.WriteLine("Enter some numbers! When you are finished, type 'End'");
List<int> numbers = new List<int>();

while (true)
{
    string x = Console.ReadLine();
    bool result = x.Equals("End");
    if (result)
    {
        break;
    }
    try
    {
        int y = Convert.ToInt32(x);
        numbers.Add(y);
    }
    catch
    {
        Console.WriteLine("Invalid entry! Try again!");
    }
}

int average = 0;

foreach (int i in numbers)
{
    average = average + i;
}

int length = numbers.Count;

int finalAverage = average / length;

Console.WriteLine(finalAverage);