using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discounts.DBModel;
using Discounts.Discounts;

namespace Discounts.Partner
{
    class RestaurantPartner : AbstractRestaurantPartner
    {
        private Restaurant restaurant;
        private DiscountService discountService;

        //The RestaurantPartnerInterface taks to the discountService to set discounts
        public RestaurantPartner(Restaurant restaurant, DiscountService disService)
        {
            this.restaurant = restaurant;
            this.discountService = disService;
        }
        public override void setDiscount(Item item, DiscountType type, double value)
        {
            discountService.setDiscount(this.restaurant, item, type, value);
        }

        public override void setDiscount(List<Item> items, DiscountType type, double value)
        {
            throw new NotImplementedException();
        }

        public override void setDiscount(ItemCategory itemCategory)
        {
            throw new NotImplementedException();
        }

        public override void removeDiscount(Item item)
        {
            throw new NotImplementedException();
        }

        public override void removeDiscount(List<Item> items)
        {
            throw new NotImplementedException();
        }

        public override void remmoveDiscount(ItemCategory itemCategory)
        {
            throw new NotImplementedException();
        }
    }
}
