// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter A The First Side");
int Sideone = int.Parse(Console.ReadLine());
Console.WriteLine("Side one is "+ Sideone);
Console.WriteLine("Enter A The Second Side");
int Sidetwo = int.Parse(Console.ReadLine());
Console.WriteLine("Side Two is "+ Sidetwo);
if (Sideone == Sidetwo)
    Console.WriteLine("The Shape is Square");
else Console.WriteLine("The Shape Is Rectangle");

