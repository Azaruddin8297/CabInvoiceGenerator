using System.IO;
using CabInvoiceGenerator;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            InvoiceGenerator invoiceGenerator;

            [TestMethod]
             void GivenDistanceAndTimeShouldReturnTotalFare()
            {

               
                invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);

                double distance = 2.0;
                int time = 5;
                double expected = 25;

                
                double fare = invoiceGenerator.CalculateFare(distance, time);

                
                Assert.AreEqual(expected, fare);


            }
            [TestMethod]
            void GivenDistanceAndTime_WhenAnalyzeFare_ShouldMultipleTotalFare()
            {
                invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);

                Ride[] rides = { new Ride(5, 2), new Ride(7, 1) };
                var expected = invoiceGenerator.CalculateFare(rides);

                var result = invoiceGenerator.CalculateFare(rides);


                Assert.AreEqual(expected, result);
            }

        }
    }
}