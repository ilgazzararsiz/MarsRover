using MarsRover.Models.Enums;
using System;

namespace MarsRover.Models
{
    public class Rover
    {
        public Position Position { get; set; }

        public Rover(Position Position)
        {
            this.Position = Position;
        }

        public void ChangePosition(DirectionCommand directionCommand)
        {
            switch (directionCommand)
            {
                case DirectionCommand.Left:
                    TurnLeft();
                    break;
                case DirectionCommand.Right:
                    TurnRight();
                    break;
                case DirectionCommand.Move:
                    Move();
                    break;
            }
        }

        private void Move()
        {
            switch (Position.Direction)
            {
                case Direction.East:
                    Position.Coordinates.X += 1;
                    break;
                case Direction.West:
                    Position.Coordinates.X -= 1;
                    break;
                case Direction.South:
                    Position.Coordinates.Y -= 1;
                    break;
                case Direction.North:
                    Position.Coordinates.Y += 1;
                    break;
            }
        }

        private void TurnRight()
        {
            switch (Position.Direction)
            {
                case Direction.East:
                    Position.Direction = Direction.South;
                    break;
                case Direction.South:
                    Position.Direction = Direction.West;
                    break;
                case Direction.West:
                    Position.Direction = Direction.North;
                    break;
                case Direction.North:
                    Position.Direction = Direction.East;
                    break;
            }
        }

        private void TurnLeft()
        {
            switch (Position.Direction)
            {
                case Direction.East:
                    Position.Direction = Direction.North;
                    break;
                case Direction.North:
                    Position.Direction = Direction.West;
                    break;
                case Direction.West:
                    Position.Direction = Direction.South;
                    break;
                case Direction.South:
                    Position.Direction = Direction.East;
                    break;
            }
        }

        public string ShowCurrentPosition()
        {
            return $"{Position.Coordinates.X} {Position.Coordinates.Y} {((char)Position.Direction)}";
        }
    }
}
