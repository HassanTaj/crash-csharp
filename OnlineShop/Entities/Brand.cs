using System.ComponentModel;

namespace OnlineShop.Entities {
    internal class Brand {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    internal enum BrandEnum {
        [Description("Lenovo")]
        Lenovo=1,
        [Description("Asus")]
        Asus,
        [Description("Samsung")]
        Samsung
    }
}
