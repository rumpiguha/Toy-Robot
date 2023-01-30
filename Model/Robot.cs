using System;

namespace ToyRobot.Model
{
    public class Robot
    {
        public Position? position = null;
        public Robot()
        {

        }
        public Robot(Position position) {
        this.position = position;
        }

    }
}
