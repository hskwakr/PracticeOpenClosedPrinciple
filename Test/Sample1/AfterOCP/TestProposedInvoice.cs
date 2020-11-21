using Xunit;
using PracticeOpenClosedPrinciple.Sample1.AfterOCP;

namespace Test.Sample1.AfterOCP
{
    public class TestProposedInvoice
    {
        public class GetInvoiceDiscountMethod
        {
            [Fact]
            public void GetInvoiceDiscount_Calculated()
            {
                IInvoice invoice = new ProposedInvoice();
                double amount = 200;
                double actual = invoice.GetInvoiceDiscount(amount);

                double expected = 150;
                Assert.Equal(expected, actual);
            }
        }
    }
}
