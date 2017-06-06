using Moq;
using NUnit.Framework;

namespace AnotherTwitter.Tests
{
    [TestFixture]
    public class TwitterShould
    {
        [Test]
        public void close_program()
        {
            var console = new Mock<IConsole>();
            console.Setup(x => x.ReadLine()).Returns("Exit");
            var system = new Mock<ISystem>();

            var twitter = new Twitter(system.Object, console.Object);

            twitter.Run();

            console.Verify(c => c.Write(">"), Times.Once);
            system.Verify(s => s.Exit());
        }

    }
}
