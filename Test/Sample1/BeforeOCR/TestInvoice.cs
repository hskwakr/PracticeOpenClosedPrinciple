using Xunit;
using PracticeOpenClosedPrinciple.Sample1.BeforeOCP;

namespace Test.Sample1
{
    public class TestInvoice
    {
        public class GetInvoiceDiscountMethod
        {
            [Fact]
            public void GetInvoiceDiscount_OnFinalInvoice_Calculated()
            {
                Invoice invoice = new Invoice();
                double amount = 200;
                double actual = invoice.GetInvoiceDiscount(amount, InvoiceType.FinalInvoice);

                double expected = 100;
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void GetInvoiceDiscount_OnProposedInvoice_Calculated()
            {
                Invoice invoice = new Invoice();
                double amount = 200;
                double actual = invoice.GetInvoiceDiscount(amount, InvoiceType.ProposedInvoice);

                double expected = 150;
                Assert.Equal(expected, actual);
            }
        }
    }
}
