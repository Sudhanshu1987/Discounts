﻿using Discounts.DBDao.DaoInterface;
using Discounts.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts.DBDao.InMemory
{
    public class InMemoryItemCategoryDao : InmemoryBaseDao, IItemCategoryDao
    {
        public InMemoryItemCategoryDao() : base()
        {
        }
    }
}
