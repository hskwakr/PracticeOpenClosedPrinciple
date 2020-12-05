using System.Collections.Generic;
using System.Linq;

namespace PracticeOpenClosedPrinciple.Sample3.BeforeOCP
{
    public class MonitorFilter
    {
        public List<ComputerMonitor> FilfterByType(IEnumerable<ComputerMonitor> monitors, MonitorType type)
        {
            return monitors.Where(m => m.Type == type).ToList();
        }
    }
}
