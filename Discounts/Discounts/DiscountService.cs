using Discounts.DBDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discounts.DBModel;
using Discounts.DBDao.DaoInterface;

namespace Discounts.Discounts
{
    class DiscountService
    {
        private DaoFactory daoFactory;

        public DiscountService( DaoFactory daoFactory)
        {
            this.daoFactory = daoFactory;
        }

        internal void setDiscount(Restaurant restaurant, Item item, DiscountType type, double value)
        {
            var discountDao = (IDiscountDao) daoFactory.GetDao(Dao.Disount);
            var discountOnItem = (Discount) discountDao.GetDiscount(restaurant.Id, item.Id);
            if(discountOnItem != null)
            {
                discountOnItem.DiscountTypeId = type.Id;
                discountOnItem.DiscountValue = value;
                //In our case probably below call is redundant since it is InMemory and the reference is to the same object.
                discountDao.update(discountOnItem);
            }
            else
            {
                discountOnItem = new Discount
                {
                    DiscountDesc = string.Empty,
                    DiscountValue = value,
                    DiscountTypeId = type.Id,
                    EndTime = new DateTime(),
                    StartTime = new DateTime(),
                    ItemId = item.Id,
                    RestaurantId = restaurant.Id
                };
                discountDao.save(discountOnItem);
            }
        }
    }
}
