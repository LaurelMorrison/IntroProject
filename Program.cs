using System;

Console.Write("First Name >");
string firstName = Console.ReadLine();

Console.Write("Last Name >");
string lastName = Console.ReadLine();

string reverse = "";
string fullName = firstName + " " + lastName;

for (int i = fullName.Length - 1; i >= 0; i--)
{
    reverse += fullName[i];
}

Console.WriteLine(reverse);

// for (Array reverseName = lastName().reverse() + " " + firstName().reverse()) ;
// {
//     Console.WriteLine(reverseName);
// }

// string initials = firstName[0] + " " + lastName[0];
// Console.WriteLine(initials);

// for (int num = 10; num >= 1; num--)
// {
//     Console.WriteLine(num);
// }

/*
System.Console.Write("Who would you like to say hello to? ");

string name = System.Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
{
    System.Console.WriteLine("Fine, don't say 'hello'!");
}
else
{
    System.Console.WriteLine($"Hello, {name}!");
}
*/

