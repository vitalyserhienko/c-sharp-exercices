using AmazonPrime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{

    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            AmazonPrime.RateCalculator calculator = new RateCalculator();
            //var rating = customer.CalculateRating();
        }
    }
}
