namespace MovieRentalStore.Refactored.PriceCodes
{
    public abstract class PriceCodeWithDelayPenalty : IPriceCode
    {
        protected abstract int AllowedRentalDays { get; }

        public double CalculateCharge(int daysRented)
        {
            if (IsDeliveringLate(daysRented))
                return CalculateChargeWithPenalty(daysRented);
            else
                return CalculateNormalCharge(daysRented);
        }

        protected abstract double CalculateNormalCharge(int daysRented);
        protected abstract double CalculateChargeWithPenalty(int daysRented);
        protected bool IsDeliveringLate(int daysRented)
        {
            return daysRented > AllowedRentalDays;
        }
    }
}