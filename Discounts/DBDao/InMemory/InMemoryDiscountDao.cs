using Discounts.DBDao.DaoInterface;
using Discounts.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts.DBDao.InMemory
{
    public class InMemoryDiscountDao : InmemoryBaseDao, IDiscountDao
    {
        public List<Entity> FetchAll()
        {
            return this.Entities;
        }

        public bool UpdateAll(List<Entity> entities)
        {
            this.Entities.RemoveAll(x => entities.Any(y => y.Id == x.Id));
            entities.All(x => this.update(x));
            return true;
        }

        public Entity GetDiscount(string itemId, string restaurantId)
        {
            var discounts = this.Entities.Cast<DBModel.Discount>();
            var discountonParticularRestaurantItem = discounts.Where(x => x.ItemId.Equals(itemId) && x.RestaurantId.Equals(restaurantId)).FirstOrDefault();
            return discountonParticularRestaurantItem;
        }

        public Entity GetDiscount(string itemId)
        {
            var discounts = this.Entities.Cast<DBModel.Discount>();
            var discountonParticularRestaurantItem = discounts.Where(x => x.ItemId.Equals(itemId)).FirstOrDefault();
            return discountonParticularRestaurantItem;
        }
    }
}
