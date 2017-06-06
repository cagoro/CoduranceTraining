using NUnit.Framework;

namespace CoduranceTraining.Tests
{
    [TestFixture]
    public class MarsRoverShould
    {
        private MarsRover _marsRover;

        [Test]
        public void return_initial_position_when_no_commands_provided()
        {
            _marsRover = new MarsRover(0, 0, 'N');
            Assert.AreEqual("0,0,N", _marsRover.Move(string.Empty));
        }
        
        [TestCase("M", "0,1,N")]
        [TestCase("MMM", "0,3,N")]
        public void move_north(string commands, string expectedPosition)
        {
            _marsRover = new MarsRover(0, 0, 'N');
            Assert.AreEqual(expectedPosition, _marsRover.Move(commands));
        }

        [TestCase("MMMMMMMMMM", "0,0,N")]
        [TestCase("MMMMMMMMMMM", "0,1,N")]
        public void wrap_around_south_when_crossing_north_boundary(string commands, string expectedPosition)
        {
            _marsRover = new MarsRover(0, 0, 'N');
            Assert.AreEqual(expectedPosition, _marsRover.Move(commands));
        }

        [TestCase("M", "0,8,S")]
        [TestCase("MMM", "0,6,S")]
        public void move_south(string commands, string expectedPosition)
        {
            _marsRover = new MarsRover(0,9,'S');
            Assert.AreEqual(expectedPosition, _marsRover.Move(commands));
        }

        [TestCase("MMMMMMMMMM", "0,9,S")]
        [TestCase("MMMMMMMMMMM", "0,8,S")]
        public void wrap_around_north_when_crossing_south_boundary(string commands, string expectedPosition)
        {
            _marsRover = new MarsRover(0, 9, 'S');
            Assert.AreEqual(expectedPosition, _marsRover.Move(commands));
        }


        [TestCase("M", "1,0,E")]
        [TestCase("MMM", "3,0,E")]
        public void move_east(string commands, string expectedPosition)
        {
            _marsRover = new MarsRover(0, 0, 'E');
            Assert.AreEqual(expectedPosition, _marsRover.Move(commands));
        }

    }
}
