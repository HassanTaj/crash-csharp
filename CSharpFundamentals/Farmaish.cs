namespace CSharpFundamentals {

    // Hassan
    internal class Needle {
        public int Size { get; set; }
        public int SteelType { get; set; }
        public double Price { get; set; }
    }

    internal interface IBreak {
         void ApplyBreak(); // signature, prototype
    }
    internal class Vehicle : IBreak {
        public int Model { get; set; }
        public int Make { get; set; }
        public string Color { get; set; }
        public int Millage { get; set; } 
        public string ChasiNumber { get; set; }
        public string EngineType { get; set; }
        public int TankSize { get; set; }

        public void ApplyBreak() {
            Console.WriteLine("Breaks Applied...");
        }
    }

    // Hafsa
    internal class Car : Vehicle {
        public bool IsRearWheelDrive { get; set; }
        public bool IsAllWheelDrive { get; set; }
    }

    // Haseeb
    internal class Bike : Vehicle {
        public bool IsSportsBike { get; set; }
        public bool IsElectricStart { get; set; }
    }

    // Hammad
    internal class Table {
        public int Legs { get; set; }
        public string Color { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public TableType TableType { get; set; }

    }
    enum TableType {
        Home,
        Office,
        Dining
    }

    // Muneeb
    internal class Phone {
        public int Model { get; set; }
        public string Vendor { get; set; }
        public int Memory { get; set; }
        public int Rom { get; set; }
        public int CameraPixel { get; set; }
        public int Dimensions { get; set; }
        public int ScreenSize { get; set; }

    }


    // Ahmed example of UNIT Engine
    internal class Universe {
        // part of unity
        public int DarkMatter { get; set; }
        public int DarkMatterExpansionRate { get; set; }
        public List<StarSystem> StarSystems { get; set; }

    }

    internal class StarSystem {
        public DateTime BirthDate { get; set; }
        public DateTime ExpectedDemiseDate { get; set; }
        public List<Planet> Planets { get; set; }
        public List<Astroid> Astroids { get; set; }

    }

    internal class Planet {
        public bool HazOzone { get; set; }
        public string Atmosphere { get; set; }
        public float AtomosphericPressure { get; set; }
        public float WindSpeed { get; set; }
        public int GraviationalForce { get; set; }
        public bool IsHabitable { get; set; }
        public bool IsToxic { get; set; }
        public bool IsDistoried { get; set; }
        public int NumberOfMoons { get; set; }
    }

    internal class Astroid {
        public int Diameter { get; set; }
        public int Length { get; set; }
        public string Material { get; set; }
        public string MaterialComposition { get; set; }
    }

    

}
