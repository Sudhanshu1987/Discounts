using Discounts.DBDao.DaoInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discounts.DBModel;
using Discounts.Exceptions;

namespace Discounts.DBDao.InMemory
{
    public class InmemoryBaseDao : IBaseDao
    {
        protected List<Entity> Entities = new List<Entity>();

        public virtual bool delete(Entity Entity)
        {
            if (Entities.Any(x => x.Id == Entity.Id))
            {
                var EntitytoRemoved = Entities.Where(x => x.Id == Entity.Id).FirstOrDefault();
                Entities.Remove(EntitytoRemoved);
                return true;
            }

            return false;
        }

        public virtual Entity findByEntityId(string Id)
        {
            return Entities.Where(x => x.Id == Id).FirstOrDefault();
        }

        public virtual bool save(Entity Entity)
        {
            if (Entities.Any(x => x.Id == Entity.Id))
            {
                throw new DuplicateObjectexception();
            }

            Entities.Add(Entity);
            return true;
        }

        public virtual bool update(Entity Entity)
        {
            if (Entities.Any(x => x.Id == Entity.Id))
            {
                delete(Entity);
                Entities.Add(Entity);
                return true;
            }

            return false;
        }
    }
}
