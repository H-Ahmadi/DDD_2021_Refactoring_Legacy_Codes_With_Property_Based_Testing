namespace MovieRentalStore.Refactored.PriceCodes
{
    public interface IPriceCode
    {
        double CalculateCharge(int daysRented);
    }
}