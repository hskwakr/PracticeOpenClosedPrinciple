namespace PracticeOpenClosedPrinciple.Sample1.AfterOCP
{
    public class FinalInvoice : IInvoice
    {
        public double GetInvoiceDiscount(double amount)
        {
            return amount - 60;
        }
    }
}
