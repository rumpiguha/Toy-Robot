using System;
using ToyRobot.Model;

namespace ToyRobot.Commands
{
    public interface ICommand
    {
        public void Execute(ExecuteContext context);
    }
}
