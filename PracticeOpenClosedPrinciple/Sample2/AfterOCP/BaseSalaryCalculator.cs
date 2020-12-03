namespace PracticeOpenClosedPrinciple.Sample2.AfterOCP
{
    public abstract class BaseSalaryCalculator
    {
        protected DeveloperReport Report { get; private set; }

        public BaseSalaryCalculator(DeveloperReport report)
        {
            Report = report;
        }

        public abstract double CalculateSalary();
    }
}
