namespace MovieRentalStore.Refactored.PriceCodes
{
    public class NewReleasesPriceCode : IPriceCode
    {
        public double CalculateCharge(int daysRented)
        {
            var rentalCostPerDay = 3;
            var totalRentalFee = rentalCostPerDay * daysRented;
            return totalRentalFee;
        }
    }
}