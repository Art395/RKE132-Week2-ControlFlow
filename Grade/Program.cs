char userGrade;
Console.WriteLine("Enter your grade:");
userGrade = Convert.ToChar(Console.ReadLine());

switch (userGrade)
{
    case '0':
        Console.WriteLine("Incomplete.");
        break;
    case '1':
        Console.WriteLine("Meager.");
        break;
    case '2':
        Console.WriteLine("Satisfying.");
        break;
    case '3':
        Console.WriteLine("Good!");
        break;
    case '4':
        Console.WriteLine("Very good!");
        break;
    case '5':
        Console.WriteLine("Excellent!");
        break;
        default:
        Console.WriteLine("Wrong value!");
        break;
}

