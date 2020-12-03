namespace PracticeOpenClosedPrinciple.Sample2.AfterOCP
{
    public class JuniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorDevSalaryCalculator(DeveloperReport report)
            : base(report)
        { }

        public override double CalculateSalary()
        {
            return Report.HourlyRate * Report.WorkingHours;
        }
    }
}
