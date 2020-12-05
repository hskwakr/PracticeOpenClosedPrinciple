using Xunit;
using PracticeOpenClosedPrinciple.Sample3.AfterOCP;

namespace Test.Sample3.AfterOCP
{
    public class TestScreenSpecification
    {
        public class IsSatisfiedMethod
        {
            [Fact]
            public void IsSatisfied_Calculated()
            {
                Screen screen = Screen.CurvedScreen;
                ScreenSpecification actual = new ScreenSpecification(screen);

                ComputerMonitor data = new ComputerMonitor
                {
                    Name = "A1",
                    Screen = Screen.CurvedScreen,
                    Type = MonitorType.LCD
                };
                Assert.True(actual.IsSatisfied(data));
            }
        }
    }
}
