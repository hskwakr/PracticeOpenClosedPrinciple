namespace PracticeOpenClosedPrinciple.Sample3.AfterOCP
{
    public class MonitorTypeSpecification : ISpecification<ComputerMonitor>
    {
        private readonly MonitorType _type;

        public MonitorTypeSpecification(MonitorType type)
        {
            _type = type;
        }

        public bool IsSatisfied(ComputerMonitor item)
        {
            return item.Type == _type;
        }
    }
}
