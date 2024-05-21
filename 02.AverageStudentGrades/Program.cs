/*
7
John 5.20
Maria 5.50
John 3.20
Maria 2.50
Sam 2.00
Maria 3.46
Sam 3.00

4
Vlad 4.50
Peter 3.00
Vlad 5.00
Peter 3.66

5
George 6.00
George 5.50
George 6.00
John 4.40
Peter 3.30

 */

using System.Diagnostics.Metrics;

int rows = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> keyValuePairs = new Dictionary<string, List<decimal>>();

for (int row = 0; row < rows; row++)
{
    string[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string student = input[0];
    decimal grade = decimal.Parse(input[1]);

    if (!keyValuePairs.ContainsKey(student))
    {
        keyValuePairs.Add(student, new List<decimal>());
    }

    keyValuePairs[student].Add(grade);
}

foreach ((string student, List<decimal> grades) in keyValuePairs)
{
    Console.Write($"{student} -> ");

    foreach (decimal grade in grades)
    {

        Console.Write($"{grade:f2} ");
    }

    Console.WriteLine($"(avg: {grades.Average():f2})");

}
