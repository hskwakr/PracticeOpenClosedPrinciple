using Xunit;
using PracticeOpenClosedPrinciple.Sample2.BeforeOCP;
using System.Collections.Generic;

namespace Test.Sample2.BeforeOCP
{
    public class TestSalaryCalculator
    {
        public class CalculateTotalSalariesMethod
        {
            [Fact]
            public void CalculateTotalSalaries_Calculated()
            {
                List<DeveloperReport> data = new List<DeveloperReport>
                {
                    new DeveloperReport{ Id = 1, Name = "ho", Level = "Junior", HourlyRate = 1.0, WorkingHours = 100 },
                    new DeveloperReport{ Id = 2, Name = "so", Level = "Senior", HourlyRate = 0.5, WorkingHours = 200 },
                    new DeveloperReport{ Id = 3, Name = "ka", Level = "Junior", HourlyRate = 2.0, WorkingHours = 50 },
                    new DeveloperReport{ Id = 4, Name = "wa", Level = "Senior", HourlyRate = 2.5, WorkingHours = 40 }
                };

                SalaryCalculator calc = new SalaryCalculator(data);

                double actual = calc.CalculateTotalSalaries();
                double expected = 400D;
                Assert.Equal(expected, actual);
            }
        }
    }
}
