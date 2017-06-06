using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AnotherTwitter
{
    public class Twitter
    {
        private readonly IConsole _console;
        private readonly IMessageStorage _messageStorageObject;
        private readonly IUserRepository _userRepositoryObject;

        public Twitter(IConsole console, IMessageStorage messageStorageObject, IUserRepository userRepositoryObject)
        {
            _console = console;
            _messageStorageObject = messageStorageObject;
            _userRepositoryObject = userRepositoryObject;
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
            else if (command.Contains("follow"))
            {
                var parts = Regex.Split(command, " follow ");
                _userRepositoryObject.Follow(parts[0], parts[1]);
            }
            else if (command.Contains(" wall"))
            {
                var parts = Regex.Split(command, " wall");
                IEnumerable<string> following = _userRepositoryObject.Following(parts[0]);

                var allUsers = following.Concat(new[] {parts[0]});

                var messages = _messageStorageObject.Retrieve(allUsers.ToArray());

                foreach (var message in messages)
                {
                    _console.Write(message);
                }
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
