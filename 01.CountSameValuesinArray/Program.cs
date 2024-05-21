/*
-2.5 4 3 -2.5 -5.5 4 3 3 -2.5 3

2 4 4 5 5 2 3 3 4 4 3 3 4 3 5 3 2 5 4 3

*/

double[] values = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToArray();

Dictionary<double, int> counts = new Dictionary<double, int>();

foreach (double value in values)
{
    if (!counts.ContainsKey(value))
    {
        counts.Add(value, 1);
        continue;
    }

    counts[value]++;

}

foreach (KeyValuePair<double, int> count in counts)
{
    Console.WriteLine($"{count.Key} - {count.Value} times");
}