namespace MovieRentalStore.Tests.TestUtils
{
    public class FakeCustomer : IPayingCustomer
    {
        private double _chargedAmount;

        public void Charge(double amountCharged)
        {
            _chargedAmount += amountCharged;
        }
        public double GetChargedAmount() => _chargedAmount;
    }
}