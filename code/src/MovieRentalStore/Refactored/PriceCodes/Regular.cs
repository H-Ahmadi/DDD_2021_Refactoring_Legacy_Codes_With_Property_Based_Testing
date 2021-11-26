namespace MovieRentalStore.Refactored.PriceCodes
{
    public class RegularPriceCode : PriceCodeWithDelayPenalty
    {
        protected override int AllowedRentalDays => 2;
        private const int RentalCostPerDay = 2;
        protected override double CalculateNormalCharge(int daysRented)
        {
            return daysRented * RentalCostPerDay;
        }

        protected override double CalculateChargeWithPenalty(int daysRented)
        {
            var lateRentalDays = daysRented - AllowedRentalDays;
            var lateRentalPercentageIncrease = 1.5;
            var totalRentalFeeIncludingLateFee = AllowedRentalDays * RentalCostPerDay +
                                                 lateRentalDays * RentalCostPerDay *
                                                 lateRentalPercentageIncrease;

            return totalRentalFeeIncludingLateFee;
        }
    }
}