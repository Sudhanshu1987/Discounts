using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discounts.DBDao.DaoInterface;

namespace Discounts.DBDao
{
    class JdbcDaoFactory : DaoFactory
    {
        //Place holder class. Implementation can be switched
        public override IBaseDao GetDao(Dao dao)
        {
            throw new NotImplementedException();
        }
    }
}
