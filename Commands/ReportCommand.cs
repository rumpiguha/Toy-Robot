using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobot.Model;

namespace ToyRobot.Commands
{
    public class ReportCommand : ICommand
    {
        public void Execute(ExecuteContext context)
        {
            if (context.Robot.position != null)
            {
                var position = context.Robot.position;
                Console.WriteLine($"{position.X},{position.Y},{position.Direction}");
            }
        }
    }
}
