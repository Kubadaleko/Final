// /* Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.*/

string[] arrayWords1 = { "Иван", "Ольга", "Рот", "Бар", "Кот", "Вера", "Кремль" };
string[] arrayWords2 = new string[arrayWords1.Length];

void newArrayWords(string[] array1, string[] array2)
{
    int k = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[k] = array1[i];
            k++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

newArrayWords(arrayWords1, arrayWords2);
PrintArray(arrayWords2);


// Еще вариант решения

// string[] arrayWords1 = { "Иван", "Ольга", "Рот", "Бар", "Кот", "Вера", "Кремль" };
// string[] arrayWords2 = new string[arrayWords1.Length];
// for (int i = 0; i < arrayWords1.Length; i++)
// {
//     if (arrayWords1[i].Length <= 3)
//         arrayWords2[i] = arrayWords1[i];
// }
// System.Console.WriteLine(string.Join(" ", arrayWords2));
