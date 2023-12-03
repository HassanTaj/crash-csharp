using OnlineShop.Entities;
using OnlineShop.Extensions;
using static OnlineShop.Extensions.EnumExtensions;

namespace OnlineShop {
    internal class Mall {

        #region Private Fields
        private readonly List<Shop> _shops;
        private readonly List<Brand> _brands;
        private readonly List<ShopItem> _cart;
        #endregion

        public Mall() {
            _cart = new List<ShopItem>();

            _brands = new List<Brand>() {
                new(){ Id =BrandEnum.Lenovo.GetHashCode(), Name =BrandEnum.Lenovo.GetDescription() },
                new(){ Id =BrandEnum.Asus.GetHashCode(), Name =BrandEnum.Asus.GetDescription() },
                new(){ Id =BrandEnum.Samsung.GetHashCode(), Name =BrandEnum.Samsung.GetDescription() },
            };

            _shops = new List<Shop>() {
                new() {
                    Id = 1,
                    Name = ShopType.Laptop.GetDescription(),
                    ShopType = ShopType.Laptop,
                    Items = new List<ShopItem> {
                        // lenovo
                        new ShopItem {
                            Id = 1,
                            Brand = _brands.Find(b => b.Id == BrandEnum.Lenovo.GetHashCode()),
                            Name = "Lenovo Legion 1",
                            UnitPrice = new Random().Next(200,100_000),
                        },
                        new ShopItem {
                            Id = 2,
                            Brand = _brands.Find(b => b.Id == BrandEnum.Lenovo.GetHashCode()),
                            Name = "Lenovo Yoga",
                            UnitPrice = new Random().Next(200,100_000),
                        },
                         new ShopItem {
                            Id = 3,
                            Brand = _brands.Find(b => b.Id == BrandEnum.Lenovo.GetHashCode()),
                            Name = "Lenovo Yoga Pro",
                            UnitPrice = new Random().Next(200,100_000),
                        },
                         // samsung Items
                         new ShopItem {
                            Id = 4,
                            Brand = _brands.Find(b => b.Id == BrandEnum.Samsung.GetHashCode()),
                            Name = "Samsung Sam 2345",
                            UnitPrice = new Random().Next(200,100_000),
                        },
                        new ShopItem {
                            Id = 5,
                            Brand = _brands.Find(b => b.Id == BrandEnum.Samsung.GetHashCode()),
                            Name = "Samsung Sam 456",
                            UnitPrice = new Random().Next(200,100_000),
                        },
                        new ShopItem {
                            Id = 6,
                            Brand = _brands.Find(b => b.Id == BrandEnum.Samsung.GetHashCode()),
                            Name = "Samsung Sam 789",
                            UnitPrice = new Random().Next(200,100_000),
                        }
                    }
                },
                new() {
                   Id = 2,
                   Name = ShopType.Mobile.GetDescription(),
                   ShopType = ShopType.Mobile,
                   Items = new List<ShopItem> {
                       new() {
                            Id = 1,
                            Brand = _brands.Find(b => b.Id == BrandEnum.Lenovo.GetHashCode()),
                            Name = "Lenovo Gaming 1",
                            UnitPrice = new Random().Next(200,100_000),
                       },
                       new() {
                            Id = 2,
                            Brand = _brands.Find(b => b.Id == BrandEnum.Lenovo.GetHashCode()),
                            Name = "Lenovo Gaming 2",
                            UnitPrice = new Random().Next(200,100_000),
                       },
                       new() {
                            Id = 3,
                            Brand = _brands.Find(b => b.Id == BrandEnum.Lenovo.GetHashCode()),
                            Name = "Lenovo Gaming 3",
                            UnitPrice = new Random().Next(200,100_000),
                       },
                       new() {
                            Id = 4,
                            Brand = _brands.Find(b => b.Id == BrandEnum.Asus.GetHashCode()),
                            Name = "Asus ROG 1",
                            UnitPrice = new Random().Next(200,100_000),
                       },
                       new() {
                            Id = 5,
                            Brand = _brands.Find(b => b.Id == BrandEnum.Asus.GetHashCode()),
                            Name = "Asus ROG 2",
                            UnitPrice = new Random().Next(200,100_000),
                       },
                       new() {
                            Id = 6,
                            Brand = _brands.Find(b => b.Id == BrandEnum.Asus.GetHashCode()),
                            Name = "Asus ROG 3",
                            UnitPrice = new Random().Next(200,100_000),
                       },
                   },
                },
                new() {
                   Id =3,
                   Name = ShopType.LaptopAccessories.GetDescription(),
                   ShopType = ShopType.LaptopAccessories
                },
                new() {
                   Id =4,
                   Name = ShopType.MobileAccessories.GetDescription(),
                   ShopType = ShopType.MobileAccessories
                }
            };
        }
        public void Run() {
            Greetings();
            bool isMallSessionActive = true;
            bool isShopActive = true;
            bool isBrandMenuActive = true;

            while (isMallSessionActive) {
                int option = MainMenu();
                var shop = _shops.Find(x => x.Id == option);
                if (shop != null) {
                    isBrandMenuActive = true;
                    while (isBrandMenuActive) {
                        int brandOption = BrandOptions();
                        if (brandOption > 0) {
                            isShopActive = true;
                            while (isShopActive) {
                                int shopOption = ShopOptions(shop, brandOption);
                                var shopMaxItemId = brandOption != _brands.Max(x => x.Id) + 1 ? shop.Items.Where(x => x.Brand?.Id == brandOption).Max(x => x.Id) + 1 : shop.Items.Max(x => x.Id) + 1;
                                if (shopOption > 0 && shopOption != shopMaxItemId) {
                                    var item = shop.Items.FirstOrDefault(x => x.Id == shopOption);
                                    if (item is not null) {
                                        while (true) {
                                            int shopItemOption = ShopItemOptions(item);
                                            if (shopItemOption == 0) break;
                                            else if (shopItemOption == 1) {
                                                AddItemToCart(item);
                                                break;
                                            }
                                        }
                                    }
                                }
                                else if (shopOption == 0) isShopActive = false;
                                else if (shopOption == shopMaxItemId) isShopActive = isBrandMenuActive = false;
                            }

                            if (!isShopActive && !isBrandMenuActive) ByeMessage();
                        }
                        else if (brandOption == 0) isBrandMenuActive = false;
                    }
                }

                if (option == _shops.Count + 1) {
                    var cartOption = ViewCart();
                    if (cartOption == 1) isMallSessionActive = false;
                }
                if (option == 0) isMallSessionActive = false;
            }
           
            if (isMallSessionActive is not true) FareWell();
        }
        public void Greetings() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
=======================================
=======================================
====                              =====
====    Welcome to Online Mall    =====
====                              =====
=======================================
=======================================
");
            Console.ResetColor();
        }
        public void FareWell() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
=======================================
=======================================
====      Thanks For Shopping     =====
====            Bye!!             =====
=======================================
=======================================
");
            Console.ResetColor();
        }
        public void ByeMessage() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
=======================================
====      Thanks For Shopping     =====
=======================================
");
            Console.ResetColor();
        }
        public void Title(string title) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n===\n>>> {title}\n===");
            Console.ResetColor();
        }
        public int MainMenu() {
            Title("Main menu");
            var optionsString = "";
            if (_shops.Exists(x => x.Id != 0) && _shops.Count > 0) {
                foreach (Shop shop in _shops) {
                    optionsString += $"Enter ({shop.Id}) for {shop.Name}\n";
                }
            }
            optionsString += $"Enter ({_shops.Count + 1}) to view cart\nEnter (0) to exit mall";
            Console.WriteLine(optionsString);

            return GetIntOption();
        }
        public int ShopOptions(Shop shop, int? brandId) {
            Title("Shop Options");
            var optionsString = "";
            var items = brandId != _brands.Max(x => x.Id) + 1 ? shop.Items.Where(x => x.Brand?.Id == brandId).ToList() : shop.Items;
            if (shop != null && items.Exists(x => x != null) && items.Count > 0) {

                foreach (var item in items) {
                    optionsString += $"Enter ({item.Id}) to view {item.Name}\n";
                }
            }
            optionsString += $"Enter (0) to go back\nEnter ({items.Max(x => x.Id) + 1}) to exit shop";
            Console.WriteLine(optionsString);

            return GetIntOption();
        }
        public int ShopItemOptions(ShopItem item) {
            Title($"{item.Name}");
            var optionsString = "";
            optionsString += @$"----------------------
Name        | {item.Name}
Unit Price  | {item.UnitPrice}
Brand Name  | {item.Brand?.Name}
---------------------
";
            optionsString += "Enter (1) to add item to cart\nEnter (0) to go back";
            Console.WriteLine(optionsString);

            return GetIntOption();
        }
        public int BrandOptions() {
            Title("Brand Options");

            var optionsString = "";
            if (_brands != null && _brands.Exists(x => x != null) && _brands.Count > 0) {
                foreach (var item in _brands) {
                    optionsString += $"Enter ({item.Id}) for {item.Name}\n";
                }
            }
            optionsString += $"Enter (0) to go back\nEnter ({_brands?.Max(x => x.Id) + 1}) to list all brands";
            Console.WriteLine(optionsString);

            return GetIntOption();
        }
        public void AddItemToCart(ShopItem item) {
            _cart.Add(item);
        }
        public int ViewCart() {
            Title("Cart");
            if (_cart is not null && _cart.Count > 0) {
                Console.WriteLine("----------------------------");
                _cart.ForEach(item => {
                    Console.WriteLine($@"{item.Name} - {item.UnitPrice} - {item.Brand?.Name}");
                });
                Console.WriteLine("----------------------------");
                Console.WriteLine("------      Total     ------");
                Console.WriteLine("----------------------------");
                var sub = _cart.Sum(x => x.UnitPrice);
                Console.WriteLine($@"
Sub Total : {sub}
VAT       : 100
Total     : {sub + 100}");
                Console.WriteLine("----------------------------");
            }

            Console.WriteLine(@"Enter (1) to checkout and exit
Enter (0) to go back");
            return GetIntOption();
        }
        public int GetIntOption() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Please enter option: ");
            Console.ResetColor();
            int id;
            while (!int.TryParse(Console.ReadLine(), out id)) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Please enter option: ");
                Console.ResetColor();
            }
            return id;
        }
    }
}
