
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);  // väärtus on vahemikus 0-6

switch (weekDay) //väärtus, mida kontrollitakse
{
    case 0:  //case 0 on sama, mis case0: == if(weekDay == 0)
            Console.WriteLine("It is Sunday");
            break;
        case 1:
            Console.WriteLine("It is Monday");
            break;
        case 2:
            Console.WriteLine("It is Tusday");
            ; break;
        case 3:
            Console.WriteLine("It is Wensday");
            ; break;
        case 4:
            Console.WriteLine("It is Thursday");
            ; break;
        case 5:
            Console.WriteLine("It is Friday");
            ; break;
        case 6:
            Console.WriteLine("It is Saturday");
            ; break;
        default:
            Console.WriteLine("Your calander must be faulty");
            break;
}

Console.WriteLine("Have a nice day");

