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

int ProverkaString(string Z)                                    //функция проверки ввода букв вместо цифр
{
    bool resultA = int.TryParse(Z, out int F);                  // Проверка на ввод букв
    if (resultA == false)
    {
        Console.WriteLine("You should input only numbers");
        Environment.Exit(0);
    }
    int A = Convert.ToInt32(Z);                                 //Если проверка пройдена, переводим А в число
    return A;
}

Console.Clear();
Console.Write("Input number A: ");                              //Ввод числа А
string strA = Console.ReadLine();
int A = ProverkaString(strA);                                   //Вызываем функцию для проверки ввода числа вместо букв

Console.Write("Input number B: ");                              //Ввод числа В
string strB = Console.ReadLine();
int B = ProverkaString(strB);                                   //Вызываем функцию для проверки ввода числа вместо букв
        
Console.WriteLine();                                            //Доп строка для красоты вывода
Console.WriteLine("Number A^B = " + Stepen(A, B));              //Вывод результата