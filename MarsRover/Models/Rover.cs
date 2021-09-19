namespace MarsRover.Models
{
    public class Rover
    {
        public Position Position { get; set; }

        public Rover(Position Position)
        {
            this.Position = Position;
        }
    }
}
