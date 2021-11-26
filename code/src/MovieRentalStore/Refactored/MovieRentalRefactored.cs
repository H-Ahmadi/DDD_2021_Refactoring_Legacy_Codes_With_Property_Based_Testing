namespace MovieRentalStore.Refactored
{
    public class MovieRentalRefactored
    {
        private readonly int _daysRented;
        private readonly MovieRentalPriceCode _priceCode;
        public MovieRentalRefactored(int daysRented, MovieRentalPriceCode movieRentalPriceCode)
        {
            _daysRented = daysRented;
            _priceCode = movieRentalPriceCode;
        }
        public void Charge(IPayingCustomer customer)
        {
            var priceCode = PriceCodeFactory.CalculateCharge(this._priceCode);
            var charge = priceCode.CalculateCharge(this._daysRented);
            customer.Charge(charge);
        }
    }
}
