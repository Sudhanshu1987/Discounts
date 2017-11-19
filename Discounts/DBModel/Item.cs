using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts.DBModel
{
    public class Item : Entity
    {
        private string restautantId;
        private double price;
        private string itemName;
        private string itemDesc;
        private string itemCategory;

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string ItemName
        {
            get
            {
                return itemName;
            }

            set
            {
                itemName = value;
            }
        }

        public string ItemCategoryId
        {
            get
            {
                return itemCategory;
            }

            set
            {
                itemCategory = value;
            }
        }

        public string RestautantId
        {
            get
            {
                return restautantId;
            }

            set
            {
                restautantId = value;
            }
        }

        public string ItemDesc
        {
            get
            {
                return itemDesc;
            }

            set
            {
                itemDesc = value;
            }
        }
    }
}
