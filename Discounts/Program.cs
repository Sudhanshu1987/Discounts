using Discounts.DBDao;
using Discounts.DBDao.DaoInterface;
using Discounts.DBModel;
using Discounts.Discounts;
using Discounts.PartnerApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializations
            //########################################################################################################
            DaoFactory daoFactory = new InMemoryDaoFactory();

            var itemDao = (IItemDao)daoFactory.GetDao(Dao.Item);
            var restaurantDao = (IRestaurantDao)daoFactory.GetDao(Dao.Restaurant);
            var itemCategoryDao = (IItemCategoryDao)daoFactory.GetDao(Dao.ItemCategory);
            var discountTypeDao = (IDiscountTypeDao)daoFactory.GetDao(Dao.DiscountType);

            DiscountType discountType = new DiscountType
            {
                DiscountTypeDesc = "percentage",
                Type = "PERCENTAGE"
            };

            discountTypeDao.save(discountType);

            Restaurant restaurant = new Restaurant
            {
                Description = "Its Pizza Hut!",
                Location = "Kormangla",
                Name = "PizzaHut",
                Menu = new List<Item>()
            };

            var itemCategory = new ItemCategory
            {
                CategoryName = "Pizza"
            };

            itemCategoryDao.save(itemCategory);

            var items = new List<Item>();

            items.Add(
                new Item
                {
                    ItemCategoryId = itemCategory.Id,
                    ItemDesc = "Thin crust mushroom Pizza",
                    ItemName = "Pizza",
                    Price = 430.0,
                    RestautantId = restaurant.Id
                }
            );

            items.Add(
                new Item
                {
                    ItemCategoryId = itemCategory.Id,
                    ItemDesc = "Thick crust Paneer Pizza",
                    ItemName = "Pizza2",
                    Price = 400.0,
                    RestautantId = restaurant.Id
                }
            );

            items.Add(
                new Item
                {
                    ItemCategoryId = itemCategory.Id,
                    ItemDesc = "Thin crust extra cheese Pizza",
                    ItemName = "Margarita",
                    Price = 400.0,
                    RestautantId = restaurant.Id
                }
            );

            items.Add(
               new Item
                {
                    ItemCategoryId = itemCategory.Id,
                    ItemDesc = "Thin crust Pizza",
                    ItemName = "Chicken Pizza",
                    Price = 500.0,
                    RestautantId = restaurant.Id
                }
            );

            items.Add(
                new Item
                {
                    ItemCategoryId = itemCategory.Id,
                    ItemDesc = "Thin crust chicken Pizza",
                    ItemName = "Chicken2 Pizza",
                    Price = 500.0,
                    RestautantId = restaurant.Id
                }
            );

            items.All(item => itemDao.save(item));

            restaurant.Menu = items;
            restaurantDao.save(restaurant);

            //#########################################################################################################

            DiscountService disServce = new DiscountService(daoFactory);
            IRestaurantPartner restaurantPartner = new RestaurantPartner(restaurant,disServce);
            IDiscountApi discountApi = new DiscountApi(disServce);

            restaurantPartner.setDiscount(items.First(), discountType, 5);
            var discounts = discountApi.fetchAllDiscounts();

            foreach(var discount in discounts)
            {
                Console.WriteLine(discount.Id + " " + discount.ItemId + " " + discount.DiscountDesc + " " + discount.DiscountValue);
            }

            restaurantPartner.setDiscount(discountType, 10);

            discounts = discountApi.fetchAllDiscounts();
            foreach (var discount in discounts)
            {
                Console.WriteLine(discount.Id + " " + discount.ItemId + " " + discount.DiscountDesc + " " + discount.DiscountValue);
            }
        }
    }
}
