Console.Write("Enter value A: ");
int vala = int.Parse(Console.ReadLine());


Console.Write("Enter Calculation Type: ");
string calc = (Console.ReadLine());

Console.Write("Enter value B: ");
int valb = int.Parse(Console.ReadLine());


int result;


switch (calc)
{

    case "*":
        result = vala * valb;
        Console.WriteLine("The result is {0}.", result);
        break;

    case "/":
        result = vala / valb;
        Console.WriteLine("The result is {0}.", result);
        break;

    case "+":
        result = vala + valb;
        Console.WriteLine("The result is {0}.", result);
        break;


    case "-":
        result = vala - valb;
        Console.WriteLine("The result is {0}.", result);
        break;

    default:
        Console.WriteLine("Wrong Value!");
        break;

}






Console.ReadKey();
