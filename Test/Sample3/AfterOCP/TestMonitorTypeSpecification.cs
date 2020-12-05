using Xunit;
using PracticeOpenClosedPrinciple.Sample3.AfterOCP;
using System;
using System.Collections.Generic;

namespace Test.Sample3.AfterOCP
{
    public class TestMonitorTypeSpecification
    {
        public class IsSatisfiedMethod
        {
            [Fact]
            public void IsSatisfied_Calculated()
            {
                MonitorType type = MonitorType.LED;
                MonitorTypeSpecification actual = new MonitorTypeSpecification(type);

                ComputerMonitor data = new ComputerMonitor
                {
                    Name = "B1",
                    Screen = Screen.WideScreen,
                    Type = MonitorType.LCD
                };
                Assert.True(actual.IsSatisfied(data));
            }
        }
    }
}
