/*
9
Europe Bulgaria Sofia
Asia China Beijing
Asia Japan Tokyo
Europe Poland Warsaw
Europe Germany Berlin
Europe Poland Poznan
Europe Bulgaria Plovdiv
Africa Nigeria Abuja
Asia China Shanghai

3
Europe Germany Berlin
Europe Bulgaria Varna
Africa Egypt Cairo

8
Africa Somalia Mogadishu
Asia India Mumbai
Asia India Delhi
Europe France Paris
Asia India Nagpur
Europe Germany Hamburg
Europe Poland Gdansk
Europe Germany Danzig

 */

int rows = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, List<string>>> continentsData = new Dictionary<string, Dictionary<string, List<string>>>();

for (int row = 0; row < rows; row++)
{
    string[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string continent = input[0];
    string countri = input[1];
    string cities = input[2];

    if (!continentsData.ContainsKey(continent))
    {
        continentsData.Add(continent, new Dictionary<string, List<string>>());
    }

    if (!continentsData[continent].ContainsKey(countri))
    {
        continentsData[continent].Add(countri, new List<string>());  
    }

    continentsData[continent][countri].Add(cities);
}

foreach ((string continent, Dictionary<string, List<string>> countries) in continentsData)
{
    Console.WriteLine($"{continent}:");
    foreach ((string countri, List<string> cities) in countries)
    {
        Console.WriteLine($"{countri} -> {string.Join(", ", cities)}");
    }
}