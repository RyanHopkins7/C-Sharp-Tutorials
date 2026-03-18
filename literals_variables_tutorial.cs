// Source: https://learn.microsoft.com/en-us/training/modules/csharp-literals-variables/

// A literal is a hard-coded value.
Console.WriteLine('b'); // Chatacter literal
// Console.WriteLine('Hello World!'); // Doesn't compile
Console.WriteLine(123); // Integer literal
Console.WriteLine(0.25F); // Floating-point literal
Console.WriteLine(2.625); // Double literal
Console.WriteLine(12.39816m); // Decimal literal
Console.WriteLine(true); // Boolean literal
Console.WriteLine(false); // Boolean literal

// Same output, different data types
// Output: 123
Console.WriteLine("123");
// Output: 123
Console.WriteLine(123);

// Output: True
Console.WriteLine("True");
// Output: True
Console.WriteLine(true);

// A variable is a container for storing a type of value.
// Variable names can contain alphanumeric characters and underscores
// Variable names must begin with a letter or an underscore
// Variable names are case-sensitive
// Variable names cannot be a reserved keyword

// Variable names should use camelCase
// Variable names should begin with a lowercase letter
// Variable names should be descriptive of the value they hold
// Variable names should generally not use abbreviations
// Variable names should not include the data type of the variable

// Example:
string firstName;
// Console.WriteLine(firstName); // Doesn't compile because firstName is uninitialized
firstName = "Bob";
// "Bob" = firstName; // Doesn't compile
Console.WriteLine(firstName);
// Reassigning a variable
firstName = "Liem";
Console.WriteLine(firstName);

firstName = "Bob";
Console.Write(firstName + ' ');

string lastName = "Dylan";
Console.WriteLine(lastName);

// The C# compiler can infer the data type of a variable from the value assigned to it
var message = "Hello World!";
Console.WriteLine(message);

// message = 10.703m; // Doesn't compile because message is inferred to be a string

// var message2; // Doesn't compile because the compiler cannot infer the data type of message2 without an initial value

// Challenge:
var name = "Bob";
var num = 3;
var d = 34.4;

Console.Write($"Hello, {name}! You have {num} messages in your inbox. The temperature is {d} celsius.\n");
