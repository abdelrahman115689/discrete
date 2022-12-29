Console.WriteLine("Please enter first number");
int prime = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter other number");
int prime1 = int.Parse(Console.ReadLine());

Console.WriteLine("Prime result is :");

int h = 0;

for (int i = prime; i <= prime1; i++)
{
    for (int w = 1; w <= i; w++)
    {
        if (i % w == 0)
        {
            h++;
        }
    }
    if (h == 2)
    {
        Console.WriteLine(i);
    }
    h = 0;
}
