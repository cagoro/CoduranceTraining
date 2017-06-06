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
                return;
            }
            if (command.Contains(" -> "))
            {
                var parts = Regex.Split(command, " -> ");
                _messageStorageObject.Store(parts[0], parts[1]);
                
            }
            else
            {
                var messages = _messageStorageObject.Retrieve(command);

                foreach (var message in messages)
                {
                    _console.Write(message);
                }
                
            }
            _console.Write(">");
        }
    }
}
