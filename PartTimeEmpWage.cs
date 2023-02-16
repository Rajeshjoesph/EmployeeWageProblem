namespace PartTimeEmployeeWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FULL_TIME = 2,PART_TIME=1;
            Random random= new Random();
            int empCheck = random.Next(0, 2);
            int wagesPerHour = 20, workHour = 0, empWages = 0;
            if(PART_TIME == empCheck)
            {
                workHour= 4;
            }
            else if(FULL_TIME == empCheck){
                workHour = 8;
            }
            else
            {
                workHour = 0;
            }
            empWages = workHour * wagesPerHour;
            Console.WriteLine("Employee Daily Wages: " + empWages );
        }
    }
}