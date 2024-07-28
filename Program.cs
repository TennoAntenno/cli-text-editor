class Program
{
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
                if (text.Length > 0)
                    text = text.Substring(0, text.Length - 1);
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