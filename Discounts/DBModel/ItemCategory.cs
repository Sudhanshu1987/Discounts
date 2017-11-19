namespace Discounts.DBModel
{
    public class ItemCategory : Entity
    {
        private string categoryName;

        public string CategoryName
        {
            get
            {
                return categoryName;
            }

            set
            {
                categoryName = value;
            }
        }
    }
}