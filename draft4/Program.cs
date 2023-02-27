// Фрагмент пользовательского ввода с зацикленной рекурсивной проверкой через try...catch.




// Метод запроса на пользовательский ввод (в 2 строки) с проверкой относятся ли
// введённые пользователем символы к цифровым.
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


// Проверка числа на натуральность.
bool NaturalSetCheck(int num)
{
    return num > 0;
}




int userInput = UserInput("Введите желаемую длину массива строк (в виде натурального числа)", "N = ");

while (!NaturalSetCheck(userInput))
{
    Console.WriteLine($"Ошибка ввода. Число {userInput} не является натуральным");
    userInput = UserInput("Необходимо ввести целое число больше ноля. Повторите попытку", "N = ");
}
Console.WriteLine(userInput);

