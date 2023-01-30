using System.IO;
using System.Text;
using ToyRobot.Commands;
using ToyRobot.Model;
using ToyRobot.Model.Enums;

namespace ToyRobot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Execute("C:\\Users\\RumpiGuha\\source\\repos\\Practice\\ToyRobot\\Resources\\Input");
        }

        public static void Execute(string targetDirectory)
        {
            var context = new ExecuteContext()
            {
                Robot = new Robot(),
                NewPosition = null
            };

            foreach (string file in Directory.GetFiles(targetDirectory))
            {
                try
                {
                    Console.WriteLine($"Output for {Path.GetFileName(file)} : ");
                    var lines = File.ReadLines(file);
                    foreach (var command in lines)
                    {

                        try
                        {
                            var cmd = CommandFactory.Build(command.ToUpper());

                            if (cmd != null)
                            {
                                if (cmd is PlaceCommand placeCmd)
                                {
                                    placeCmd.position.Direction = placeCmd.position.Direction ?? context.Robot.position.Direction;
                                    context.NewPosition = placeCmd.position;
                                }

                                cmd.Execute(context);
                            }

                        }
                        catch (InvalidOperationException ex)
                        {
                            //TODO Log Error
                            Console.WriteLine(ex.Message);
                        }

                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }
    }
}