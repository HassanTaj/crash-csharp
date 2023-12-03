namespace OnlineShop.Entities {
    internal class ShopItem {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal UnitPrice { get; set; } = 0;
        public Brand? Brand { get; set; }
    }
}
