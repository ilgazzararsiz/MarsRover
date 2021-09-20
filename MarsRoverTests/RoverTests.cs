using MarsRover.Models.Enums;
using MarsRover.Models;
using Xunit;

namespace MarsRoverTests
{
    public class RoverTests
    {
        [Fact]
        public void ShouldTurnWestWhenDirectionIsNorthAndCommandIsLeft()
        {
            // Arrange
            var directionCommand = DirectionCommand.Left;
            var position = new Position(new Coordinates(1, 2), Direction.North);
            var rover = new Rover(position);

            // Act
            var changedPosition = rover.ChangePosition(directionCommand);

            // Assert
            Assert.Equal(Direction.West, changedPosition.Direction);
            Assert.Equal(position.Coordinates, changedPosition.Coordinates);
        }

        [Fact]
        public void ShouldTurnEastWhenDirectionIsNorthAndCommandIsRight()
        {
            // Arrange
            var directionCommand = DirectionCommand.Right;
            var position = new Position(new Coordinates(1, 2), Direction.North);
            var rover = new Rover(position);

            // Act
            var changedPosition = rover.ChangePosition(directionCommand);

            // Assert
            Assert.Equal(Direction.East, changedPosition.Direction);
            Assert.Equal(position.Coordinates, changedPosition.Coordinates);
        }

        [Fact]
        public void ShouldMoveWhenDirectionIsNorthAndCommandIsMove()
        {
            // Arrange
            var directionCommand = DirectionCommand.Move;
            var position = new Position(new Coordinates(1, 2), Direction.North);
            var rover = new Rover(new Position(new Coordinates(1, 2), Direction.North));

            // Act
            var changedPosition = rover.ChangePosition(directionCommand);

            // Assert
            Assert.Equal(position.Coordinates.Y + 1, changedPosition.Coordinates.Y);
        }

        [Fact]
        public void ShouldTurnEastWhenDirectionIsSouthAndCommandIsLeft()
        {
            // Arrange
            var directionCommand = DirectionCommand.Left;
            var position = new Position(new Coordinates(1, 2), Direction.South);
            var rover = new Rover(position);

            // Act
            var changedPosition = rover.ChangePosition(directionCommand);

            // Assert
            Assert.Equal(Direction.East, changedPosition.Direction);
            Assert.Equal(position.Coordinates, changedPosition.Coordinates);
        }

        [Fact]
        public void ShouldTurnWestWhenDirectionIsSouthAndCommandIsRight()
        {
            // Arrange
            var directionCommand = DirectionCommand.Right;
            var position = new Position(new Coordinates(1, 2), Direction.South);
            var rover = new Rover(position);

            // Act
            var changedPosition = rover.ChangePosition(directionCommand);

            // Assert
            Assert.Equal(Direction.West, changedPosition.Direction);
            Assert.Equal(position.Coordinates, changedPosition.Coordinates);
        }

        [Fact]
        public void ShouldMoveWhenDirectionIsSouthAndCommandIsMove()
        {
            // Arrange
            var directionCommand = DirectionCommand.Move;
            var position = new Position(new Coordinates(1, 2), Direction.South);
            var rover = new Rover(new Position(new Coordinates(1, 2), Direction.South));

            // Act
            var changedPosition = rover.ChangePosition(directionCommand);

            // Assert
            Assert.Equal(position.Coordinates.Y - 1, changedPosition.Coordinates.Y);
        }

        [Fact]
        public void ShouldTurnNorthWhenDirectionIsEastAndCommandIsLeft()
        {
            // Arrange
            var directionCommand = DirectionCommand.Left;
            var position = new Position(new Coordinates(1, 2), Direction.East);
            var rover = new Rover(position);

            // Act
            var changedPosition = rover.ChangePosition(directionCommand);

            // Assert
            Assert.Equal(Direction.North, changedPosition.Direction);
            Assert.Equal(position.Coordinates, changedPosition.Coordinates);
        }

        [Fact]
        public void ShouldTurnSouthWhenDirectionIsEastAndCommandIsRight()
        {
            // Arrange
            var directionCommand = DirectionCommand.Right;
            var position = new Position(new Coordinates(1, 2), Direction.East);
            var rover = new Rover(position);

            // Act
            var changedPosition = rover.ChangePosition(directionCommand);

            // Assert
            Assert.Equal(Direction.South, changedPosition.Direction);
            Assert.Equal(position.Coordinates, changedPosition.Coordinates);
        }

        [Fact]
        public void ShouldMoveWhenDirectionIsEastAndCommandIsMove()
        {
            // Arrange
            var directionCommand = DirectionCommand.Move;
            var position = new Position(new Coordinates(1, 2), Direction.East);
            var rover = new Rover(new Position(new Coordinates(1, 2), Direction.East));

            // Act
            var changedPosition = rover.ChangePosition(directionCommand);

            // Assert
            Assert.Equal(position.Coordinates.X + 1, changedPosition.Coordinates.X);
        }

        [Fact]
        public void ShouldTurnSouthWhenDirectionIsWestAndCommandIsLeft()
        {
            // Arrange
            var directionCommand = DirectionCommand.Left;
            var position = new Position(new Coordinates(1, 2), Direction.West);
            var rover = new Rover(position);

            // Act
            var changedPosition = rover.ChangePosition(directionCommand);

            // Assert
            Assert.Equal(Direction.South, changedPosition.Direction);
            Assert.Equal(position.Coordinates, changedPosition.Coordinates);
        }

        [Fact]
        public void ShouldTurnNorthWhenDirectionIsWestAndCommandIsRight()
        {
            // Arrange
            var directionCommand = DirectionCommand.Right;
            var position = new Position(new Coordinates(1, 2), Direction.West);
            var rover = new Rover(position);

            // Act
            var changedPosition = rover.ChangePosition(directionCommand);

            // Assert
            Assert.Equal(Direction.North, changedPosition.Direction);
            Assert.Equal(position.Coordinates, changedPosition.Coordinates);
        }

        [Fact]
        public void ShouldMoveWhenDirectionIsWestAndCommandIsMove()
        {
            // Arrange
            var directionCommand = DirectionCommand.Move;
            var position = new Position(new Coordinates(1, 2), Direction.West);
            var rover = new Rover(new Position(new Coordinates(1, 2), Direction.West));

            // Act
            var changedPosition = rover.ChangePosition(directionCommand);

            // Assert
            Assert.Equal(position.Coordinates.X - 1, changedPosition.Coordinates.X);
        }

        [Fact]
        public void ShouldReturnCurrentPositionAsString()
        {
            // Arrange
            var position = new Position(new Coordinates(1, 2), Direction.North);
            var expectedPosition = "1 2 N";
            var rover = new Rover(position);

            // Act
            var currentPosition = rover.ShowCurrentPosition();

            // Assert
            Assert.Equal(expectedPosition, currentPosition);
        }
    }
}
