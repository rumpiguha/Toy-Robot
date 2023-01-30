using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobot.Model;
using ToyRobot.Model.Enums;

namespace ToyRobot.Commands
{
    public class MoveCommand : ICommand
    {
        public void Execute(ExecuteContext context)
        {
            if (context.Robot.position != null)
            {
                int x = context.Robot.position.X, y = context.Robot.position.Y;

                switch (context.Robot.position.Direction)
                {
                    case Direction.NORTH:
                        y += 1;
                        break;
                    case Direction.SOUTH:
                        y -= 1;
                        break;
                    case Direction.EAST:
                        x += 1;
                        break;
                    case Direction.WEST:
                        x -= 1;
                        break;

                }
                var newPosition = new Position(x, y, context.Robot.position.Direction);
                if (newPosition.IsValid())
                    context.Robot.position = newPosition;

            }

        }
    }
}
