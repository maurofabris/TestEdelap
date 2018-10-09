using Microsoft.VisualStudio.TestTools.UnitTesting;
using BikeRental;

namespace BikeRentalTest
{
    [TestClass]
    public class RentalTest
    {
        [TestMethod]
        public void ByHourGetPriceReturns5()
        {
            decimal price = 5;

            Rental rental = new HourlyRental();

            Assert.AreEqual(rental.Price, price);

        }
        [TestMethod]
        public void ByDayGetPriceReturns20()
        {
            decimal price = 20;

            Rental rental = new DailyRental();

            Assert.AreEqual(rental.Price, price);

        }
        [TestMethod]
        public void ByWeekGetPriceReturns60()
        {
            decimal price = 60;

            Rental rental = new WeeklyRental();

            Assert.AreEqual(rental.Price, price);

        }
        [TestMethod]
        public void ActualRentalReturnsTotal()
        {
            decimal total = (5 + 20 + 60);

            ActualRental actual = new ActualRental();
                       
            actual.AddRental(new HourlyRental());
            actual.AddRental(new DailyRental());
            actual.AddRental(new WeeklyRental());

            Assert.AreEqual(actual.GetTotal(), total);

        }
        [TestMethod]
        public void PromoRentalReturnsDiscount30PercentOfTotal()
        {
            decimal total = (5 + 20 + 60) * (decimal)0.7;

            ActualRental actual = new ActualRental();

            actual.AddRental(new DailyRental());
            actual.AddRental(new HourlyRental());
            actual.AddRental(new WeeklyRental());


            Assert.AreEqual(actual.GetPromo(), total);

        }
        [TestMethod]
        public void PromoRentalLessThan3ReturnsTotalWithoutDiscount()
        {
            decimal total = (5 + 60);

            ActualRental actual = new ActualRental();

            actual.AddRental(new HourlyRental());
            actual.AddRental(new WeeklyRental());


            Assert.AreEqual(actual.GetPromo(), total);

        }
        [TestMethod]
        public void PromoRentalMoreThan5ReturnsTotalWithoutDiscount()
        {
            decimal total = 60 * 6;

            ActualRental batch = new ActualRental();

            batch.AddRental(new WeeklyRental());
            batch.AddRental(new WeeklyRental());
            batch.AddRental(new WeeklyRental());
            batch.AddRental(new WeeklyRental());
            batch.AddRental(new WeeklyRental());
            batch.AddRental(new WeeklyRental());


            Assert.AreEqual(batch.GetPromo(), total);

        }
    }
}