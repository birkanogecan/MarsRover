using System;
using System.Collections.Generic;

namespace HepsiBurada.MarsRoverCase.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Plateau plateau = new Plateau(5, 5);
            Rover roverFirst = new Rover(1, 2, Direction.N);
            Rover roverSecond = new Rover(3, 3, Direction.E);

            plateau.SendRover(roverFirst);
            plateau.SendRover(roverSecond);

            List<string> commandList = new List<string>() { "LMLMLMLMM", "MMRMMRMRRM" };
            plateau.SendCommandList(commandList);
        }
    }
}
