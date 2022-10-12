// Битовые операции
// 0000 0000 - 0
// 0000 0001 - 1
// 0000 0010 - 2
// 1111 1111 - 255

// & - логическое умножение (И)
// | - логическое сложение (ИЛИ)

/*
int b = 0b00000101; // 1
int c = 0b00000100; // 2
Console.WriteLine(b & c);//0b00000100
Console.WriteLine(b | c);//0b00000111

// ^ - исключающее сложение XOR
Console.WriteLine(b ^ c);//0b00000011
Console.WriteLine(~b);   //0b11111010;
// ~ - инверсия (!)

// << - битовый сдвиг влево
// >> - сдвиг вправо
Console.WriteLine(c << 2);

// double float decimal
// 1 - знак
// n бит - порядок
// m бит - мантисса

// человек, пол (м/ж), работа (да/нет),
// есть борода (да/нет)
byte status = 0;
//status |= 0b00000001; // мужской пол
status |= 0b00000010; // работа
status |= 0b00000100; // борода
                      //status 0b00000111
Console.WriteLine(status);
if ((status & 0b00000001) != 0)
    Console.WriteLine("Мужской пол");
else
    Console.WriteLine("Женский пол");

if ((status & 0b00000010) == 0b00000010)
    Console.WriteLine("Есть работа");
else
    Console.WriteLine("Нет работы");

if ((status & 0b00000100) != 0)
    Console.WriteLine("Есть борода");
else
    Console.WriteLine("Бороды нет");
*/
class Program
{
    static void Main()
    {
        int a = 10;
        int b = 50;
        swap(ref a, ref b);
        Console.WriteLine($"a = {a} b = {b}");
        Console.WriteLine(IsChetnoe(2));
        Console.WriteLine(IsChetnoe(5));
        int rgb = GetRGB(0, 255, 0);
        Console.WriteLine(rgb);
        GetColorFromRGB(rgb);
    }

    static void swap(ref int a, ref int b)
    {
        // a = 0b0000 0001
        // b = 0b0000 0010

        a = a ^ b; // a = 0b0000 0011
        b = a ^ b; // b = 0b0000 0001
        a = a ^ b; // a = 0b0000 0010
    }

    static bool IsChetnoe(int a)
    {
        return (a & 1) != 1;
    }

    static int GetRGB(byte r, byte g, byte b)
    { 
        return ((r << 16) | (g << 8) | b);
    }

    static void GetColorFromRGB(int nRGB)
    {
        byte r = (byte)(nRGB >> 16);
        byte g = (byte)((r << 8) ^ (nRGB >> 8));
        byte b = (byte)(nRGB ^ ((r << 16) | (g << 8)));
        Console.WriteLine($"r = {r}, g = {g}, b = {b}");
    }
    // argb - 4 байта 0xFFFFFFFF
}