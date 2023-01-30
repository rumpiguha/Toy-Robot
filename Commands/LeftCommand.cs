using ToyRobot.Helper;
using ToyRobot.Model;
using ToyRobot.Model.Enums;

namespace ToyRobot.Commands
{
    public class LeftCommand : ICommand
    {
        public void Execute(ExecuteContext context)
        {
            var robotPosition = context.Robot.position;
            if (robotPosition != null)
            {
                var mapping = new Dictionary<Direction, Direction>()
                            {
                                { Direction.NORTH, Direction.WEST },
                                { Direction.WEST, Direction.SOUTH },
                                { Direction.SOUTH, Direction.EAST },
                                { Direction.EAST, Direction.NORTH }
                            };


                context.Robot.position = new Position(robotPosition.X,
                    robotPosition.Y, Mapper.MapState(mapping, (Direction)robotPosition.Direction));
            }

        }
    }
}
