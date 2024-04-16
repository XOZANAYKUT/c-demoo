// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, hozan!");
/*
var number = 20;
// var productName = "Samsung S23";
var product_name = "Samsung S23";

// Cannot contain spaces.
// Cannot start with a number.
var number2 = 30;
var number3 = 50;

var price = 1000.25;
var Price = 1000.25;

// Case sensitive.

var isOnSale = "yes";
var studentId = "1025";

Console.WriteLine(number);
Console.WriteLine(product_name);
Console.WriteLine(number2);
Console.WriteLine(number3);
Console.WriteLine(price);
Console.WriteLine(Price);
Console.WriteLine(isOnSale);
Console.WriteLine(studentId);*/

/*
    C# Data Types

    Value Types: 
        Integral Types:     byte, short, int, long
        Floating Point Types: float, double, decimal
        Other Data Types:   char, boolean, struct

    Reference Types:
        String, Class, Array, Interface

*/
/*
int number = 200;
decimal taxRate = 1.18m;
char gender = 'F';
string gender2 = "Female";
string productName = "Samsung S23";
var isSold = false;*/

/*
    Why Do We Need Data Type Conversion?
*/

/*
Console.Write("1.number: ");
var number1 = Console.ReadLine();

Console.Write("2.number: ");
var number2 = Console.ReadLine();

var sum = number1 + number2; // 1020 // hozanaykut

Console.Write(sum);*/ 

/*
    Data Type Conversion
    // implicit casting => implicit type conversion
    // explicit casting => explicit type conversion
*/
/*
int a = 10;
long b = a;

long d = 20;
int e = (int)d;

double f = 20.5;
float g = (float)f;

double h = 10.5;
int i = (int)h;

Console.WriteLine(i);

int x = 10;
string z = x.ToString();


Console.Write("1.number: ");
var number1 = Convert.ToInt32(Console.ReadLine());     // string to int

Console.Write("2.number: ");
var number2 = Convert.ToInt32(Console.ReadLine());

var sum = number1 + number2; 

Console.WriteLine(sum);
*/

/*Nullable Types*/

/*int? salary = default;
bool? isActive = null;

Console.WriteLine(salary.HasValue);
Console.WriteLine(salary.GetValueOrDefault());
Console.WriteLine(isActive.GetValueOrDefault());


/*
    Strings: String arrays - reference => null
*/

/*Console.Write("Name: ");
var name = Console.ReadLine();

Console.Write("Surname: ");
var surname = Console.ReadLine();

Console.Write("Age: ");
var age = Console.ReadLine();

// string concat
// string message = name +" "+ surname + " is a person who is "+ age + " years old.";

// string interpolation
string message = $"{name} {surname} is a person who is {age} years old.";

Console.WriteLine(message);

/*
    String Methods
*/

/*string message = "The person named Ahmet Turan is 20 years old.";

// var result = message.Length;
// var result = message.ToLower();
// var result = message.ToUpper();
// var result = message.Trim();
// var result = message.Split(" ")[0];
// var result = message[0];
// var result = message.StartsWith("B");
// var result = message.EndsWith(".");
// var result = message.Contains("Ali");
// var result = message.IndexOf("abc");
var result = message.Substring(6, 5);

Console.WriteLine(result);
/*
    String Applications
*/

/*string courseName = ".NET 7 Programming Language with C#";

// 1- How many characters does it have?
// 2- Make all lowercase.
// 3- Does it start with '.'?
// 4- Where is the 'C#' knowledge?
// 5- Does it contain the string 'C#'?
// 6- Replace the word 'Language' with 'Lessons'.

var characterCount = courseName.Length;
Console.WriteLine(characterCount); // 30

var lowercase = courseName.ToLower();
Console.WriteLine(lowercase);

var startsWithDot = courseName.StartsWith('.');
Console.WriteLine("String starts with '.': " + startsWithDot);

var position = courseName.IndexOf("C#");
Console.WriteLine("Position " + position);

var containsCSharp = courseName.Contains("C#");
Console.WriteLine("Contains C#: " + containsCSharp);

var updatedString = courseName.Replace("Language", "Lessons");
Console.WriteLine(updatedString);

/*
    DateTime
*/

// Get the current DateTime
/*var now = DateTime.Now;

// Print current DateTime and its components
Console.WriteLine(now);
Console.WriteLine(now.Year);
Console.WriteLine(now.Month);
Console.WriteLine(now.Day);
Console.WriteLine(now.DayOfWeek);
Console.WriteLine(now.Hour);
Console.WriteLine(now.Minute);
Console.WriteLine(now.Second);

// Create a new DateTime object with specified values
DateTime dt = new DateTime(2022, 6, 10, 14, 30, 45);

// Add 1 year to the DateTime object
DateTime dt2 = dt.AddYears(1);

// Add 2 hours to the DateTime object
DateTime dt3 = dt.AddHours(2);

// Print the year of dt2 and hour of dt3
Console.WriteLine(dt2.Year);
Console.WriteLine(dt3.Hour);

// Calculate the difference between now and dt
TimeSpan difference = now - dt;

// Print the total days and total minutes difference
Console.WriteLine(difference.TotalDays);
Console.WriteLine(difference.TotalMinutes);
