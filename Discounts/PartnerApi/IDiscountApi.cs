using Discounts.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts.PartnerApi
{
    public interface IDiscountApi
    {
        List<Discount> fetchAllDiscounts();
        List<Discount> fetchDiscounts(Restaurant restaurant);
        Discount getDiscount(Item item);
    }
}
