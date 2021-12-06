// See https://aka.ms/new-console-template for more information

string myString;
string myInt;
int parsedInt;

Console.WriteLine("Please enter your message and press enter:");
myString = Console.ReadLine();

Console.WriteLine("The length of your message is " + myString.Length + " characters long");
Console.WriteLine("Please enter a number LESS THAN the length of your message and press enter:");
myInt = Console.ReadLine();

parsedInt = int.Parse(myInt);

Console.WriteLine("Original: " + myString);
Console.WriteLine("Your int: " + myInt);
Console.WriteLine("Parsed int: " + parsedInt);
Console.WriteLine("Character at index " + parsedInt + ": " + myString[parsedInt]);
Console.WriteLine("New message: " + myString.Substring(parsedInt));

string initialSearch;
Console.WriteLine("For which character should I search in your original message?:");
initialSearch = Console.ReadLine();
char charSearch = initialSearch[0];
int index = myString.IndexOf(charSearch);
Console.WriteLine("The first " + charSearch + " in your message is at index " + index);

string firstName;
string lastName;
string fullName;
Console.WriteLine("What is your first name?");
firstName = Console.ReadLine();
Console.WriteLine("What is your first name?");
lastName = Console.ReadLine();
fullName = (firstName + " " + lastName);
Console.WriteLine("Welcome " + fullName + "!");