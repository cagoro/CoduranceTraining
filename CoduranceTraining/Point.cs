namespace CoduranceTraining
{
    public class Point
    {
        public readonly int _x;
        private readonly int _y;
        private readonly char _direction;

        public Point(int x, int y, char direction)
        {
            _x = x;
            _y = y;
            _direction = direction;
        }

        public int X
        {
            get { return _x; }
        }

        public int Y
        {
            get { return _y; }
        }

        public char Direction
        {
            get { return _direction; }
        }
    }
}