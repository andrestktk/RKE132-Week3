char Letter;

Console.WriteLine("Enter a letter a to f:");

Letter = Convert.ToChar(Console.ReadLine().ToLower());

switch (Letter)
{   case 'a':
        Console.WriteLine("Suurepärane!");
        break;
    case 'b':
        Console.WriteLine("Väga hea!");
        break;
    case 'c':
        Console.WriteLine("Rahuldav");
        ; break;
    case 'd':
        Console.WriteLine("Hea!");
        ; break;
    case 'e':
        Console.WriteLine("Puudulik");
        ; break;
    case 'f':
        Console.WriteLine("Kasin");
        ; break;
    default:
        Console.WriteLine("Vale väärtus!");
        break;


}