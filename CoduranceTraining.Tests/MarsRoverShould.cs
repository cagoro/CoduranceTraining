using NUnit.Framework;

namespace CoduranceTraining.Tests
{
    [TestFixture]
    public class MarsRoverShould
    {
        private MarsRover _marsRover;

        [SetUp]
        public void Setup()
        {
            _marsRover = new MarsRover();
        }

        [Test]
        public void return_initial_position_when_no_commands_provided()
        {         
            Assert.AreEqual("0,0,N", _marsRover.Move(string.Empty));
        }
        
        [TestCase("M", "0,1,N")]
        [TestCase("MMM", "0,3,N")]
        [TestCase("MMMMMMMMMM", "0,0,N")]
        public void move_forward_in_the_same_direction_when_no_rotations(string commands, string expectedPosition)
        {    
            Assert.AreEqual(expectedPosition, _marsRover.Move(commands));
        }

    }
}
