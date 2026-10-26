
using System.Xml.Serialization;

Console.WriteLine ("CSCI 1210 Lab 06");
Console.WriteLine ("1. The Grade Checker");
Console.WriteLine ("2. The Dice Table");
Console.WriteLine ("3. The Score Report");
Console.WriteLine ("4. All Three");
Console.WriteLine ("5. Quit");

Random rng = new Random(5000);
int choice = 0;

Console.Write("choose 1 through 5 please:");
choice = int.Parse(Console.ReadLine());
Console.WriteLine ("Choose a number from 1 to 5.");


