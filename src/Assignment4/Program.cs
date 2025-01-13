using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string[] names = {
            "Nguyễn  vAn Thanh",
            " trần   thị Nhung",
            "Huỳnh Thúc Điền.",
            "“Lê van  NaM”"
        };

        foreach (var name in names)
        {
            Console.WriteLine(FormatName(name));
        }
    }

    static string FormatName(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        StringBuilder result = new StringBuilder();
        bool capitalizeNext = true; // Flag to indicate when to capitalize a character

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];

            if (char.IsWhiteSpace(c))
            {
                // Avoid consecutive spaces
                if (result.Length > 0 && result[^1] != ' ')
                {
                    result.Append(' ');
                }
                capitalizeNext = true; // Capitalize next non-space character
            }
            else if (char.IsLetter(c))
            {
                // Capitalize the first letter of each word
                result.Append(capitalizeNext ? char.ToUpper(c) : char.ToLower(c));
                capitalizeNext = false;
            }
        }
        if (result.Length > 0 && result[^1] == ' ')
            result.Length--;
        return FixVietnameseSpecificWords(result.ToString());
    }

    static string FixVietnameseSpecificWords(string name)
    {
        string[] wordsToFix = { "Van" };
        string[] correctedWords = { "Văn" };

        for (int i = 0; i < wordsToFix.Length; i++)
        {
            name = name.Replace($" {wordsToFix[i]} ", $" {correctedWords[i]} ");
        }

        return name;
    }
}
