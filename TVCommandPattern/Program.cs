using System;
using TVCommandPattern.Commands;

namespace TVCommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TV fakeTV = new TV();
            fakeTV.TvON();
            while (fakeTV.TVPower)
            {
                Console.WriteLine("W increases the channel\nSDecreases the channel\nUpArrow increases volume\nDownArrow decreases Volume");
                ConsoleKeyInfo keyI = Console.ReadKey();

                ICommand command = GetCommandFromKey(keyI);
                if(command  != null)
                {
                    command.Execute(fakeTV);
                }
                else
                {
                    Console.WriteLine("Don't know command, you must have missed the button");
                }

                switch (keyI.Key)
                {
                    case ConsoleKey.Escape:
                    case ConsoleKey.P:
                        fakeTV.TvOFF();
                        break;
                }
                Console.WriteLine($"Current Channel: {fakeTV.Channel} CurrentVolume: {fakeTV.Volume} ");

            }
        }

        private static ICommand GetCommandFromKey(ConsoleKeyInfo consoleKeyInfo)
        {
            Command command = null;
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.W:
                    command = new ChannelUpCommand();
                    break;
                case ConsoleKey.S:
                    command = new ChannelDownCommand();
                    break;
                case ConsoleKey.UpArrow:
                    command = new TurnUpVolumeCommand();
                    break;
                case ConsoleKey.DownArrow:
                    command = new TurnDownVolumeCommand();
                    break;
                default:
                    Console.WriteLine("Not a valid input");
                    break;

            }
            return command;
        }
    }
}
