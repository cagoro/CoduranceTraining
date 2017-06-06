using System;
using System.Text.RegularExpressions;

namespace AnotherTwitter
{
    public class Twitter
    {
        private readonly IConsole _console;
        private readonly IMessageStorage _messageStorageObject;

        public Twitter(IConsole console, IMessageStorage messageStorageObject)
        {
            _console = console;
            _messageStorageObject = messageStorageObject;
        }

        public void Run()
        {
            _console.Write(">");

            String command = _console.ReadLine();

            if (command == "exit")
            {
                _console.Write("Bye bye!");
            }
            else
            {
                var parts = Regex.Split(command, " -> ");
                _messageStorageObject.Store(parts[0], parts[1]);
                _console.Write(">");
            }
        }
    }
}
