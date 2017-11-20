using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discounts.DBModel;
using Discounts.Discounts;

namespace Discounts.PartnerApi
{
    public class DiscountApi : IDiscountApi
    {
        private DiscountService discountService;
        public DiscountApi(DiscountService disService)
        {
            this.discountService = disService;
        }
        public List<Discount> fetchAllDiscounts()
        {
            return discountService.getDiscounts();
        }

        public List<Discount> fetchDiscounts(Restaurant restaurant)
        {
            return discountService.getDiscounts(restaurant);
        }

        public Discount getDiscount(Item item)
        {
            return discountService.getDiscount(item);
        }
    }
}
