// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.



using System;
class Program

{
    static void Main()
    {
        Console.Write("Введите строку для проверки на палиндром: ");
        string inputString = Console.ReadLine();

        if (IsPalindrome(inputString))
        {
            Console.WriteLine("Введенная строка является палиндромом");
        }
        else
        {
            Console.WriteLine("Введенная строка не является палиндромом");
        }
    }

    static bool IsPalindrome(string str)
    {
        string cleanedString = str.Replace(" ", "").ToLower();
        
        string reversedString = new string(cleanedString.Reverse().ToArray());

        return cleanedString == reversedString;

    }
}
        

        