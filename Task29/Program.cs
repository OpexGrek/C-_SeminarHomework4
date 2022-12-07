// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void array()                                                //Функция ввода массива рандомом
{
    int[] massive = new int[8];
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(50);
        Console.Write(massive[i] + " ");
    }
}


Console.Clear();
array();                                                    //Вывод массива