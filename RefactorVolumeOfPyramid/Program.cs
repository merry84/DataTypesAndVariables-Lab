//You are given a working code that finds the volume of a pyramid. However,
//you should consider that the variables exceed their optimum span and have improper naming.
//Also, search for variables that have multiple purposes.
//Hints
//•	Reduce the span of the variables by declaring them at the moment they receive a value, not before.
//•	Rename your variables to represent their real purpose (example: "dul" should become length, etc.).
//•	Search for variables that have multiple purposes.If you find any, introduce a new variable.


double length = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());
double heigth = double.Parse(Console.ReadLine());
double volume = (length * width * heigth) / 3;

Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:f2}");
//double dul, sh, V = 0;
//Console.WriteLine("Length: ");
//dul = double.Parse(Console.ReadLine());
//Console.WriteLine("Width: ");
//sh = double.Parse(Console.ReadLine());
//Console.WriteLine("Heigth: ");
//V = double.Parse(Console.ReadLine());
//V = (dul + sh + V) / 3;
//Console.WriteLine($"Pyramid Volume: {V:f2}");

