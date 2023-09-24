//Create a program that prints whether a given character is upper-case or lower case.

char a = char.Parse(Console.ReadLine());
if (char.IsLower(a))
{
    Console.WriteLine("lower-case");
}
else { Console.Write("upper-case"); }