namespace EmployeeWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FULL_TIME = 1;
            Random random = new Random();
            int empCheck=random.Next(0,2);
            int wagesPerHour = 20;
            int workHour=0, empWages=0;
            if(empCheck==FULL_TIME)
            {
                workHour = 8;

            }
            else
            {
                workHour = 0;
            }
            empWages = workHour * wagesPerHour;

            Console.WriteLine("Employee Daily Wages: " + empWages);
            
            
        }
    }
}