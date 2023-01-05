using static System.Console;
static bool DoStuff(){
    WriteLine("I'm doing some stuff");
    return true;
}

bool a = true;
bool b = false;

WriteLine();
WriteLine($"a & DoStuff() = {a & DoStuff()}");
WriteLine($"b & DoStuff() = {b & DoStuff()}");
WriteLine();
WriteLine($"a & DoStuff() = {a && DoStuff()}");
WriteLine($"b & DoStuff() = {b && DoStuff()}");
WriteLine();