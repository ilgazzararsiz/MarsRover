using Xunit;
using MarsRover.Models;
using MarsRover.Models.Enums;
using System.Collections.Generic;

namespace MarsRoverTests
{
    public class PlateauTests
    {
        [Fact]
        public void ShouldReturnTrueWhenRoverCanMove()
        {
            // Arrange
            var position = new Position(new Coordinates(1, 2), Direction.North);
            var rovers = new List<Rover>()
            {
                new Rover(position)
            };

            var movedRover = new Rover(new Position(new Coordinates(1, 3), Direction.North));

            var plateau = new Plateau(new Coordinates(5, 5));
            plateau.Rovers = rovers;

            // Act
            var result = plateau.CanMoveRover(movedRover);

            // Arrange
            Assert.True(result);
        }

        [Fact]
        public void ShouldThrowRoverOutOfBoundariesException()
        {
            // Arrange
            var position = new Position(new Coordinates(5, 5), Direction.North);
            var rovers = new List<Rover>()
            {
                new Rover(position)
            };

            var movedRover = new Rover(new Position(new Coordinates(5, 6), Direction.North));

            var plateau = new Plateau(new Coordinates(5, 5));
            plateau.Rovers = rovers;

            // Act & Arrange
            Assert.Throws<RoverOutOfBoundariesException>(() => plateau.CanMoveRover(movedRover));
        }

        [Fact]
        public void ShouldThrowRoversCrashedException()
        {
            // Arrange
            var position1 = new Position(new Coordinates(1, 2), Direction.North);
            var position2 = new Position(new Coordinates(1, 1), Direction.North);
            var rovers = new List<Rover>()
            {
                new Rover(position1),
                new Rover(position2)
            };

            var movedRover = new Rover(new Position(new Coordinates(1, 2), Direction.North));

            var plateau = new Plateau(new Coordinates(5, 5));
            plateau.Rovers = rovers;

            // Act & Arrange
            Assert.Throws<RoversCrashedException>(() => plateau.CanMoveRover(movedRover));
        }
    }
}
