// Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int InputInt(string message)
{
    System.Console.Write($"{message}> ");
    int value;
    if (int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}
bool Validate(int number)
{
    if (number < 10000 || number > 99999)
    {
        System.Console.WriteLine("Вы ввели не пятизначное число");
        return false;
    }
    return true;
}
int Palindrome(int number)
{
    if (number /10000 % 10 == number % 10 && number / 1000 % 10 == number / 10 % 10)
    {
        System.Console.WriteLine($" Число {number} это палиндром");
    }
    else
    {
         System.Console.WriteLine($" Число {number} не является палиндромом");
    }
    return (number);
}

int number = InputInt("Введите пятизначное число: ");
if (Validate (number))
{
    Palindrome(number);
}


