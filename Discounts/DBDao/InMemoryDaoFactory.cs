using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discounts.DBDao.DaoInterface;
using Discounts.DBDao.InMemory;

namespace Discounts.DBDao
{
    class InMemoryDaoFactory : DaoFactory
    {
        public override IBaseDao GetDao(Dao dao)
        {
            IBaseDao baseDao = null;
            if (this.daoMap.TryGetValue(dao, out baseDao))
            {
                return baseDao;
            }

            switch (dao) {
                case Dao.Restaurant:
                    baseDao = new InMemoryRestaurantDao();
                    break;
                case Dao.Item:
                    baseDao = new InMemoryItemDao();
                    break;
                case Dao.ItemCategory:
                    baseDao = new InMemoryItemCategoryDao();
                    break;
                case Dao.Disount:
                    baseDao = new InMemoryDiscountDao();
                    break;
                case Dao.DiscountType:
                    baseDao = new InMemoryDiscountTypeDao();
                    break;
                default:
                    return null;
            }

            daoMap.Add(dao, baseDao);

            return baseDao;
        }
    }
}
