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

        public bool CanMoveRover(Rover rover)
        {
            if (IsRoverInPlateauBoundaries(rover))
                throw new RoverOutOfBoundariesException();
            else if (DidRoversCrash(rover))
                throw new RoversCrashedException();
            return true;
        }

        public bool IsRoverInPlateauBoundaries(Rover rover)
        {
            return BoundaryCoordinates.X < Math.Abs(rover.Position.Coordinates.X) 
                || BoundaryCoordinates.Y < Math.Abs(rover.Position.Coordinates.Y);
        }

        public bool DidRoversCrash(Rover rover)
        {
            foreach (Rover r in Rovers)
            {
                if (r.Position.Coordinates.X == rover.Position.Coordinates.X 
                    && r.Position.Coordinates.Y == rover.Position.Coordinates.Y)
                    return true;
            }
            return false;
        }
    }
}
