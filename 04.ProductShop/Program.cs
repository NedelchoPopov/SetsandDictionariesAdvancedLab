/*
lidl, juice, 2.30
fantastico, apple, 1.20
kaufland, banana, 1.10
fantastico, grape, 2.20
Revision

tmarket, peanuts, 2.20
GoGrill, meatballs, 3.30
GoGrill, HotDog, 1.40
tmarket, sweets, 2.20
Revision

 */



SortedDictionary<string, Dictionary<string, double>> productsPrices = new SortedDictionary<string, Dictionary<string, double>>();

string input;
while ((input = Console.ReadLine()) != "Revision")
{
    string[] tokens = input
        .Split(", ", StringSplitOptions.RemoveEmptyEntries);

    string shop = tokens[0];
    string product = tokens[1];
    double price = double.Parse(tokens[2]);

    if (!productsPrices.ContainsKey(shop))
    {
        productsPrices.Add(shop, new Dictionary<string, double>());
    }
    productsPrices[shop].Add(product, price);


}
var orderedShops = productsPrices.OrderBy(s => s.Key)
 .ToDictionary(x => x.Key, x => x.Value);

foreach ((string shop, Dictionary<string, double> products) in orderedShops)
{
    Console.WriteLine($"{shop}->");

    foreach ((string product, double price) in products)
    {
        Console.WriteLine($"Product: {product}, Price: {price}");
    }

}