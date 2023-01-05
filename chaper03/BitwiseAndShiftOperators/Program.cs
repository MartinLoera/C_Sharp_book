using static System.Console;

int a = 10;
int b = 6;

WriteLine($"a = {a}");
WriteLine($"b = {b}");
WriteLine($"a & b = {a & b}"); // 2-bit column only   
WriteLine($"a | b = {a | b}");
WriteLine($"a ^ b = {a ^ b}");
WriteLine($"a << 3 = {a << 3}"); // 01010000 left-shift a by three bit columns 

static string ToBinaryString(int value){
    return Convert.ToString(value, toBase: 2).PadLeft(8, '0');
}


int? xyz = 100;
WriteLine($"a =     {ToBinaryString(a)}");
WriteLine($"b =     {ToBinaryString(b)}");
WriteLine($"a & b = {ToBinaryString(a & b)}");
WriteLine($"a | b = {ToBinaryString(a | b)}");
WriteLine($"a ^ b = {ToBinaryString(a ^ b)}");


