using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobot.Model.Enums;

namespace ToyRobot.Helper
{
    public class Mapper
    {
        public static Direction MapState(IDictionary<Direction, Direction> mapping, Direction newDirection)
        {
            return mapping[newDirection];
        }
    }
}
