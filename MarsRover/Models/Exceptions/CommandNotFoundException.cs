using System;
using System.Runtime.Serialization;

namespace MarsRover.Models
{
    [Serializable]
    public class CommandNotFoundException : Exception
    {
        public CommandNotFoundException()
        {
        }

        public CommandNotFoundException(string message) : base(message)
        {
        }
    }
}