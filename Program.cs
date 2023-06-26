/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/*
Console.WriteLine("Введите трехзначное число: ");
string number = Console.ReadLine()!;
int num = int.Parse(number);

int dozen = num / 10;   // 34
int secondDigit = dozen % 10;

Console.WriteLine("Вторая цифра числа " + number + " равна " + secondDigit);
Console.WriteLine($"Вторая цифра числа {number} равна {secondDigit}");
*/
/////
/*
Console.Write("Введите число: ");
string number = Console.ReadLine();
int num = int.Parse(number);
if (number < 100)
{
    Console.WriteLine($"третьей цифры нет");
}
else while (count > 999)
{
    int number = number / 10;
    num = number;
    number = 0;
}
*/


// int secondDigit = num / 10 % 10;


//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
///32679 -> 6

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!); // 123456
int temp = num;

while (temp > 999)
{
    temp = temp / 10; // num = 123456 / 10 = 12345
}

if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int thirdDigit = temp % 10;
    Console.WriteLine($"Третья цифра числа {num} равна {thirdDigit}");
}

///Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
///6 -> да
///7 -> да
///1 -> нет


Console.WriteLine("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine()!);

if (day < 6 && day > 0)
{
    Console.WriteLine("нет");
}
else if (day == 6 || day == 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("Такого дня недели нет");
}



/*
Console.WriteLine("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine()!);

if (day < 6 && day > 0)
{
    Console.WriteLine("нет");
}
else if (day <= 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("Такого дня недели нет");
}

int InputNum(string txt)
{
    Console.WriteLine(txt);
    string number = Console.ReadLine()!;
    int num = int.Parse(number);
    return num;
}

int GetThirdDigit(int num)
{
    int dozen = num / 10;   // 34
    int secondDigit = dozen % 10;
    return secondDigit;
}

int number = InputNum("Введите трехзначное число: ");
int second = GetThirdDigit(number);

// 345 / 10 = 34     34 % 10 = 4

Console.WriteLine($"Вторая цифра числа {number} равна {second}");

Console.WriteLine("Введите целое число N: ");
int num = int.Parse(Console.ReadLine()!); // 4

int count = 1;

while(count <= num)
{
    int cube = count * count * count; // Math.Pow(count, 3)
    Console.Write($"{cube} ");
    count = count + 1; // count += 1 или count++
}
*/