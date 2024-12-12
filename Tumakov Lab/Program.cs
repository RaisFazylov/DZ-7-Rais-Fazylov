using System;
using System.IO;
class Program
{
    public static string ReverseString(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    public static void ProcessFile(string inputFileName)
    {
        if (!File.Exists(inputFileName))
        {
            Console.WriteLine($"Файл '{inputFileName}' не существует.");
            return;
        }
        string outputFileName = "OutputFile.txt";
        try
        {
            string content = File.ReadAllText(inputFileName);
            File.WriteAllText(outputFileName, content.ToUpper());
            Console.WriteLine($"Содержимое файла '{inputFileName}' успешно записано в '{outputFileName}' в верхнем регистре.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Произошла ошибка при обработке файла: {ex.Message}");
        }
    }
    public static bool ImplementsIFormattable(object obj)
    {
        if (obj is IFormattable)
        {
            return true;
        }
        return false;
    }
    static void Main()
    {
        Console.WriteLine("Задание 8.2");
        /* Реализовать метод, который в качестве входного параметра принимает
        строку string, возвращает строку типа string, буквы в которой идут в обратном порядке.
        Протестировать метод.
        */
        Console.WriteLine("Введите строку для реверса: ");
        string inputString = Console.ReadLine();
        string reversedString = ReverseString(inputString);
        Console.WriteLine($"Обратная строка: {reversedString}");
        
        Console.WriteLine("Задание 8.3");
        /* Написать программу, которая спрашивает у пользователя имя файла. Если
        такого файла не существует, то программа выдает пользователю сообщение и заканчивает
        работу, иначе в выходной файл записывается содержимое исходного файла, но заглавными
        буквами.
        */
        Console.WriteLine("\nВведите имя файла для обработки: ");
        string inputFileName = Console.ReadLine();
        ProcessFile(inputFileName);

        Console.WriteLine("Задание 8.4");
        /* Реализовать метод, который проверяет реализует ли входной параметр
        метода интерфейс System.IFormattable. Использовать оператор is и as. (Интерфейс
        IFormattable обеспечивает функциональные возможности форматирования значения объекта
        в строковое представление.)
        */
        Console.WriteLine("\nВведите что-нибудь, чтобы проверить на IFormattable: ");
        string testObject = Console.ReadLine();
        if (ImplementsIFormattable(testObject))
        {
            Console.WriteLine("Объект реализует интерфейс IFormattable.");
        }
        else
        {
            Console.WriteLine("Объект не реализует интерфейс IFormattable.");
        }
    }
}
