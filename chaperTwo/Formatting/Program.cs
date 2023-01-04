using static System.Console;

// int numberOfApples = 12;
// decimal pricePerApple = 0.35M;

// .WriteLine(
//     format: "{0} apples costs {1:C}",
//     arg0: numberOfApples,
//     arg1: pricePerApple * numberOfApples
// );

// string formatted = string.Format(
//     format: "{0} apples costs {1:C}",
//     arg0: numberOfApples,
//     arg1: pricePerApple * numberOfApples
// );

// uint edad = 24;
// string nombre = "Martin";

// .WriteLine("Hola soy {0} y tengo {1} años", nombre, edad);


// WriteLine("Type your firts name and press ENTER: ");
// string? firstName = ReadLine();

// WriteLine("Type your age and press ENTER: ");
// string? age = ReadLine();

// WriteLine($"Hello {firstName}, you look good for {age}");

WriteLine("Pulsa una tecla o combinacion:");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key {0}, char: {1}, modifiers: {2}", key.Key, key.KeyChar, key.Modifiers);


