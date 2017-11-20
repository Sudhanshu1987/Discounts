using Discounts.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts.PartnerApi
{
    public interface IRestaurantPartner
    { 
        void setDiscount(Item item, DiscountType type, double value);
        void setDiscount(DiscountType type, double value);
        void setDiscount(ItemCategory itemCategory);
        void removeDiscount(Item item);
        void removeDiscount(List<Item> items);
        void remmoveDiscount(ItemCategory itemCategory);
    }
}
