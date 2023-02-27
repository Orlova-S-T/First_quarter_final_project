// Фрагмент с зацикленным в методе проверяемым пользовательским вводом (одновременная проверка возможности конвертации в число и натуральности).




// Метод запроса на пользовательский ввод (в 2 строки).
string UserInput(string text1, string text2)
{
    Console.WriteLine(text1);
    Console.Write(text2);
    string userText = Console.ReadLine();
    return userText;
}


// Метод проверки, что пользовательский ввод можно конвертировать в число и что полученное число является натуральным.
bool UnputNaturalNumberCheck(string text)
{
    return int.TryParse(text, out int result) && result > 0;
}


// Метод организации пользовательского ввода натурального числа
// с проверкой ввода на отсутствие нецифровых знаков и проверкой числа на натуральность.
int UserInputNaturalNumber()
{
    string userInput = UserInput("Введите желаемую длину массива строк (в виде натурального числа)", "N = ");
    while (!UnputNaturalNumberCheck(userInput))
    {
        Console.Write($"Ошибка ввода. Во введённых символах '{userInput}' не удалось распознать число или ведённое число не является натуральным. ");
        userInput = UserInput("Попробуйте еще раз. Необходимо ввести целое число больше нуля без пробелов и знаков препинания", "N = ");
    }
    int number = Convert.ToInt32(userInput);
    return number;
}




int userNumber = UserInputNaturalNumber();
Console.WriteLine(userNumber);

