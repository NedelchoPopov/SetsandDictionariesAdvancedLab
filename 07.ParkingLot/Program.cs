/*
IN, CA2844AA
IN, CA1234TA
OUT, CA2844AA
IN, CA9999TT
IN, CA2866HI
OUT, CA1234TA
IN, CA2844AA
OUT, CA2866HI
IN, CA9876HH
IN, CA2822UU
END

IN, CA2844AA
IN, CA1234TA
OUT, CA2844AA
OUT, CA1234TA
END

 */
HashSet<string> carsNumbersInParking = new HashSet<string>();

string input;
while((input = Console.ReadLine()) != "END")
{
    string[] tokens = input
        .Split(", ", StringSplitOptions.RemoveEmptyEntries);

    string command = tokens[0];
    string currentCarNumber = tokens[1];

    if (command == "IN")
    {
        carsNumbersInParking.Add(currentCarNumber);
    }
    else if (command == "OUT")
    {
        carsNumbersInParking.Remove(currentCarNumber);
    }
}
if (carsNumbersInParking.Count > 0)
{
    Console.WriteLine(string.Join(Environment.NewLine, carsNumbersInParking));
}
else
{
    Console.WriteLine($"Parking Lot is Empty");
}
