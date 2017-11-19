using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts.DBModel
{
    public class Discount : Entity
    {
        private string itemId;
        private string restaurantId;
        private DateTime startTime;
        private DateTime endTime;
        private string discountTypeId;
        private double discountValue;
        private string discountDesc;

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

        public string RestaurantId
        {
            get
            {
                return restaurantId;
            }

            set
            {
                restaurantId = value;
            }
        }

        public DateTime StartTime
        {
            get
            {
                return startTime;
            }

            set
            {
                startTime = value;
            }
        }

        public DateTime EndTime
        {
            get
            {
                return endTime;
            }

            set
            {
                endTime = value;
            }
        }

        public string DiscountTypeId
        {
            get
            {
                return discountTypeId;
            }

            set
            {
                discountTypeId = value;
            }
        }

        public double DiscountValue
        {
            get
            {
                return discountValue;
            }

            set
            {
                discountValue = value;
            }
        }

        public string DiscountDesc
        {
            get
            {
                return discountDesc;
            }

            set
            {
                discountDesc = value;
            }
        }
    }
}
