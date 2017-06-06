using NUnit.Framework;

namespace CoduranceTraining.Tests
{
    [TestFixture]
    public class MarsRoverShould
    {
        [Test]
        public void return_initial_position_when_no_commands_provided()
        {
            var marsRover = new MarsRover();
            Assert.AreEqual("0,0,N", marsRover.Move(string.Empty));
        }
        
        [Test]
        public void move_one_position_in_the_current_direction_when_one_move_command_provided()
        {
            var marsRover = new MarsRover();
            Assert.AreEqual("0,1,N", marsRover.Move("M"));
        }



    }
}
