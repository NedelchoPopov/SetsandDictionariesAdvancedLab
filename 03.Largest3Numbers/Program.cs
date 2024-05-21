/*
10 30 15 20 50 5

20 30

 */

int[] sorted = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .OrderByDescending(n => n)
    .Take(3)
    .ToArray();

Console.WriteLine(string.Join(" ", sorted));
    