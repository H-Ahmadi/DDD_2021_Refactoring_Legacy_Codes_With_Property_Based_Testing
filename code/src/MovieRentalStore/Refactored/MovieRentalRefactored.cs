namespace MovieRentalStore.Refactored
{
    public class MovieRentalRefactored
    {
        private readonly int DaysRented;
        private readonly MovieRentalPriceCode PriceCode;
        public MovieRentalRefactored(int daysRented, MovieRentalPriceCode movieRentalPriceCode)
        {
            DaysRented = daysRented;
            PriceCode = movieRentalPriceCode;
        }
        public void Charge(IPayingCustomer customer)
        {
            var priceCode = PriceCodeFactory.CalculateCharge(this.PriceCode);
            var charge = priceCode.CalculateCharge(this.DaysRented);
            customer.Charge(charge);
        }
    }
}
