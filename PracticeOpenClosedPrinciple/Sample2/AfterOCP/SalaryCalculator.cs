using System.Collections.Generic;

namespace PracticeOpenClosedPrinciple.Sample2.AfterOCP
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<BaseSalaryCalculator> _developerCalculation;

        public SalaryCalculator(List<BaseSalaryCalculator> developerCalculation)
        {
            _developerCalculation = developerCalculation;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var devCalc in _developerCalculation)
            {
                totalSalaries += devCalc.CalculateSalary();
            }

            return totalSalaries;
        }
    }
}
