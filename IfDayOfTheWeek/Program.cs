
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

Console.WriteLine(weekDay);

if (weekDay == 0)
{
    Console.WriteLine("It is Sunday!");
}
else if (weekDay == 1)
{
    Console.WriteLine("It is Monday!");
}
else if (weekDay == 2)
{
    Console.WriteLine("It is Tusday!");
}
else if (weekDay == 3)
{
    Console.WriteLine("It is Wensday!");
}
else if (weekDay == 4)
{
    Console.WriteLine("It is Thursday!");
}
else if (weekDay == 5)
{
    Console.WriteLine("It is Friday!");
}
else
{
    Console.WriteLine("It is Saturday!");
}

Console.WriteLine("Have a nice day!");