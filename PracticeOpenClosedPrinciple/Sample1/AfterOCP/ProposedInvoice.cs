namespace PracticeOpenClosedPrinciple.Sample1.AfterOCP
{
    public class ProposedInvoice : IInvoice
    {
        public double GetInvoiceDiscount(double amount)
        {
            return amount - 50;
        }
    }
}
