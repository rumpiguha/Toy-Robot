using System.Threading;
using ToyRobot.Model;

namespace ToyRobot.Commands
{
    public class PlaceCommand : ICommand
    {
        public Position position { get; private set; }

        public PlaceCommand(Position position)
        {
            this.position = position;
        }

        public void Execute(ExecuteContext context)
        {
            if (context.NewPosition.IsValid())
            {
                context.Robot.position = context.NewPosition;
                context.NewPosition = null;
            }
           
        }

    }

}
