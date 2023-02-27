// Программа c раздельной проверкой пользовательского ввода на возможность конвертации в число
// (чтобы не было "аварийной" остановки программы при вводе нецифровых знаков) и на натуральность числа.

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []





// Метод запроса на пользовательский ввод (в 1 строку).
string UserInputText(string text)
{
    Console.WriteLine(text);
    string input = Console.ReadLine();
    return input;
}


// Рекурсивный метод запроса на пользовательский ввод целого числа (в 2 строки)
// с проверкой относятся ли введённые пользователем символы к цифровым.
int UserInput(string text1, string text2)
{
    Console.WriteLine(text1);
    Console.Write(text2);
    string userText = Console.ReadLine();

    try
    {
        int number = Convert.ToInt32(userText);
        return number;
    }

    catch (FormatException)
    {
        Console.Write($"Ошибка ввода. Во введённых символах '{userText}' не удалось распознать число. ");
        return UserInput("Попробуйте еще раз. Необходимо ввести целое число больше нуля без пробелов и знаков препинания", "N = ");
    }
}


// Проверка целого числа на натуральность.
bool NaturalSetCheck(int num)
{
    return num > 0;
}


// Метод создания массива строк заданой длины (заполнен пустыми строками).
string[] CreateArray(int size)
{
    string[] collection = new string[size];
    return collection;
}


// Метод заполнения массива строк произвольными текстовыми элементами, вводимыми пользователем.
void UserFillingStringArray(string[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = UserInputText($"Введите текст для элемента массива строк под номером {i}");
    }
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




int userInput = UserInput("Введите желаемую длину массива строк (в виде натурального числа)", "N = ");

while (!NaturalSetCheck(userInput))
{
    Console.WriteLine($"Ошибка ввода. Число {userInput} не является натуральным");
    userInput = UserInput("Необходимо ввести целое число больше ноля. Повторите попытку", "N = ");
}


string[] array1 = CreateArray(userInput);
UserFillingStringArray(array1);

Console.WriteLine();
Console.Write("Исходный массив: ");
PrintArray(array1);


int length = 3; // Задаём максимальную длину текстовых фрагментов, которые попадут в новый массив.
string[] array2 = StringElementShorterThanNumSelectionToNewStringArray(array1, length);
Console.Write($"Новый массив (с длиной элементов не больше {length}): "); PrintArray(array2);
Console.WriteLine();

