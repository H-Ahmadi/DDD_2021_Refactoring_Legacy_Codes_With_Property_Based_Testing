namespace MovieRentalStore.Refactored.PriceCodes
{
    public class ChildrenPriceCode : PriceCodeWithDelayPenalty
    {
        private const double RentalCostPerDay = 1.5;
        protected override int AllowedRentalDays => 3;
        protected override double CalculateNormalCharge(int daysRented)
        {
            var totalRentalFee = RentalCostPerDay * daysRented;
            return totalRentalFee;
        }

        protected override double CalculateChargeWithPenalty(int daysRented)
        {
            var daysLate = daysRented - AllowedRentalDays;
            return RentalCostPerDay * AllowedRentalDays + daysLate * RentalCostPerDay * 1.5;
        }
    }
}