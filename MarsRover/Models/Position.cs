using MarsRover.Models.Enums;

namespace MarsRover.Models
{
    public class Position
    {
        public Coordinates Coordinates { get; set; }
        public RoverDirection RoverDirection { get; set; }

        public Position(Coordinates Coordinates, RoverDirection RoverDirection)
        {
            this.Coordinates = Coordinates;
            this.RoverDirection = RoverDirection;
        }
    }
}
