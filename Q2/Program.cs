Console.Write("Enter product : ");
string product = Console.ReadLine().ToLower();

Console.WriteLine($"Cost of {product} is {CostofProduct(product)}"); 

double CostofProduct(string product)
{
    double cost = 0;

    switch (product)
    {
        case "jeans":
            cost = 67.99;
            break;

        case "jacket":
            cost = 68.99;
            break;

        case "boots":
            cost = 34.99;
            break;

        case "scarves":
        case "belts":
        case "socks":
            cost = 10;
            break;

        default:
            cost = -999;
            break;
    }

    return cost;
}
