using Discounts.DBDao.DaoInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discounts.DBModel;

namespace Discounts.DBDao.Jdbc
{
    public class JdbcBaseDao : IBaseDao
    {
        //Todo: this is placeholder class. can add different Dao implementation like this.
        public bool delete(Entity item)
        {
            throw new NotImplementedException();
        }

        public Entity findByEntityId(long entityId)
        {
            throw new NotImplementedException();
        }

        public bool save(Entity item)
        {
            throw new NotImplementedException();
        }

        public bool update(Entity item)
        {
            throw new NotImplementedException();
        }
    }
}
