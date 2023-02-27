// Программа без пользовательского ввода: исходный массив задаётся на старте выполнения алгоритма.

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []




// Метод создания массива строк заданой длины (заполнен пустыми строками).
string[] CreateArray(int size)
{
    string[] collection = new string[size];
    return collection;
}


// Метод вывода массива строк на печать в квадратных скобках (элементы выводятся в кавычках).
void PrintArray(string[] collection)
{
    Console.Write("[");
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write('"');
        Console.Write(collection[i]);
        Console.Write('"');

        if (i < collection.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}


// Метод создания из массива строк нового массива, в который из исходного
// попадут только элементы с длиной не более заданного num. 
string[] StringElementShorterThanNumSelectionToNewStringArray(string[] collection, int num)
{
    string[] middleResult = CreateArray(collection.Length);

    string text = string.Empty;
    int j = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        text = collection[i];
        if (text.Length <= num)
        {
            middleResult[j] = collection[i];
            j++;
        }
    }

    string[] result = CreateArray(j);
    for (int i = 0; i < j; i++)
    {
        result[i] = middleResult[i];
    }

    return result;
}




string[] array1 = { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science" };

Console.WriteLine();
Console.Write("Исходный массив: ");
PrintArray(array1);


int length = 3; // Задаём максимальную длину текстовых фрагментов, которые попадут в новый массив.
string[] array2 = StringElementShorterThanNumSelectionToNewStringArray(array1, length);
Console.Write($"Новый массив (с длиной элементов не больше {length}): "); PrintArray(array2);
Console.WriteLine();

