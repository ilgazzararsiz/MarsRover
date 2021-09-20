using MarsRover.Models.Enums;
using System;
using System.Collections.Generic;

namespace MarsRover.Models
{
    public class Plateau
    {
        public Coordinates BoundaryCoordinates { get; set; }
        public List<Rover> Rovers { get; set; }

        public Plateau(Coordinates BoundaryCoordinates)
        {
            this.BoundaryCoordinates = BoundaryCoordinates;
        }

        public void MoveRover(int index, DirectionCommand directionCommand)
        {
            var newPosition = Rovers[index].ChangePosition(directionCommand);

            if (CanMoveRover(new Rover(newPosition)))
            {
                Rovers[index].Position = newPosition;
            }
            else
            {
                throw new Exception();
            }
        }

        private bool CanMoveRover(Rover rover)
        {
            if (IsRoverInPlateauBoundaries(rover))
                throw new RoverOutOfBoundariesException();
            else if (DidRoversCrashed(rover))
                throw new RoversCrashedException();
            return true;
        }

        private bool IsRoverInPlateauBoundaries(Rover rover)
        {
            return BoundaryCoordinates.X < Math.Abs(rover.Position.Coordinates.X) || BoundaryCoordinates.Y < Math.Abs(rover.Position.Coordinates.Y);
        }

        private bool DidRoversCrashed(Rover rover)
        {
            foreach (Rover r in Rovers)
            {
                if (r.Position == rover.Position)
                    return true;
            }
            return false;
        }
    }
}
