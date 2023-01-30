using System;
using ToyRobot.Model.Enums;


namespace ToyRobot.Model
{
    public class Position
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        
        public Direction? Direction;
        
        public Position(int x, int y, Direction? direction)
        {
            this.X = x;
            this.Y = y;
            this.Direction = direction;
        }

        public bool IsValid()
        {
            return X >= 0 && Y >= 0 && X <= Grid.Length && Y <= Grid.Width;
        }

        public override string ToString()
        {
            return string.Format("%d,%d,%s", X, Y, Direction.ToString());
        }

    }
}
