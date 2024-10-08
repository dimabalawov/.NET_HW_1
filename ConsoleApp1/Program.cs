static void SwapChar(ref char a,ref char b)
{
    char temp = a;
    a = b;
    b = temp;
}

string citata = "t's easy to win forgiveness for being wrong; \r\nbeing right is what gets you into real trouble.\r\nBjarne Stroustrup";
Console.WriteLine(citata);
Console.WriteLine("Введите 5 чисел");

int a1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
int a3 = int.Parse(Console.ReadLine());
int a4 = int.Parse(Console.ReadLine());
int a5 = int.Parse(Console.ReadLine());
int summ = a1 + a2 + a3 + a4 + a5;
int multiply = a1 * a2 * a3 * a4 * a5;
int min = new int[] { a1, a2, a3, a4, a5 }.Min();
int max = new int[] { a1, a2, a3, a4, a5 }.Max();

Console.WriteLine($"Сумма: {summ}");
Console.WriteLine($"Произведение: {multiply}");
Console.WriteLine($"Минимум: {min}");
Console.WriteLine($"Максимум: {max}");
Console.WriteLine("Введите 6-значное число:");
string number = Console.ReadLine();

char[] charArray = number.ToCharArray();

for (int i = 0; i < 3; i++)
{
    SwapChar(ref charArray[i], ref charArray[5 - i]);
}
string reversedNumber = new string(charArray);
Console.WriteLine($"Перевернутое число: {reversedNumber}");

Console.WriteLine("Введите начало диапозона:");
int start = int.Parse( Console.ReadLine());
Console.WriteLine("Введите конец диапозона:");
int end = int.Parse(Console.ReadLine());
int a = 0;
int b = 1;
if (a >= start && a <= end)
{
    Console.WriteLine(a);
}

if (b >= start && b <= end)
{
    Console.WriteLine(b);
}

while (true)
{
    int next = a + b;
    if (next > end)
    {
        break;
    }
    if (next >= start)
    {
        Console.WriteLine(next);
    }
    a = b;
    b = next;
}
Console.WriteLine("Введите начало:");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конец:");
int last = int.Parse(Console.ReadLine());
for (int i = first; i <= last; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(i);
    }
    Console.WriteLine();
}
Console.WriteLine("Введите длину линии:");
int length = int.Parse(Console.ReadLine());

Console.WriteLine("Введите символ заполнитель:");
char symbol = Console.ReadKey().KeyChar;
Console.WriteLine();

Console.WriteLine("Введите направление линии (горизонтальная/вертикальная):");
string direction = Console.ReadLine().ToLower(); 

if (direction == "горизонтальная")
{
    for (int i = 0; i < length; i++)
    {
        Console.Write(symbol);
    }
}
else if (direction == "вертикальная")
{
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine(symbol);
    }
}
else
{
    Console.WriteLine("Ошибка: неверно указано направление линии.");
}

