// Создание искомого массива через промежуточный массив (рабочее).

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []




// Ввод пользователем числа int, запрос в 2 строки.
int UserInputNumber(string text1, string text2)
{
    Console.WriteLine(text1);
    Console.Write(text2);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}


// Ввод пользователем текстовых элементов для заполнения массива строк.
string UserInputText(string text)
{
    Console.WriteLine(text);
    string input = Console.ReadLine();
    return input;
}


// Проверка числа на натуральность.
bool NaturalSetCheck(int num)
{
    return num > 0;
}


// Создание массива строк заданой длины (заполнен пустыми строками).
string[] CreateArray(int size)
{
    string[] collection = new string[size];
    return collection;
}


// Заполнение массива строк произвольными текстовыми элементами, вводимыми пользователем.
void FillArray(string[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = UserInputText($"Введите текст для элемента массива строк под номером {i}");
    }
}


// Вывод массива строк на печать в квадратных скобках (элементы выводятся в кавычках).
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


// Создание из массива строк нового массива, в который из исходного попадут только элементы с длиной не более num. 
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


int number = UserInputNumber("Введите желаемую длину массива строк (в виде натурального числа)", "N = ");

while (!NaturalSetCheck(number))
{
    Console.WriteLine($"Ошибка ввода. Число {number} не является натуральным");
    number = UserInputNumber("Необходимо ввести целое число больше ноля. Повторите попытку", "N = ");
}
// А если пользователь ввёл букву? Нужно отредактировать проверку.


string[] array1 = CreateArray(number);
FillArray(array1);
PrintArray(array1);


string[] array2 = StringElementShorterThanNumSelectionToNewStringArray(array1, 3);
PrintArray(array2);

