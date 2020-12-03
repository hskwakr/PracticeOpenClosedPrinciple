namespace PracticeOpenClosedPrinciple.Sample2.AfterOCP
{
    public class SeniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public SeniorDevSalaryCalculator(DeveloperReport report)
            : base(report)
        { }

        public override double CalculateSalary()
        {
            return Report.HourlyRate * Report.WorkingHours * 1.2;
        }
    }
}
