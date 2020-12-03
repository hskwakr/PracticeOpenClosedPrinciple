using Xunit;
using PracticeOpenClosedPrinciple.Sample2.AfterOCP;
using System.Collections.Generic;

namespace Test.Sample2.AfterOCP
{
    public class TestSalaryCalculator
    {
        public class CalculateTotalSalariesMethod
        {
            [Fact]
            public void CalculateTotalSalaries_Calculated()
            {
                List<BaseSalaryCalculator> data = new List<BaseSalaryCalculator>
                {
                    new JuniorDevSalaryCalculator(new DeveloperReport{ Id = 1, Name = "ho", Level = "Junior", HourlyRate = 1.0, WorkingHours = 100 }),
                    new SeniorDevSalaryCalculator(new DeveloperReport{ Id = 2, Name = "so", Level = "Senior", HourlyRate = 0.5, WorkingHours = 200 }),
                    new JuniorDevSalaryCalculator(new DeveloperReport{ Id = 3, Name = "ka", Level = "Junior", HourlyRate = 2.0, WorkingHours = 50 }),
                    new SeniorDevSalaryCalculator(new DeveloperReport{ Id = 4, Name = "wa", Level = "Senior", HourlyRate = 2.5, WorkingHours = 40 })
                };

                SalaryCalculator calc = new SalaryCalculator(data);

                double actual = calc.CalculateTotalSalaries();
                double expected = 440D;
                Assert.Equal(expected, actual);
            }
        }
    }
}
