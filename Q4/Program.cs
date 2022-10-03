Console.Write("Enter first number : ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("\nEnter second number : ");
int n2 = int.Parse(Console.ReadLine());

Console.Write($"\nSum of numbers : {Sum(n1, n2)} ");

int Sum(int n1, int n2)
{
    int first = 0, second = 0, sum = 0;

    if (n1 < n2)
    {
        first = n1;
        second = n2;
    }
    else if (n2 < n1)
    {
        first = n2;
        second = n1;
    }
    else
        return 0;

    for (int i = first; i <= second; i++)
    {
        if (i % 2 == 0)
            sum += i;
    }
    return sum;
}
