// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
/*
Console.WriteLine("Welcome to C#, Utsab!");


//Reference Type

//Explicitely Type variable
string myName = "Utsab";

//Defining or setting up a variable 
string petsName;

//Initialize variable
petsName = "Daisy";
//assign a new value 
petsName = "Barkey";

//String Interpolation
Console.WriteLine($"My pet is {petsName}");


//Value type 
int myAge = 22;

double pi = 3.14;
byte Age = 23;

short LinkedConnections = 32234;

long myPhoneNumber = 018832132321;

Console.WriteLine(myPhoneNumber);

Console.WriteLine(myName);
Console.WriteLine(myAge);


int myNumber = 0;
string userInput = Console.ReadLine();
//myNumber = int.parse(Console.ReadLine());
myNumber = int.Parse(userInput);

Console.WriteLine("You entered " +  myNumber);

//

*/
/*
//Implicit Conversion
int myInt = 0;
//int myInt2 = 0;
double myDouble1 = myInt;

long myLong = myInt;
myLong = 1234567891223213124;

float myFloat = 312.231f;

double myDouble = myFloat;


//Explicit Conversion
//int myInt3=  (int) myLong;

int myInt3;
double myDouble2 = 13.54;
myInt3 = (int) myDouble2;

float myFloat2 = 312.223f;

double myDouble3 = 13.2123313131;
myFloat2 = (float)myDouble3;


// Int can be converted to double but double cant be converted 
//double sum = myInt + myInt2;
*/


//Conversion Helpers Parse and Convert
string numberString = "1234";
int result = int.Parse(numberString);

string myBoolString = "true";
bool myBool = Convert.ToBoolean(myBoolString);
Console.WriteLine("myBool is " + myBool);

//Implcitely Type variable
var myFavGenre = "RPGs";
var myFavNum = 23;

var urFavNum = 29;

var OurNumCombined = myFavNum + urFavNum;


int num = 10;
double price = 19.95;
string name ="Frank";

// Interpolation
Console.WriteLine($"Number is {num}");

// String concatination
Console.WriteLine("The Number is " + num);

// String formatting
Console.WriteLine("The Number is {0} and the price is {1} and the name is {2}", num, price, name) ;


string s1 = "this is a \"string\" with \na backslash\\ and colon:";
Console.WriteLine(s1) ;
