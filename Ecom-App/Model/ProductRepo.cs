using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_App.Model
{
    public class ProductRepo
    {
        private static readonly List<string> DefaultImageOptions = new List<string>
        {
            "https://www.ackermans.co.za/cdn/shop/files/PR24563BI115806_193189_Setback_heel_court_shoe_black_BLACK_9_SZ4.webp",
            "https://cdn.shopify.com/s/files/1/1754/6207/files/c8bf9674-ed9c-46eb-8e48-6cbe34f51299_1200x.jpg.webp",
            "https://gomez.pl/upload/product/873/lc235w0003162220037-4.jpg"
        };

        private static readonly Random random = new Random();

        public static List<Product> AllProducts => GenerateProducts();

        private static List<Product> GenerateProducts()
        {
            var products = new List<Product>();
            for (int i = 0; i < 8; i++) 
            {
                var defaultImageIndex = random.Next(DefaultImageOptions.Count);
                var defaultImage = DefaultImageOptions[defaultImageIndex];

                var otherImages = DefaultImageOptions.Where((url, index) => index != defaultImageIndex).ToList();
                otherImages.AddRange(new List<string> 
                {
                    "https://images.vestiairecollective.com/images/resized/w=1246,q=75,f=auto,/produit/black-suede-dolce-gabbana-heels-44187907-1_4.jpg",
                    "https://example.com/image4.jpg",
                    "https://example.com/image5.jpg"
                });
                
                var shuffledOtherImages = otherImages.OrderBy(x => random.Next()).Take(3).ToList();

                products.Add(new Product
                {
                    Name = "High Heel",
                    Price = 3400,
                    DefaultImage = defaultImage,
                    Images = shuffledOtherImages
                });
            }
            return products;
        }
    }
}