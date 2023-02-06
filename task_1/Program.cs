// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

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

int GetExponent(int expBase, int expPow)
{
    int exp = 1;
    for(int i = 1; i <= expPow; i++)
    exp = exp * expBase;

return exp;
}


int expBase = GetNumber("Введите натуральное основание степени");
int expPow = GetNumber("Введите натуральную степень");

Console.WriteLine($"{expBase} в {expPow}-й степени равняется {GetExponent(expBase, expPow)}");
