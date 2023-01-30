using ToyRobot.Model.Enums;
using ToyRobot.Model;
using ToyRobot.Helper;

namespace ToyRobot.Commands
{
    public class RightCommand:ICommand
    {
        public void Execute(ExecuteContext context)
        {
            var robotPosition = context.Robot.position;
            if (robotPosition != null)
            {
                var mapping = new Dictionary<Direction, Direction>()
                            {
                                { Direction.WEST, Direction.NORTH },
                                { Direction.NORTH, Direction.EAST },
                                { Direction.EAST, Direction.SOUTH },
                                { Direction.SOUTH, Direction.WEST }
                            };

                context.Robot.position = new Position(robotPosition.X,
                    robotPosition.Y, Mapper.MapState(mapping, (Direction)robotPosition.Direction));
            }

        }
    }
}
