using System.Collections.Generic;
using System.Linq;

namespace PracticeOpenClosedPrinciple.Sample3.AfterOCP
{
    public class MonitorFilter : IFilter<ComputerMonitor>
    {
        public List<ComputerMonitor> Filter(IEnumerable<ComputerMonitor> monitors, ISpecification<ComputerMonitor> specification)
        {
            return monitors.Where(m => specification.IsSatisfied(m)).ToList();
        }
    }
}
