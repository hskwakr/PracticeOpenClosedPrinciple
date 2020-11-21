using Xunit;
using PracticeOpenClosedPrinciple.Sample1.AfterOCP;

namespace Test.Sample1.AfterOCP
{
    public class TestFinalInvoice
    {
        public class GetInvoiceDiscountMethod
        {
            [Fact]
            public void GetInvoiceDiscount_Calculated()
            {
                IInvoice invoice = new FinalInvoice();
                double amount = 200;
                double actual = invoice.GetInvoiceDiscount(amount);

                double expected = 140;
                Assert.Equal(expected, actual);
            }
        }
    }
}
