using MarsRover.Models.Enums;

namespace MarsRover.Models
{
    public class Position
    {
        public Coordinates Coordinates { get; set; }
        public Direction Direction { get; set; }

        public Position(Coordinates Coordinates, Direction Direction)
        {
            this.Coordinates = Coordinates;
            this.Direction = Direction;
        }
    }
}
