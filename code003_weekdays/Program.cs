int Days = new int ();

Console.WriteLine ("type a number of weekday and i write if it's day off");
Days = Convert.ToInt32(Console.ReadLine());

switch (Days)
{
    case 1:
    {
        Console.WriteLine("No");
        break;
    }
    case 2:
    {
        Console.WriteLine("No");
        break;
    }
        case 3:
    {
        Console.WriteLine("No");
        break;
    }
        case 4:
    {
        Console.WriteLine("No");
        break;
    }    
        case 5:
    {
        Console.WriteLine("No");
        break;
    }
        case 6:
    {
        Console.WriteLine("YES!");
        break;
    }
        case 7:
    {
        Console.WriteLine("still yes");
        break;
    }
}

