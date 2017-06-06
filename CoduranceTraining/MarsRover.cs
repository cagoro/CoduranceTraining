namespace CoduranceTraining
{
    public class MarsRover
    {
        private readonly Point _currentPosition;
        public MarsRover(int x, int y, char direction)
        {
            _currentPosition = new Point(x,y,direction);
        }

        public string Move(string command)
        {
            if (_currentPosition.Direction == 'N')
            {
                return string.Format("0,{0},{1}", _currentPosition.Y + command.Length % 10, _currentPosition.Direction);
            }
            if (_currentPosition.Direction == 'S')
            {
                return string.Format("0,{0},{1}", _currentPosition.Y - command.Length % 10, _currentPosition.Direction);
            }
            return string.Format("{0},{1},{2}", _currentPosition.X + command.Length % 10,  _currentPosition.Y, _currentPosition.Direction);
        }
    }
}
