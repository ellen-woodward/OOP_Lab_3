int[] zeros = new int[5];

Zero(zeros);

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(zeros[i]);
}

void Zero(int[] zeros)
{
    for (int i = 0; i < zeros.Length; i++)
    {
        zeros[i] = 0;
    }
}