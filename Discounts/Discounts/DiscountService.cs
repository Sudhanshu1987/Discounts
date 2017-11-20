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
    public class DiscountService
    {
        private DaoFactory daoFactory;

        public DiscountService( DaoFactory daoFactory)
        {
            this.daoFactory = daoFactory;
        }

        internal void setDiscount(Restaurant restaurant, Item item, DiscountType type, double value)
        {
            var discountDao = (IDiscountDao) daoFactory.GetDao(Dao.Disount);
            var dis = discountDao.GetDiscount(restaurant.Id, item.Id);
            if(dis != null)
            {
                var discountOnItem = (Discount)dis;
                discountOnItem.DiscountTypeId = type.Id;
                discountOnItem.DiscountValue = value;
                //In our case probably below call is redundant since it is InMemory and the reference is to the same object.
                discountDao.update(discountOnItem);
            }
            else
            {
                dis = new Discount
                {
                    DiscountDesc = string.Empty,
                    DiscountValue = value,
                    DiscountTypeId = type.Id,
                    EndTime = new DateTime(),
                    StartTime = new DateTime(),
                    ItemId = item.Id,
                    RestaurantId = restaurant.Id
                };
                discountDao.save(dis);
            }
        }

        internal Discount getDiscount(Item item)
        {
            var discountDao = (IDiscountDao)daoFactory.GetDao(Dao.Disount);
            var dis = discountDao.GetDiscount(item.Id);
            if(dis != null)
            {
                var discount = (Discount)dis;
                return discount;
            }

            return null;
        }

        internal List<Discount> getDiscounts(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public List<Discount> getDiscounts()
        {
            var discountDao = (IDiscountDao)daoFactory.GetDao(Dao.Disount);
            var entities = discountDao.FetchAll();
            return entities.Cast<Discount>().ToList();
        }

        internal void setDiscount(DiscountType type, double value)
        {
            var discountDao = (IDiscountDao)daoFactory.GetDao(Dao.Disount);
            var itemsDao = (IItemDao)daoFactory.GetDao(Dao.Item);
            var items = itemsDao.FetchAll();
            List<Discount> discounts = new List<Discount>();
            foreach(var item in items)
            {
                var it = (Item)item;
                var dis = discountDao.GetDiscount(it.Id);
                if(dis != null)
                {
                    var discountOnItem = (Discount)dis;
                    discountOnItem.DiscountTypeId = type.Id;
                    discountOnItem.DiscountValue = value;
                    //In our case probably below call is redundant since it is InMemory and the reference is to the same object.
                    discountDao.update(discountOnItem);
                }
                else
                {
                    dis = new Discount
                    {
                        DiscountDesc = string.Empty,
                        DiscountValue = value,
                        DiscountTypeId = type.Id,
                        EndTime = new DateTime(),
                        StartTime = new DateTime(),
                        ItemId = it.Id,
                        RestaurantId = it.RestautantId
                    };
                    discountDao.save(dis);
                }
            }
        }
    }
}
