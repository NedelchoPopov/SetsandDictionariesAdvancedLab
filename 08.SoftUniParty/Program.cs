/*
7IK9Yo0h
9NoBUajQ
Ce8vwPmE
SVQXQCbc
tSzE5t0p
PARTY
9NoBUajQ
Ce8vwPmE
SVQXQCbc
END

m8rfQBvl
fc1oZCE0
UgffRkOn
7ugX7bm0
9CQBGUeJ
2FQZT3uC
dziNz78I
mdSGyQCJ
LjcVpmDL
fPXNHpm1
HTTbwRmM
B5yTkMQi
8N0FThqG
xys2FYzn
MDzcM9ZK
PARTY
2FQZT3uC
dziNz78I
mdSGyQCJ
LjcVpmDL
fPXNHpm1
HTTbwRmM
B5yTkMQi
8N0FThqG
m8rfQBvl
fc1oZCE0
UgffRkOn
7ugX7bm0
9CQBGUeJ
END

 */

HashSet<string> vips = new HashSet<string>();
HashSet<string> guests = new HashSet<string>();
string command;
while ((command = Console.ReadLine()) != "PARTY")
{
    if (Char.IsDigit(command[0]))
    {
        vips.Add(command);
    }
    else
    {
        guests.Add(command);
    }
    
}

while ((command = Console.ReadLine()) != "END")
{
    if (Char.IsDigit(command[0]))
    {
        vips.Remove(command);
    }
    else
    {
        guests.Remove(command);
    }
    
}

Console.WriteLine(guests.Count + vips.Count);
foreach (var item in vips)
{
    Console.WriteLine(item);
}
foreach (var item in guests)
{
    Console.WriteLine(item);
}
