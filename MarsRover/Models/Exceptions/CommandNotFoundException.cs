using System;
using System.Runtime.Serialization;

namespace MarsRover.Models
{
    [Serializable]
    internal class CommandNotFoundException : Exception
    {
        public CommandNotFoundException()
        {
        }

        public CommandNotFoundException(string message) : base(message)
        {
        }
    }
}