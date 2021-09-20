using System;

namespace MarsRover.Models
{
    [Serializable]
    internal class RoverOutOfBoundariesException : Exception
    {
        public RoverOutOfBoundariesException()
        {
        }

        public RoverOutOfBoundariesException(string message) : base(message)
        {
        }
    }
}