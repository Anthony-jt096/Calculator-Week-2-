bool continueCalculating = true;

while (continueCalculating)
{
    Console.WriteLine("enter the first number");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the second number");
    double num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("enter the Operator (+, -, *, /");
    Char op = Console.ReadLine()[0];

    Double result = 0;
    bool validOperator = true;

    switch (op)
    {
        case '+':
            result = num1 + num2;
            break;
        case '-':
            result = num1 - num2;
            break;
        case '*':
            result = num1 * num2;
            break;
        case '/':
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("can't devide by 0.");
                validOperator = false;
            }
            break;
        default:
            Console.WriteLine("Invalid operator.");
            validOperator = false;
            break;

    }

    if (validOperator)
    {
        Console.WriteLine($"Result: {result}");
    }

    {
        Console.WriteLine("Sovle another equaiton? (y/n)");
        continueCalculating = Console.ReadLine().ToLower() == "y";
    }
}