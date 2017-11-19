namespace Discounts.DBModel
{
    public class DiscountType : Entity
    {
        //Todo: Discount Type can represent the percentage discount, currency discount, one+one free discount.
        //In 3rd case we can link the rule engineId with the discounttype and discountId

        private string type;
        private string discountTypeDesc;

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string DiscountTypeDesc
        {
            get
            {
                return discountTypeDesc;
            }

            set
            {
                discountTypeDesc = value;
            }
        }
    }
}