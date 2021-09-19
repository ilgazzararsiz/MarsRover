namespace MarsRover.Models
{
    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinates(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
