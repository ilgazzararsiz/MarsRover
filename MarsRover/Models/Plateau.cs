using System.Collections.Generic;

namespace MarsRover.Models
{
    public class Plateau
    {
        public Coordinates BoundryCoordinates { get; set; }
        public List<Rover> Rovers { get; set; }

        public Plateau(Coordinates BoundryCoordinates)
        {
            this.BoundryCoordinates = BoundryCoordinates;
        }
    }
}
