using Xunit;
using PracticeOpenClosedPrinciple.Sample3.AfterOCP;
using System;
using System.Collections.Generic;

namespace Test.Sample3.AfterOCP
{
    public class TestMonitorFilter
    {
        public class Mock : ISpecification<ComputerMonitor>
        {
            public bool IsSatisfied(ComputerMonitor item)
            {
                return true;
            }
        }

        public class FilterMethod
        {
            [Fact]
            public void Filter_OnProper_Calculated()
            {

                List<ComputerMonitor> data = new List<ComputerMonitor>
                {
                    new ComputerMonitor{ Name = "A1", Screen = Screen.CurvedScreen, Type = MonitorType.LCD },
                    new ComputerMonitor{ Name = "A2", Screen = Screen.CurvedScreen, Type = MonitorType.LED },
                    new ComputerMonitor{ Name = "A3", Screen = Screen.CurvedScreen, Type = MonitorType.OLED },
                    new ComputerMonitor{ Name = "B1", Screen = Screen.WideScreen, Type = MonitorType.LCD },
                    new ComputerMonitor{ Name = "B2", Screen = Screen.WideScreen, Type = MonitorType.LED },
                    new ComputerMonitor{ Name = "B3", Screen = Screen.WideScreen, Type = MonitorType.OLED }
                };

                MonitorFilter filter = new MonitorFilter();

                List<ComputerMonitor> actual = filter.Filter(data, new Mock());
                Assert.Equal(data, actual);
            }
        }
    }
}
