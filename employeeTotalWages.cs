namespace EmployeeTotalWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int PART_TIME = 1;
            const int FULL_TIME = 2;
            const int MAX_WORK_MONTH = 10;
            const int WORK_DAYS = 20;
            int wagePerHours=20, workHour = 0, totHours = 0, totWorkDays = 0, totWages=0;
            

            while(workHour <= WORK_DAYS  && totWorkDays<= MAX_WORK_MONTH)
            {
                Random random = new Random();
                int empCheck = random.Next(0,3);
                totWorkDays++;
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

                totHours = totHours + workHour;
            }
            Console.WriteLine("Employee Total Days: " + totWorkDays);
            Console.WriteLine("Employee Total Work Hours:" + workHour);
            totWages = totHours * wagePerHours;
            Console.WriteLine("Employee Total Wages: " + totWages);
            
        }
    }
}