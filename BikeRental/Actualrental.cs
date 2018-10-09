using System;
using System.Collections.Generic;
using System.Linq;

namespace BikeRental
{
    public class ActualRental
    {
        private readonly int MinRental;
        private readonly int MaxRental;

        public List<Rental> rentals { get; set; }

        public ActualRental()
        {
            MinRental = 3;
            MaxRental = 5;
            rentals = new List<Rental>();
        }

        public void AddRental(Rental rental)
        {
            rentals.Add(rental);
        }

        public decimal GetTotal()
        {
            decimal result = 0;
            try
            {
                result = rentals.Sum(r => r.Price);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public decimal GetPromo()
        {
            decimal result = 0;
            try
            {
                result = rentals.Sum(r => r.Price);
                if (rentals.Count >= MinRental && rentals.Count <= MaxRental)
                {
                    result = result * (decimal)0.7;
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}