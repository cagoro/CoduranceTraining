using System.Collections.Generic;

namespace AnotherTwitter
{
    public interface IMessageStorage
    {
        void Store(string username, string message);

        IEnumerable<string> Retrieve(string username);
    }
}