using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRoverCase.ConsoleApp
{
    public class Plateau
    {
        public int XBorderPoint { get; set; }
        public int YBorderPoint { get; set; }
        public List<Rover> Rovers { get; set; }

        public Plateau(int xBorderPoint, int yBorderPoint)
        {
            XBorderPoint = xBorderPoint;
            YBorderPoint = yBorderPoint;
            Rovers = new List<Rover>();
        }

        public void SendRover(Rover rover) => Rovers.Add(rover);

        public void SendCommandList(List<string> commandList)
        {
            for (int i = 0; i < Rovers.Count; i++)
            {
                foreach (var command in commandList[i].ToCharArray())
                {
                    switch (command)
                    {
                        case 'M':
                            Rovers[i].Move();
                            break;
                        case 'L':
                            Rovers[i].Turn("L");
                            break;
                        case 'R':
                            Rovers[i].Turn("R");
                            break;
                        default:
                            Console.WriteLine($"Invalid Character {command}");
                            break;
                    }
                }

                if (Rovers[i].XPoint < 0 || Rovers[i].YPoint < 0 || Rovers[i].XPoint > XBorderPoint || Rovers[i].YPoint > YBorderPoint)
                {
                    Console.WriteLine("Out Of Border Command");
                }
                else
                {
                    Console.WriteLine($"{Rovers[i].XPoint} {Rovers[i].YPoint} {Rovers[i].Direction}");
                }
            }
        }

    }
}
