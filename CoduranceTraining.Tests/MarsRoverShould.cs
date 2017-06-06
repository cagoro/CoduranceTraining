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
        
        [Test]
        public void move_one_position_in_the_current_direction_when_one_move_command_provided()
        {    
            Assert.AreEqual("0,1,N", _marsRover.Move("M"));
        }



    }
}
