﻿namespace EmployeeAttendance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if(empCheck == IS_FULL_TIME) {
                Console.WriteLine("Employe is present");
            }
            else
            {
                Console.WriteLine("Employe is absent");
            }

        }
    }
}