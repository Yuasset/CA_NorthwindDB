
namespace CA_NorthwindDB.Abstracts
{
    internal interface IProductProcess
    {
        void ProductListPriceX(decimal price);
        void ProductListPriceXY(decimal priceX, decimal priceY);
        void ProductListCount();
        void ProductTotalStock();
        void ProductAveragePrice();
        void ProductPriceMax();
        void ProductPriceMin();
    }
}
