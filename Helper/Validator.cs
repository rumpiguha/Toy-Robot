using ToyRobot.Model.Enums;
using System.Text.RegularExpressions;

namespace ToyRobot.Helper
{
    public class Validator
    {
        public static bool IsValidCommand(string command)
        {
            var commands = Enum.GetNames(typeof(Command));
            return IsValidPlaceCommand(command) || commands.Where(cmd => cmd != Command.PLACE.ToString()).Any(c => c.Contains(command));
        }

        private static bool IsValidPlaceCommand(string command)
        {

            if (!Regex.IsMatch(command, "^PLACE\\s{1}\\d+,\\d+(,\\D+)?"))
            {
                return false;
            }

            // Example : ["1","2","EAST"]
            string[] positionArr = command.Split(" ")[1].Split(",");

            var directions = Enum.GetNames(typeof(Direction));
            if (positionArr.Length == 3 && !string.IsNullOrEmpty(positionArr[2]))
                return int.TryParse(positionArr[0], out _) && int.TryParse(positionArr[0], out _) && directions.Contains(positionArr[2]);
            else
                return int.TryParse(positionArr[0], out _) && int.TryParse(positionArr[0], out _);

        }

    }
}
