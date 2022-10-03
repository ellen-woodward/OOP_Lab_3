Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

Console.WriteLine(IsCorrectAge(age));

bool IsCorrectAge(int age)
{
    return (age >= 18 && age <= 21);
}
