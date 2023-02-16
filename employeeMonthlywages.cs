namespace employeeMonthlyWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int TOTAL_WORK_DAYS = 20;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            int wagesPerHour = 20;
            int workHour = 0, empWages = 0, totwages = 0;
            for (int day = 0; day < TOTAL_WORK_DAYS; day++)
            {
                switch (empCheck)
                {

                    case FULL_TIME:
                        workHour = 8;
                        break;
                    case PART_TIME:
                        workHour = 4;
                        break;
                    default:
                        workHour = 0;
                        break;
                }

                empWages = workHour * wagesPerHour;
                totwages = totwages + empWages;


            }
            Console.WriteLine("Employee Daily Wages: " + empWages);
            Console.WriteLine("Employee Total Wages: " + totwages);



        }
    }
}