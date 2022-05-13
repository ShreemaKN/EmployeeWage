namespace EmployeeWage
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("welcome to employee wage computation program");
            EmployeePresentorAbsent E = new EmployeePresentorAbsent();
            E.Attendance();
            EmployeeWage E1 = new EmployeeWage();
            E1.wage();
            PartTimeorFullTime T = new PartTimeorFullTime();
            T.CheckEmpFullOrPartTime();
            SwitchCase SC = new SwitchCase();
            SC.EmpWageSwitchCase();
        }

    }
}