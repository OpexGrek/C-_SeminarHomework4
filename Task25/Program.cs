// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Stepen(int C, int D)                                        //Функция вычисления степени
{
    int E = 1;
    for (int i = 0; i < D; i++)
    {
        E = E * C;
    }
    return E;
}

Console.Clear();
Console.Write("Input number A: ");                              //Ввод числа А
string strA = Console.ReadLine();

bool resultA = int.TryParse(strA, out int F);                   // Проверка на ввод букв
if (resultA == false)
{
    Console.WriteLine("You should input only numbers");
    Environment.Exit(0);
}
else
{
    int A = Convert.ToInt32(strA);                              //Если проверка пройдена, переводим А в число

    Console.Write("Input number B: ");                          //Ввод числа В
    string strB = Console.ReadLine();

    bool resultB = int.TryParse(strB, out int G);               // Проверка на ввод букв
    if (resultB == false)
    {
        Console.WriteLine("You should input only numbers");
        Environment.Exit(0);
    }
    else
    {
        int B = Convert.ToInt32(strB);                          //Если проверка пройдена, переводим В в число
        Console.WriteLine();                                    //Доп строка для красоты вывода
        Console.WriteLine("Number A^B = " + Stepen(A, B));      //Вывод результата
    }
}    