
using CA_NorthwindDB.Abstracts;

namespace CA_NorthwindDB.Concrete
{
    internal class OrderProcess : IOrderProcess
    {
        public void OrderListCount()
        {
            int orderData = Process.dbContext.Orders.Count();
            Console.WriteLine("Toplam sipariş sayısı: " + orderData);
        }
    }
}
