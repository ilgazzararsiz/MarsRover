using MarsRover.Models.Enums;

namespace MarsRover.Models
{
    public class Rover
    {
        public Position Position { get; set; }

        public Rover(Position Position)
        {
            this.Position = Position;
        }

        public Position ChangePosition(DirectionCommand directionCommand)
        {
            switch (directionCommand)
            {
                case DirectionCommand.Left:
                    return new Position(Position.Coordinates, TurnLeft());
                case DirectionCommand.Right:
                    return new Position(Position.Coordinates, TurnRight());
                case DirectionCommand.Move:
                    return Move();
                default:
                    throw new CommandNotFoundException("Command Not Found!");
            }
        }

        public Position Move()
        {
            var newPosition = new Position(Position.Coordinates, Position.Direction);

            switch (Position.Direction)
            {
                case Direction.East:
                    newPosition.Coordinates.X += 1;
                    break;
                case Direction.West:
                    newPosition.Coordinates.X -= 1;
                    break;
                case Direction.South:
                    newPosition.Coordinates.Y -= 1;
                    break;
                case Direction.North:
                    newPosition.Coordinates.Y += 1;
                    break;
                default:
                    throw new DirectionNotFoundException("Direction command not recognizable!");
            }

            return newPosition;
        }

        public Direction TurnRight()
        {
            switch (Position.Direction)
            {
                case Direction.East:
                    return Direction.South;
                case Direction.South:
                    return Direction.West;
                case Direction.West:
                    return Direction.North;
                case Direction.North:
                    return Direction.East;
                default:
                    throw new DirectionNotFoundException("Direction command not recognizable!");
            }
        }

        public Direction TurnLeft()
        {
            switch (Position.Direction)
            {
                case Direction.East:
                    return Direction.North;
                case Direction.North:
                    return Direction.West;
                case Direction.West:
                    return Direction.South;
                case Direction.South:
                    return Direction.East;
                default:
                    throw new DirectionNotFoundException("Direction command not recognizable!");
            }
        }

        public string ShowCurrentPosition()
        {
            return $"{Position.Coordinates.X} {Position.Coordinates.Y} {((char)Position.Direction)}";
        }
    }
}
