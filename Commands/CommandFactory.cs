
using ToyRobot.Model.Enums;
using ToyRobot.Model;
using ToyRobot.Helper;


namespace ToyRobot.Commands
{
    public class CommandFactory
    {
        public static ICommand Build(string commandStr)
        {
            if (string.IsNullOrEmpty(commandStr) || !Validator.IsValidCommand(commandStr))
            {
                return null;
            }

            if (commandStr.StartsWith(Command.PLACE.ToString()))
            {
                return new PlaceCommand(Parse(commandStr.Split(" ")[1]));
            }

            _ = Command.TryParse(commandStr, out Command cmd);
            return GetCommand(cmd);

        }

        private static Position Parse(string positionStr)
        {
           var arr = positionStr.Split(",");
            if (arr.Length > 2)
            {
                _ = Enum.TryParse(arr[2], out Direction direction);
                return new Position(int.Parse(arr[0]), int.Parse(arr[1]), direction);
            }
            else
            {
                return new Position(int.Parse(arr[0]), int.Parse(arr[1]), null);
            }
        }

        public static ICommand GetCommand(Command command)
        {
            switch (command)
            {
                case Command.MOVE:
                    return new MoveCommand();
                case Command.LEFT:
                    return new LeftCommand();
                case Command.RIGHT:
                    return new RightCommand();
                case Command.REPORT:
                    return new ReportCommand();
            }
            return null;
        }
    }
}
