using Discounts.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts.Partner
{
    public abstract class AbstractRestaurantPartner
    {
        public abstract void setDiscount(Item item, DiscountType type, double value);
        public abstract void setDiscount(List<Item> items, DiscountType type, double value);
        public abstract void setDiscount(ItemCategory itemCategory);
        public abstract void removeDiscount(Item item);
        public abstract void removeDiscount(List<Item> items);
        public abstract void remmoveDiscount(ItemCategory itemCategory);
    }
}
