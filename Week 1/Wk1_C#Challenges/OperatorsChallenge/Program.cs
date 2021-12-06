// See https://aka.ms/new-console-template for more information

int a = 5;
int b = 9;
int c = 1;
int d = 11;
int e = 6;
int f = 11;
bool mainBool = true;
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = " + c);

Console.WriteLine("##### Sum and Increment #####");

int incrementValue = a + b;
Console.WriteLine(a + " + " + b + " = " + incrementValue);
Console.WriteLine("c = " + c);
c++;
Console.WriteLine("c++ = " + c);

Console.WriteLine("##### Difference and Decrement #####");

int decrementValue = a - b;
Console.WriteLine(a + " - " + b + " = " + decrementValue);
Console.WriteLine("c = " + c);
c--;
Console.WriteLine("c-- = " + c);

Console.WriteLine("##### Not #####");

Console.WriteLine("Original = " + mainBool);
mainBool =! true;
Console.WriteLine("1st change = " + mainBool);
mainBool = !mainBool;
Console.WriteLine("2nd change = " + mainBool);

Console.WriteLine("##### Negate #####");

Console.WriteLine("Positive value = " + incrementValue);
int negatePos = System.Math.Abs(incrementValue);
Console.WriteLine("Changed value = " + negatePos);
Console.WriteLine("Negative value = " + decrementValue);
int negateNeg = System.Math.Abs(decrementValue);
Console.WriteLine("Changed value = " + negateNeg);

Console.WriteLine("##### Product #####");

int productVal = d * e;
Console.WriteLine(d + " x " + e + " = " + productVal);

Console.WriteLine("##### Quotient #####");

int quotientVal = d / e;
Console.WriteLine(d + " / " + e + " = " + quotientVal);

Console.WriteLine("##### Remainder #####");

int remainderVal = d % e;
Console.WriteLine(d + " % " + e + " = " + remainderVal);

Console.WriteLine("##### And #####");

mainBool = (a == 0 && a > c);
Console.WriteLine("Is a = 0, and a > c? " + mainBool);
mainBool = (a == 5 && a > c);
Console.WriteLine("Is a = 5, and a > c? " + mainBool);

Console.WriteLine("##### Or #####");

mainBool = (a == 0 || a < c);
Console.WriteLine("Is a = 0, and a > c? " + mainBool);
mainBool = (a == 0 || a > c);
Console.WriteLine("Is a = 5, and a > c? " + mainBool);