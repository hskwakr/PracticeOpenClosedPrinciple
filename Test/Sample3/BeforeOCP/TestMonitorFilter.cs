using Xunit;
using PracticeOpenClosedPrinciple.Sample3.BeforeOCP;
using System.Collections.Generic;
using System;

namespace Test.Sample3.BeforeOCP
{
    public class TestMonitorFilter
    {
        public class FilfterByTypeMethod
        {
            [Fact]
            public void FilfterByType_OnProper_Calculated()
            {
                MonitorType type = MonitorType.LED;

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
                
                List<ComputerMonitor> actual = filter.FilfterByType(data, type);
                
                Predicate<ComputerMonitor> filterType = (x) => x.Type == type;
                Assert.Contains<ComputerMonitor>(actual, filterType);
            }
        }
    }
}
