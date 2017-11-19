using Discounts.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts.DBDao.DaoInterface
{
    public interface IBaseDao
    {
        bool save(Entity item);
        bool update(Entity item);
        Entity findByEntityId(string entityId);
        bool delete(Entity item);
    }
}
