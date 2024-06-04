// See https://aka.ms/new-console-template for more information
double num1 = 0;
double num2 = 0;
double sum = 0;

Console.WriteLine("Would you like to add, divide or subtract? Enter 'add','subtract', or 'divide', case sensitive.");
string choice = Console.ReadLine();

switch (choice)
{
    case "add":
        num1 = GetValidInteger("Enter the first number: ");
        num2 = GetValidInteger("Enter the second number: ");
        sum = Add(num1, num2);
        break;
    case "subtract":
        num1 = GetValidInteger("Enter the first number: ");
        num2 = GetValidInteger("Enter the second number: ");
        sum = Subtract(num1, num2);
        break;
    case "divide":
        num1 = GetValidInteger("Enter the first number: ");
        num2 = GetValidInteger("Enter the second number: ");
        sum = Divide(num1, num2);
        break;
    
    default:
        Console.WriteLine("Invalid selection.");
        break;
}

Console.WriteLine($"The answer is {sum}.");

double Divide(double num1, double num2)
{
    if ((num1 != 0) && (num2 != 0))
    {
        return num1 / num2;
    }
    
    Console.WriteLine("Error: Cannot divide by zero.");
    return 0;
}

double Subtract(double num1, double num2)
{
    return num1 - num2;
}

double Add(double num1, double num2)
{
    return num1 + num2;
}

double GetValidInteger(string prompt)
{
    double result;
    
    Console.WriteLine(prompt);

    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out result))
        {
            return result;
        }

        Console.WriteLine("Invalid input. Please enter a valid double.");
    }
}