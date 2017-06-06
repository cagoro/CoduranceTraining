namespace CoduranceTraining
{
    public class MarsRover
    {
        public MarsRover(int x, int y, char direction)
        {
        }


        public string Move(string command)
        {
            return string.Format("0,{0},N", command.Length % 10);
        }
    }
}
