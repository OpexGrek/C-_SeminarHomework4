// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ProverkaString(string Z)                                        //функция проверки ввода букв вместо цифр
{
    bool resultA = int.TryParse(Z, out int F);                      // Проверка на ввод букв
    if (resultA == false)
    {
        Console.WriteLine("You should input only numbers");
        Environment.Exit(0);
    }
    int A = Convert.ToInt32(Z);                                     //Если проверка пройдена, переводим А в число
    return A;
}

int sumNumbers(int Y)                                               //функция вычисления суммы цифр
{
    int sum=0;
    while (Y>0)
    {
        sum = sum + Y % 10;
        Y = Y / 10;
    }
    return sum;
}

Console.Clear();
Console.Write("Input number: ");                                    //Ввод числа А
string strA = Console.ReadLine();                                   //

int A = ProverkaString(strA);
int sum = sumNumbers(A);

Console.WriteLine("Sum: "+sum);                                     //вывод результата