char Letter;

Console.WriteLine("Enter a letter a to f:");

Letter = Convert.ToChar(Console.ReadLine().ToLower());

if (Letter == 'a')
{
    Console.WriteLine("Suurepärane!");
}
else if (Letter == 'b')
{
    Console.WriteLine("Väga hea!");
}
else if (Letter == 'c')
{
    Console.WriteLine("Hea!");
}
else if (Letter == 'd')
{
    Console.WriteLine("Rahuldav!");
}
else if (Letter == 'e')
{
    Console.WriteLine("Kasin!");
}
else if (Letter == 'f')
{
    Console.WriteLine("Puudulik!");
}
else
{
    Console.WriteLine("Vale väärtus!");
}