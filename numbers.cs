using System;
using System.Collections.Generic;
using System.IO;
class Program
{
static void Main()
{
bool currentlist = File.Exists("numbers.txt");
if(currentlist == true)
{
Console.WriteLine("You have an existing list of numbers.");
string[] existingNumbers = File.ReadAllLines("numbers.txt");
Console.WriteLine("They are:\n");
foreach(string show in existingNumbers)
{
Console.WriteLine(show);
}
done();
}
else
{
var allnums = new List<int>();
int number=0;
allnums = new List<int>();
Console.WriteLine("The goal of this program is to let you enter different numbers and it can save them for you.");
Console.WriteLine("Press any key when you're ready to get started.");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Just enter one number at a time, then press enter. When you're done typing, type done and press enter.\nPlease proceed.");
while(true)
{
string numbers = Console.ReadLine().ToLower();
if(numbers=="done")
{
Console.WriteLine("You have " + allnums.Count + " numbers in your list.");
Console.WriteLine("To recap, they are:");
foreach(int displayednumber in allnums)
{
Console.WriteLine(displayednumber);
}
Console.WriteLine("Now writing to file.");
using (StreamWriter yournumbers=new StreamWriter("numbers.txt"))
{
foreach(int numbers2 in allnums)
{
yournumbers.WriteLine(numbers2);
}
}
done();
break;
}
else
{
number=int.Parse(numbers);
if (number > 0)
{
allnums.Add(number);
if(number>99)
{
Console.Beep(600, 3000);
Console.WriteLine("That number was at least 100!");
}
}
else if(number<=0)
{
Console.WriteLine("The number should be greater than 0, please try again.");
}
}
}
}
}
static void done()
{
Console.WriteLine("That's it! Press any key to exit.");
Console.ReadKey();
Console.Clear();
}
}
