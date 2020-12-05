using System.Collections.Generic;

namespace PracticeOpenClosedPrinciple.Sample3.AfterOCP
{
    public interface IFilter<T>
    {
        List<T> Filter(IEnumerable<T> monitors, ISpecification<T> specification);
    }
}
