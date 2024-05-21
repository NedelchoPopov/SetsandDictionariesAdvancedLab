/*
8
John
Alex
John
Sam
Alex
Alice
Peter
Alex

7
Lyle
Bruce
Alice
Easton
Shawn
Alice
Shawn
Peter

6
Roki
Roki
Roki
Roki
Roki
Roki

 */

int rows = int.Parse(Console.ReadLine());

HashSet<string> uniqueNames = new HashSet<string>();

for (int row = 0; row < rows; row++)
{
    uniqueNames.Add(Console.ReadLine());
}

Console.WriteLine(string.Join(Environment.NewLine, uniqueNames));