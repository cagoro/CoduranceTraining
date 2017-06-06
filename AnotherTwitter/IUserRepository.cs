using System.Collections.Generic;

namespace AnotherTwitter
{
    public interface IUserRepository
    {
        void Follow(string follower, string followee);

        IEnumerable<string> Following(string username);
    }
}