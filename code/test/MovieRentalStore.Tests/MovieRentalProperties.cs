using System;
using FsCheck;
using FsCheck.Xunit;
using MovieRentalStore.Refactored;
using MovieRentalStore.Tests.TestUtils;
using Xunit;

namespace MovieRentalStore.Tests
{
    public class MovieRentalProperties
    {
        [Property]
        public Property refactored_code_should_calculate_charge_equal_to_old_code(PositiveInt daysRented, MovieRentalPriceCode priceCode)
        {
            var customerForLegacyCode = new FakeCustomer();
            var customerForRefactoredCode = new FakeCustomer();
            var legacyMovieRental = new MovieRental(daysRented.Get, priceCode);
            var refactoredMovieRental = new MovieRentalRefactored(daysRented.Get, priceCode);

            legacyMovieRental.Charge(customerForLegacyCode);
            refactoredMovieRental.Charge(customerForRefactoredCode);

            return (customerForRefactoredCode.GetChargedAmount() == customerForLegacyCode.GetChargedAmount()).ToProperty();
        }
    }
}
