using System.ComponentModel;
using MovieRentalStore.Refactored.PriceCodes;

namespace MovieRentalStore.Refactored
{
    public class PriceCodeFactory
    {
        public static IPriceCode CalculateCharge(MovieRentalPriceCode priceCode)
        {
            return priceCode switch
            {
                MovieRentalPriceCode.Regular => new RegularPriceCode(),
                MovieRentalPriceCode.NewRelease => new NewReleasesPriceCode(),
                MovieRentalPriceCode.Children => new ChildrenPriceCode(),
                _ => throw new InvalidEnumArgumentException()
            };
        }
    }
}