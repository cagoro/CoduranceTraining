namespace AnotherTwitter
{
    public interface IMessageStorage
    {
        void Store(string username, string message);
    }
}