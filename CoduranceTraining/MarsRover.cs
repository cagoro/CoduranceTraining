namespace CoduranceTraining
{
    public class MarsRover
    {
        public string Move(string command)
        {
            return string.Format("0,{0},N", command.Length);
        }
    }
}
