class Program
{
    static bool IsMeowString(string sound)
    {
        // Check if the string is empty or null
        if (string.IsNullOrEmpty(sound)) return false;
        string soundMeowValid = "meow";
        string result = new string(sound.Trim().ToLower().Distinct().ToArray());
        return result.Equals(soundMeowValid);
    }
    static void Main()
    {
        // Test cases
        string[] testStrings = {
            "mmeow" , "meeow", "meoow", "meoww", "mmmeow", "meeeow", "meooow", "meowww", "mmmeeeow", "meooowww", "mmmmeoooow", " mmeow ", "Mmeow",  // Valid
            "ammeow", "mmaeow", "mmeaow", "mmeoaw", "meo", "mow", "mew", "maaow" // Invalid
        };
        foreach (var str in testStrings)
        {
            Console.WriteLine($"{str}: {IsMeowString(str)}");
        }
    }
}
