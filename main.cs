class Matrix
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        string userName = Environment.UserName;
        string[] sentences = {
            $"Wake up, {userName}...",
            "The Matrix has you...",
            "Follow the white rabbit.",
            $"Knock, knock, {userName}."
        };
        Random random = new Random();

        foreach (string sentence in sentences)
        {
            foreach (char c in sentence)
            {
                Console.Write(c);
                Thread.Sleep(random.Next(100,250));
            }
            Thread.Sleep(1750);
            Console.Clear();
            Thread.Sleep(450);
        }

        Environment.Exit(0);
    }
}
