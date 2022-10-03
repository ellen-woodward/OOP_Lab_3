Console.Write("Enter stock-on-hand : ");
int stock = int.Parse(Console.ReadLine());

Console.Write("Enter sales : ");
int sales = int.Parse(Console.ReadLine());

if (UpdateStock(ref stock, sales))
    Console.WriteLine($"Stock updated, stock left is {stock}");
else
    Console.WriteLine("Insufficiant stock");

bool UpdateStock(ref int stock, int sales)
{
    bool isStockUpdated = false;

    if (stock >= sales)
    {
        isStockUpdated = true;
        stock -= sales;
    }

    return isStockUpdated;
}


