using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ChaiShai.Model
{
    public class ProductDatabaseInitializer :DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(c => context.Products.Add(c));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>()
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Tea"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Coffee"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Cookies"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Cakes"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Sides"
                },
            };

                return categories;
        }

        private List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Green Tea",
                    ProductDescription = "Green tea is the most popular type of tea, mainly because it is the beverage of choice in Asia. Some loose green teas are scented with flowers or mixed with fruits to create scented or flavored teas.  ", 
                    ImagePath="",
                    UnitPrice = 25,
                    CategoryID = 1
               },
               new Product
                {
                    ProductID = 2,
                    ProductName = "Black Tea",
                    ProductDescription = "Black tea is the tea most people know since you likely grew up dipping tea bags of black tea in your cup (or enjoyed this tea from an iced tea pitcher in the South).", 
                    ImagePath="carconvert.png",
                    UnitPrice = 20,
                    CategoryID = 1
               },
               new Product
                {
                    ProductID = 3,
                    ProductName = "Black Tea",
                    ProductDescription = "Tea blends often have the best of both worlds since they combine more than one type of premium tea.  Mixing teas in a blend is one of the best ways to get great flavor.", 
                    ImagePath="",
                    UnitPrice = 30,
                    CategoryID = 1
               },
               new Product
                {
                    ProductID = 4,
                    ProductName = "Black Tea",
                    ProductDescription = "A belly of Italian espresso smoothened with steamed and foamed milk.", 
                    ImagePath="",
                    UnitPrice = 30,
                    CategoryID = 2
               },
            };
            return products;
        }
    }
}