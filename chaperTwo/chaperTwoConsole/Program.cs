
Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

int number = 13;
Console.WriteLine($"number has been set to: {number}");
number = default;
Console.WriteLine($"number has been reset to its default: {number}");

string[] names; //can reference any size array of string
names = new string[4]; //allocating memory for four string in an array

//storing items at index position
names[0] = "kate";
names[1] = "jack";
names[2] = "Rebecca";
names[3] = "Ruben";

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

string[] names2 = new [] {"Martin", "Alan", "Esteb", "Iliana"};

for (int i = 0; i < names2.Length; i++)
{
    Console.WriteLine(names2[i]);
}