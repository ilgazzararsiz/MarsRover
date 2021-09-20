using System;
using System.Runtime.Serialization;

namespace MarsRover.Models
{
    [Serializable]
    public class DirectionNotFoundException : Exception
    {
        public DirectionNotFoundException()
        {
        }

        public DirectionNotFoundException(string message) : base(message)
        {
        }
    }
}