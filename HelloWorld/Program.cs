using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            string text = "Hello World!";
            ConsoleKeyInfo quitKey = new ConsoleKeyInfo('Q', ConsoleKey.Q, true, false, false);
            ConsoleKeyInfo userInput = new ConsoleKeyInfo();

            Console.CursorVisible = false;

            Console.WriteLine("_____ _____!");
            Console.WriteLine("Input a letter to guess the word. Input Shift+Q to quit");

            //run till user inputs 'Q'
            while (userInput != quitKey)
            {
                //get input
                userInput = Console.ReadKey(true);

                //if user input a char in text
                if (text.Contains(userInput.KeyChar))
                {
                    //loop through each letter in text
                    for(int i = 0; i < text.Length; ++i)
                    {
                        //if the letter at position i is the same as userInput
                        if(text[i] == userInput.KeyChar)
                        {
                            //display in random color
                            ConsoleColor foreground = (ConsoleColor)rng.Next(1, 16);

                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = foreground;

                            Console.SetCursorPosition(i, 0);
                            Console.Write(text[i]);
                        }
                    }
                }
            }


            //change colors back for end of program text
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
