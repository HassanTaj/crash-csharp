using System.ComponentModel;

namespace OnlineShop.Entities {
    internal enum ShopType {
        [Description("Laptop Shop")]
        Laptop=1,
        [Description("Mobile Shop")]
        Mobile,
        [Description("Laptop Accessories Shop")]
        LaptopAccessories,
        [Description("Mobile Accessories Shop")]
        MobileAccessories
    }
}
