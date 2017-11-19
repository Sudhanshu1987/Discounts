using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts.DBModel
{
    public class Item
    {
        private string itemId;
        private string restautantId;
        private double price;
        private string itemName;
        private string itemDesc;
        private ItemCategory itemCategory;

        public string ItemId
        {
            get
            {
                return itemId;
            }

            set
            {
                itemId = value;
            }
        }

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

        public ItemCategory ItemCategory
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
