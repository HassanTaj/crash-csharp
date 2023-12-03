namespace OnlineShop.Entities {
    internal class Shop {
        public Shop() {
            Items = new List<ShopItem>();
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public ShopType ShopType { get; set; }
        public List<ShopItem> Items { get; set; }
    }
}
