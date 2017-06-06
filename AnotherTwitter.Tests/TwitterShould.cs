using System.Collections.Generic;
using Moq;
using NUnit.Framework;

namespace AnotherTwitter.Tests
{
    [TestFixture]
    public class TwitterShould
    {
        private Mock<IConsole> _console;
        private Twitter _twitter;
        private Mock<IMessageStorage> _messageStorage;

        [SetUp]
        public void Setup()
        {
            _console = new Mock<IConsole>();
            _messageStorage = new Mock<IMessageStorage>();

            _twitter = new Twitter(_console.Object, _messageStorage.Object);
        }

        [Test]
        public void close_program()
        {
            _console.Setup(x => x.ReadLine()).Returns("exit");

            _twitter.Run();

            _console.Verify(c => c.Write(">"), Times.Once);
            _console.Verify(c => c.Write("Bye bye!"), Times.Once);
        }

        [Test]
        public void store_message_of_known_user()
        {
            _console.Setup(c => c.ReadLine()).Returns("Bob -> hello world!");

            _twitter.Run();
            
            _console.Verify(c => c.Write(">"), Times.Exactly(2));
            _messageStorage.Verify(m => m.Store("Bob", "hello world!"));
        }

        [Test]
        public void list_user_messages()
        {
            _messageStorage.Setup(m => m.Retrieve("Bob")).Returns(new [] { "hello world (5 minutes)"});

            _twitter.Run();
            
            _console.Verify(c => c.Write(">"), Times.Exactly(2));

            _console.Verify(c => c.Write("hello world! (5 minutes)"));
        }

    }
}
