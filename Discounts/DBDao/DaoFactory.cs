using Discounts.DBDao.DaoInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts.DBDao
{
    public abstract class DaoFactory
    {
        protected readonly Dictionary<Dao, IBaseDao> daoMap = new Dictionary<Dao, IBaseDao>();
        public abstract IBaseDao GetDao(Dao dao);
    }
}
