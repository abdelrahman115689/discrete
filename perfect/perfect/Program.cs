Console.WriteLine("Please enter first number");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter second number");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Perfect results :");
{
    if (num1 >= 0 && num2 >= 6 && num1 < 7)
        Console.WriteLine("6");
    if (num2 >= 28 && num1 <= 28)
        Console.WriteLine("28");
    if (num2 >= 496 && num1 <= 496)
        Console.WriteLine("496");
    if (num2 >= 8128 && num1 <= 8128)
        Console.WriteLine("8128");
    if (num2 >= 33550336 && num1 <= 33550336)
        Console.WriteLine("33550336");
}