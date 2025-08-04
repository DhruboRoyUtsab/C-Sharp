// See https://aka.ms/new-console-template for more information

double myNumber  = 0.0;
double myNumber2 = 0.0;
Console.WriteLine("Write a Number: ");

string userInput = Console.ReadLine();

myNumber = double.Parse(userInput);


Console.WriteLine("Enter another Number: ");
userInput = Console.ReadLine();
myNumber2 = double.Parse(userInput);



double Addition = myNumber + myNumber2;
//Console.WriteLine("Addition: " + Addition);

//Set precision
Addition = Math.Round(Addition, 3); 

//String concatination
//Console.WriteLine("The result of " + myNumber + " and " + myNumber2 + " is: " + Addition);

//String Interpolation
Console.WriteLine($"The result of {myNumber} and {myNumber2} is {Addition}");

double Subs = myNumber - myNumber2;
Console.WriteLine("Substraction: " + Subs);

double multiple = myNumber * myNumber2;
Console.WriteLine("Multipication: "+  multiple);

double Div = myNumber / myNumber2;
Div = Math.Round(Div, 3);
Console.WriteLine("Division: " + Div);




