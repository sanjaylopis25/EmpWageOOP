using System;

namespace EmpWageOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject empWageBuilder = new EmpWageBuilderObject();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total wage for Dmart Company :"+empWageBuilder.getTotalWage("Dmart"));
        }
    }
}
