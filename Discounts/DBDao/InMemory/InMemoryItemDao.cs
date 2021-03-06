﻿using Discounts.DBDao.DaoInterface;
using Discounts.DBModel;
using Discounts.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts.DBDao.InMemory
{
    public class InMemoryItemDao : InmemoryBaseDao, IItemDao
    {
        public InMemoryItemDao() : base()
        {
        }
        public List<Entity> FetchAll()
        {
            return this.Entities;
        }
    }
}
