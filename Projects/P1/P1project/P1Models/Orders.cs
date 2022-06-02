namespace P1Models;

     public class CookieCrumbleOrders
    {
         Guid _orderId;
        public CookieCrumbleOrders()
        {
            this._orderId = Guid.NewGuid();
        }

        public Guid OrderID { get {return _orderId;} }
        public CookieCrumbleStores? Store { get; set; }
        public CookieCrumbleCustomer? Customer { get; set; }
        private decimal _totalOrderSum = 0;
        public decimal TotalOrderSum { get {return _totalOrderSum;} }
        private Dictionary<CookieCrumbleProducts, int> _CookieCrumbleProducts  = new Dictionary<CookieCrumbleProducts,int>();
        public void AddCookieCrumbleProduct(CookieCrumbleProducts product, int quantity)
        {
            _CookieCrumbleProducts.Add(product, quantity);
            _totalOrderSum += product.ProductPrice * quantity;
        }
        
        public Dictionary<CookieCrumbleProducts, int> GetCookieCrumbleProducts()
        {
            return _CookieCrumbleProducts;
        }
    }
