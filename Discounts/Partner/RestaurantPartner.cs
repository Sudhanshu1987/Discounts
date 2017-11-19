using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discounts.DBModel;

namespace Discounts.Partner
{
    class RestaurantPartner : AbstractRestaurantPartner
    {
        private Restaurant restaurant;
        public RestaurantPartner(Restaurant restaurant)
        {
            this.restaurant = restaurant;
        }
        public override void setDiscount(Item item)
        {
            
        }

        public override void setDiscount(List<Item> items)
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
