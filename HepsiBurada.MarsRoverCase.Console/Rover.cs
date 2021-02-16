using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRoverCase.ConsoleApp
{
    public class Rover
    {
        public int XPoint { get; set; }
        public int YPoint { get; set; }
        public Direction Direction { get; set; }

        public Rover(int xPoint, int yPoint, Direction direction)
        {
            XPoint = xPoint;
            YPoint = yPoint;
            Direction = direction;
        }

        public void Turn(string directionLeftOrRight)
        {
            if (directionLeftOrRight is "L")
            {
                Direction = Direction switch
                {
                    Direction.N => Direction.W,
                    Direction.W => Direction.S,
                    Direction.S => Direction.E,
                    Direction.E => Direction.N,
                    _ => Direction
                };
            }
            else if(directionLeftOrRight is "R")
            {
                Direction = Direction switch
                {
                    Direction.N => Direction.E,
                    Direction.E => Direction.S,
                    Direction.S => Direction.W,
                    Direction.W => Direction.N,
                    _ => Direction
                };
            }
            else
            {
                Console.WriteLine("Wrong Direction Parameter");
            }
        }

        public void Move()
        {
            switch(this.Direction)
            {
                case Direction.N: 
                    YPoint += 1;
                    break;
                case Direction.S:
                    YPoint -= 1;
                    break;
                case Direction.E:
                    XPoint += 1;
                    break;
                case Direction.W:
                    XPoint -= 1;
                    break;
                default:
                    Console.WriteLine("Wrong Direction Parameter");
                    break;  
            };

            
        }
    }
}
