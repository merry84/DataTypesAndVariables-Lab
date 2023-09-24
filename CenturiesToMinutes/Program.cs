//Create a program to enter an integer number
//of centuries and convert it to years, days, hours and minutes.
// 1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes

int centuries = int.Parse(Console.ReadLine());
int year = centuries * 100;
int day = (int)(year * 365.2422);//(int) converts double to int
int hour = day * 24;
int minute = hour * 60;
Console.WriteLine($"{centuries} centuries = {year} years = {day} days = {hour} hours = {minute} minutes");