namespace PracticeOpenClosedPrinciple.Sample3.AfterOCP
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
}
