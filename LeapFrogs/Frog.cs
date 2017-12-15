using System;

namespace LeapFrogs
{
    public class Frog
    {
        private int _position;

        public Frog(Direction direction, int position)
        {
            this.Direction = Direction;
            this.Position = position;
        }

        public Direction Direction { get; set; }

        public int Position
        {
            get => _position;
            set
            {
                if (value < 0)
                    throw new FormatException("The position of a frog must be positive.");

                _position = value;
            }
        }

        public bool IsValidMove(int positionTo)
        {
            

            return false;
        }

        public override string ToString()
        {
            var result = string.Empty;

            switch (this.Direction)
            {
                case Direction.Left:
                    result = "<";
                    break;
                case Direction.Right:
                    result = ">";
                    break;
            }

            return result;
        }
    }

    public enum Direction
    {
        Left,
        Right
    }
}
