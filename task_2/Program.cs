// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && (result >= 0))
        {
        break;
        }
        else
        {
        Console.WriteLine("Ввели не число или не корректное число.");
        }
    }
    return result;
}

int GetSum(int number)
{
    string numberStr = number.ToString();
    int sum = 0;
    for(int i = 0; i < numberStr.Length; i++)
    {
    int digit = number % 10;
    sum += digit;
    number /= 10;
    }
return sum;
}

int number = GetNumber("Введите число");
int digitSum = GetSum(number);
Console.WriteLine($"Сумма цифр числа {number} равна {digitSum}");