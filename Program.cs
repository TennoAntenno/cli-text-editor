class Program
{
    public static string DeleteChar(string text)
    {
        return text.Substring(0, text.Length - 1);
    }
    public static string DeleteWord(string text)
    {
        for (int i = text.Length - 1; i >= 0; i--)
        {
            if (!(text[i] > 'A' && text[i] < 'z'))
            {
                if (i == text.Length -1 )
                    text = text.Substring(0, i);
                break;
            }
            text = text.Substring(0, i);
        }
        return text;
    }

    public static void Main(string[] args)
    {
        string text = "";
        while (true)
        {
            Console.Clear();
            Console.Write(text);
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter)
            {
                text += '\n';
            }
            else if (key.Key == ConsoleKey.Backspace)
            {
                if (key.Modifiers == ConsoleModifiers.Control)
                    text = DeleteWord(text);
                else if (text.Length > 0)
                    text = DeleteChar(text);
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                break;
            }
            else
            {
                text += key.KeyChar;
            }
        }
    }
}