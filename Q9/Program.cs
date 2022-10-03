string[] data = new string[2];
string[] storeIDs = new string[5];
int[] sales = new int[5];
string[] performances = new string[5];

int count = 0;

ReadandSplitFiles(data, storeIDs, sales);

CalculatePerformance(sales, performances);

int total = CalculateTotalSales(sales);

double average = total / count;

PrintReport(storeIDs, sales, performances, total, average);


void ReadandSplitFiles(string[] data, string[] storeIDs, int[] sales)
{
    string filePath = "sales.txt";

    string[] fileContents = File.ReadAllLines(filePath);

    foreach (string line in fileContents)
    {
        data = line.Split(',');
        storeIDs[count] = data[0];
        sales[count] = int.Parse(data[1]);
        count++;
    }
}

void CalculatePerformance(int[] sales, string[] performances)
{
    for (int i = 0; i < sales.Length; i++)
    {
        if (sales[i] < 1000)
            performances[i] = "Needs attention";
        else if (sales[i] < 2000)
            performances[i] = "Moderate";
        else
            performances[i] = "Very good";
    }
}

int CalculateTotalSales(int[] sales)
{
    int total = 0;

    foreach (int sale in sales)
    {
        total += sale;
    }

    return total;
}

void PrintReport(string[] storeIDs, int[] sales, string[] performances, int total, double average)
{
    Console.WriteLine("Sales Report");
    Console.WriteLine("\nID\tSales\tPerformances");
    
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{storeIDs[i]}\t{sales[i]}\t{performances[i]}");
    }

    Console.WriteLine($"\nTotal sales = {total}");
    Console.WriteLine($"Average sales = {average}");
}
