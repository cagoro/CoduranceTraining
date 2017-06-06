namespace CoduranceTraining
{
    public class MarsRover
    {
        public string Move(string command)
        {
            if (command == "M")
            {
                return "0,1,N"; 
            }

            return "0,0,N";
        }
    }
}
