using CA_NorthwindDB.Concrete;

namespace CA_NorthwindDB
{
    class Program
    {
        public static void Main(string[] args)
        {
            //scaffold-dbcontext "Server=MSI-DESKTOP\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
            EmployeeProcess employeeProcess = new EmployeeProcess();
            ProductProcess productProcess = new ProductProcess();
            OrderProcess orderProcess = new OrderProcess();

            Console.WriteLine("Çalışanlar Listesinden adına göre arama");
            Console.Write("Ad girin: ");
            string firstname = Console.ReadLine();
            employeeProcess.EmployeeListFistname(firstname);

            Console.WriteLine("Çalışanlar Listesinden adına göre arama");
            Console.Write("Ad girin: ");
            firstname = Console.ReadLine();
            Console.Write("Soyad girin: ");
            string lastname = Console.ReadLine();
            employeeProcess.EmployeeListFistAndLastname(firstname, lastname);

            Console.WriteLine("Ürün Fiyatı ...'den büyük olanları listele");
            Console.Write("Fiyat girin: ");
            decimal priceX = Convert.ToDecimal(Console.ReadLine());
            productProcess.ProductListPriceX(priceX);

            Console.WriteLine("Ürün Fiyat ... ile ... arasında olanları listele");
            Console.Write("1.Fiyat aralığını girin: ");
            priceX = Convert.ToDecimal(Console.ReadLine());
            Console.Write("2.Fiyat aralığını girin: ");
            decimal priceY = Convert.ToDecimal(Console.ReadLine());
            productProcess.ProductListPriceXY(priceX, priceY);

            Console.WriteLine("Kaç adet ürün var?");
            productProcess.ProductListCount();

            Console.WriteLine("Kaç adet sipariş var?");
            orderProcess.OrderListCount();

            Console.WriteLine("Toplam stok adeti kaç?");
            productProcess.ProductTotalStock();

            Console.WriteLine("Ürünlerin Fiyat Ortalaması kaç?");
            productProcess.ProductAveragePrice();

            Console.WriteLine("En pahalı ürün fiyatı kaç?");
            productProcess.ProductPriceMax();

            Console.WriteLine("En ucuz ürün fiyatı kaç?");
            productProcess.ProductPriceMin();

            Console.ReadLine();

        }
    }
}