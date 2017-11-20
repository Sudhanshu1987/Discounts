using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discounts.DBModel;
using Discounts.Discounts;

namespace Discounts.PartnerApi
{
    public class RestaurantPartner : IRestaurantPartner
    {
        private Restaurant restaurant;
        private DiscountService discountService;

        //The RestaurantPartnerInterface taks to the discountService to set discounts
        public RestaurantPartner(Restaurant restaurant, DiscountService disService)
        {
            this.restaurant = restaurant;
            this.discountService = disService;
        }

        public void setDiscount(Item item, DiscountType type, double value)
        {
            discountService.setDiscount(this.restaurant, item, type, value);
        }

        public void setDiscount(DiscountType type, double value)
        {
            discountService.setDiscount(type, value);
        }

        //Todo: To be implemented
        public void setDiscount(ItemCategory itemCategory)
        {
            throw new NotImplementedException();
        }

        public void removeDiscount(Item item)
        {
            throw new NotImplementedException();
        }

        public void removeDiscount(List<Item> items)
        {
            throw new NotImplementedException();
        }

        public void remmoveDiscount(ItemCategory itemCategory)
        {
            throw new NotImplementedException();
        }
    }
}
