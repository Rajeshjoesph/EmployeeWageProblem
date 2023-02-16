namespace switchCaseStatement
{
    internal class Program
    {
        public const int FULL_TIME = 2;
        public const int PART_TIME = 1;
        static void Main(string[] args)
        {
            
            Random random = new Random(); 
            int empCheck=random.Next(0,3);
            int wagesPerHour = 20, workHour = 0, empWages = 0;
            switch (empCheck)
            {
                case PART_TIME:
                    workHour = 4;
                    break;
                case FULL_TIME:
                    workHour = 8;
                    break;
                default:
                    workHour = 0;
                    break;

            }
            empWages = workHour * wagesPerHour;
            Console.WriteLine("Employee wages: " + empWages);
        }
    }
}