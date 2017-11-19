using Discounts.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts.DBDao.DaoInterface
{
    interface IDiscountDao : IBaseDao
    {
        List<Entity> FetchAll();
        bool UpdateAll(List<Entity> entities);
        Entity GetDiscount(string itemId, string restaurantId);        
    }
}
