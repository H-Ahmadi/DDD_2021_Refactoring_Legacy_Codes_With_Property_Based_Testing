using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalStore
{
    public interface IPayingCustomer
    {
        void Charge(double amountCharged);
    }
}
