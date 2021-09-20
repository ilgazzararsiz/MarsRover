using System;

namespace MarsRover.Models
{
    [Serializable]
    public class RoverOutOfBoundariesException : Exception
    {
        public RoverOutOfBoundariesException()
        {
        }

        public RoverOutOfBoundariesException(string message) : base(message)
        {
        }
    }
}