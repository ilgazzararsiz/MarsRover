using MarsRover.Models;
using MarsRover.Models.Enums;
using System;
using System.Collections.Generic;

namespace MarsRover
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Plateau plateau = new Plateau(new Coordinates(5, 5));
            Rover rover = new Rover(new Position(new Coordinates(1, 2), Direction.North));

            List<Rover> rovers = new List<Rover>();

            rovers.Add(rover);
            plateau.Rovers = rovers;

            plateau.Rovers[0].ChangePosition(DirectionCommand.Left);
            plateau.Rovers[0].ChangePosition(DirectionCommand.Move);
            plateau.Rovers[0].ChangePosition(DirectionCommand.Left);
            plateau.Rovers[0].ChangePosition(DirectionCommand.Move);
            plateau.Rovers[0].ChangePosition(DirectionCommand.Left);
            plateau.Rovers[0].ChangePosition(DirectionCommand.Move);
            plateau.Rovers[0].ChangePosition(DirectionCommand.Left);
            plateau.Rovers[0].ChangePosition(DirectionCommand.Move);
            plateau.Rovers[0].ChangePosition(DirectionCommand.Move);

            Console.WriteLine(plateau.Rovers[0].ShowCurrentPosition());
        }
    }
}
