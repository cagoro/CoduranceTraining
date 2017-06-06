using System;

namespace AnotherTwitter
{
    public class Twitter
    {
        private readonly IConsole _console;

        public Twitter(IConsole console)
        {
            _console = console;
        }

        public void Run()
        {
            _console.Write(">");

            String command = _console.ReadLine();

            _console.Write("Bye bye!");
        }
    }
}
