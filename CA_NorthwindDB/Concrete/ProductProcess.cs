using CA_NorthwindDB.Abstracts;

namespace CA_NorthwindDB.Concrete
{
    internal class ProductProcess : IProductProcess
    {
        public void ProductListPriceX(decimal price)
        {
            var productData = Process.dbContext.Products.Select(product => product).Where(product => product.UnitPrice == price).ToList();
            foreach (var item in productData)
            {
                Console.WriteLine($"Ürün: {item.ProductName} Stok: {item.UnitsInStock} Fiyat: {item.UnitPrice}");
            }
        }

        public void ProductListPriceXY(decimal priceX, decimal priceY)
        {
            var productData = Process.dbContext.Products.Select(product => product).Where(product => product.UnitPrice >= priceX && product.UnitPrice <= priceY).ToList();
            foreach (var item in productData)
            {
                Console.WriteLine($"Ürün: {item.ProductName} Stok: {item.UnitsInStock} Fiyat: {item.UnitPrice}");
            }
        }

        public void ProductListCount()
        {
            int productData = Process.dbContext.Products.Count();
            Console.WriteLine("Toplam Ürün Sayısı: " + productData);
        }

        public void ProductTotalStock()
        {
            var productData = Process.dbContext.Products.Sum(product => product.UnitsInStock);
            Console.WriteLine("Toplam Stok: " + productData);
        }

        public void ProductAveragePrice()
        {
            var productData = Process.dbContext.Products.Average(product => product.UnitPrice);
            Console.WriteLine("Ürünlerin Fiyat Ortalaması: " + productData);
        }

        public void ProductPriceMax()
        {
            var productData = Process.dbContext.Products.Max(product => product.UnitPrice);
            Console.WriteLine("Fiyatı en yüksek ürün fiyatı: " + productData);
        }

        public void ProductPriceMin()
        {
            var productData = Process.dbContext.Products.Min(product => product.UnitPrice);
            Console.WriteLine("Fiyatı en düşük ürün fiyatı: " + productData);
        }
    }
}
