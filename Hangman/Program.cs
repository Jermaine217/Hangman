using System;

namespace Hangman
{
    public class HangManConsole
    {
        public static void Main(string[] args)
        {
            PrintMessage("My Message");
        }
    
        public static void PrintMessage(string message, bool printTop = true, bool printBottom = true)
        {
            if (printTop)
            {
                Console.WriteLine("+---------------------------------------+");
                Console.WriteLine("|");
            }
            bool front = true;

            for (int i = message.Length; i < 33; i++)
            {
                if (front)
                {
                    message = " " + message;
                }
                else
                {
                    message = message + " ";

                }
                front = !front;
            }
            Console.WriteLine(message);

            if (printBottom)
            {
                Console.WriteLine("|"); // check out here
                Console.WriteLine("+-----------------------------------------+");
            }
        }
    }
} 
