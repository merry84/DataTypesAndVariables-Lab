//You are given a working code that is a solution to Problem 5. Special Numbers.
//However, the variables are improperly named,
//declared before they are needed and some of them are used for multiple purposes.
//Without using your previous solution, modify the code, so that it is easy to read and understand.
//•	Reduce the span of the variables by declaring them at the moment they receive a value, not before.
//•	Rename your variables to represent their real purpose (example: "toe" should become isSpecialNum, etc.).
//•	Search for variables that have multiple purposes.If you find any, introduce a new variable.
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    double sumOfn = 0;
    int digit = i;
    while (digit > 0)
    {
        sumOfn += digit % 10;
        digit = digit / 10;
    }
    bool isSpecial = (sumOfn == 5) || (sumOfn == 7) || (sumOfn == 11);
    Console.WriteLine($"{i} -> {isSpecial}");
}