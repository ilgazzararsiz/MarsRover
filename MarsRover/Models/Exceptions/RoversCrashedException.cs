using System;
using System.Runtime.Serialization;

namespace MarsRover.Models
{
    [Serializable]
    internal class RoversCrashedException : Exception
    {
        public RoversCrashedException()
        {
        }

        public RoversCrashedException(string message) : base(message)
        {
        }
    }
}