using System;

class Program
{
    static bool IsMeowString(string X)
    {
        if (string.IsNullOrEmpty(X)) return false;

        // Biến để theo dõi trạng thái hiện tại (m, e, o, w)
        char currentChar = 'm';

        foreach (char ch in X)
        {
            if (ch != 'm' && ch != 'e' && ch != 'o' && ch != 'w')
                return false;

            if (ch < currentChar)
                return false;

            currentChar = ch;
        }
        return true;
    }

    static void Main()
    {
        // Các test cases
        string[] testStrings = { "mmmmeoooow", "meow", "meowwww", "mmeeooww", "meo", "mow", "mew", "maaow" };

        foreach (var str in testStrings)
        {
            Console.WriteLine($"{str}: {IsMeowString(str)}");
        }
    }
}
