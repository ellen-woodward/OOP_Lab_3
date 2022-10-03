int[,] filmReviews = new int[,]
{
    { 3, 4, 5 },
    { 1, 2, 1 },
    { 5, 4, 2 }
};

double[] averages = new double[3];

for (int i = 0; i < filmReviews.GetLength(0); i++)
{
    int total = 0;

    for (int j = 0; j < filmReviews.GetLength(1); j++)
    {
        total += filmReviews[i, j];
    }

    averages[i] = (double)total/3;
}

foreach (double average in averages)
{
    Console.WriteLine($"{average:f2}");
}