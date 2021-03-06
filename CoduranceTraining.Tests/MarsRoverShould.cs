﻿using NUnit.Framework;

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
        
        [TestCase("M", "0,2,N")]
        [TestCase("MMM", "0,4,N")]
        public void move_north(string commands, string expectedPosition)
        {
            _marsRover = new MarsRover(0, 1, 'N');
            Assert.AreEqual(expectedPosition, _marsRover.Move(commands));
        }

        [TestCase("MMMMMMMMMM", "0,1,N")]
        [TestCase("MMMMMMMMMMM", "0,2,N")]
        public void wrap_around_south_when_crossing_north_boundary(string commands, string expectedPosition)
        {
            _marsRover = new MarsRover(0, 1, 'N');
            Assert.AreEqual(expectedPosition, _marsRover.Move(commands));
        }

        [TestCase("M", "1,8,S")]
        [TestCase("MMM", "1,6,S")]
        public void move_south(string commands, string expectedPosition)
        {
            _marsRover = new MarsRover(1,9, 'S');
            Assert.AreEqual(expectedPosition, _marsRover.Move(commands));
        }

        [TestCase("MMMMMMMMMM", "1,9,S")]
        [TestCase("MMMMMMMMMMM", "1,8,S")]
        public void wrap_around_north_when_crossing_south_boundary(string commands, string expectedPosition)
        {
            _marsRover = new MarsRover(1, 9, 'S');
            Assert.AreEqual(expectedPosition, _marsRover.Move(commands));
        }


        [TestCase("M", "1,0,E")]
        [TestCase("MMM", "3,0,E")]
        public void move_east(string commands, string expectedPosition)
        {
            _marsRover = new MarsRover(0, 0, 'E');
            Assert.AreEqual(expectedPosition, _marsRover.Move(commands));
        }

        [TestCase("MMMMMMMMMM", "0,0,E")]
        [TestCase("MMMMMMMMMMM", "1,0,E")]
        public void wrap_around_west_when_crossing_east_boundary(string commands, string expectedPosition)
        {
            _marsRover = new MarsRover(0, 0, 'E');
            Assert.AreEqual(expectedPosition, _marsRover.Move(commands));
        }


        [TestCase("M", "8,0,W")]
        [TestCase("MMM", "6,0,W")]
        public void move_west(string commands, string expectedPosition)
        {
            _marsRover = new MarsRover(9, 0, 'W');
            Assert.AreEqual(expectedPosition, _marsRover.Move(commands));
        }

        [TestCase("MMMMMMMMMM", "9,0,W")]
        [TestCase("MMMMMMMMMMM", "8,0,W")]
        public void wrap_around_east_when_crossing_west_boundary(string commands, string expectedPosition)
        {
            _marsRover = new MarsRover(9, 0, 'W');
            Assert.AreEqual(expectedPosition, _marsRover.Move(commands));
        }

    }
}
