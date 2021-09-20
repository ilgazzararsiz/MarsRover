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
            var input = "5 5\n" +
                "1 2 N\n" +
                "LMLMLMLMM\n" +
                "3 3 E\n" +
                "MMRMMRMRRM";

            var inputArray = input.Split("\n");
            var plateauCoordinates = inputArray[0].Split(" ");
            Plateau plateau = new Plateau(new Coordinates(int.Parse(plateauCoordinates[0]), int.Parse(plateauCoordinates[1])));
            List<Rover> rovers = new List<Rover>();

            for (int i = 1; i < inputArray.Length; i++)
            {
                if (i % 2 != 0)
                {
                    var currentRover = inputArray[i].Split(" ");
                    Rover rover = new Rover(
                                    new Position(
                                        new Coordinates(int.Parse(currentRover[0]), int.Parse(currentRover[1])), (Direction)currentRover[2].ToCharArray()[0])
                            );
                    rovers.Add(rover);
                }
            }

            plateau.Rovers = rovers;

            List<List<DirectionCommand>> directionCommands = new List<List<DirectionCommand>>();


            for(int i = 2; i < inputArray.Length; i++)
            {
                if(i % 2 == 0)
                {
                    List<DirectionCommand> commands = new List<DirectionCommand>();

                    foreach(char c in inputArray[i].ToCharArray())
                    {
                        commands.Add((DirectionCommand)c);
                    }

                    directionCommands.Add(commands);
                }
            }

            for(int i = 0; i < plateau.Rovers.Count; i++)
            {
                foreach (DirectionCommand directionCommand in directionCommands[i])
                {
                    plateau.MoveRover(i, directionCommand);
                }
            }
            foreach(Rover rover in plateau.Rovers)
            {
                Console.WriteLine(rover.ShowCurrentPosition());
            }
        }
    }
}
