using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts.DBModel
{
    public abstract class  Entity
    {
        private string id = Guid.NewGuid().ToString().GetHashCode().ToString("x");

        public virtual string Id
        {
            get
            {
                return id;
            }
        }
    }
}
