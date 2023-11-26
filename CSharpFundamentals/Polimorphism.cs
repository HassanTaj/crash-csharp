namespace CSharpFundamentals {

    #region Interfaces & polymorphism
    internal interface IEat {
        void Eat();
        List<string> ListOfFavoriteFood() {
            return new List<string>() {
                "Banana",
                "Mango",
                "Pencil"
            };
        }
    }

    internal class Human : IEat {
        public void Eat() {
            Console.WriteLine("Human is eating");
        }
    }

    internal class Fish : IEat {
        public void Eat() {
            Console.WriteLine("Fish is eating");
        }
    }

    internal class Mermaid : IEat {
        public void Eat() {
            Console.WriteLine("Mermaid is eating");
        }
    }

    internal abstract class AbstractVehicle {
        // everything in an abstract class is abstract
        public abstract void FuelCapacity();
        public abstract void FuleType();

        public string _engineNumber;
        public void SetEngineNumber(string engineNumber) {
            _engineNumber = engineNumber;
        }
        public string GetEngineNumber() => _engineNumber;
    }

    internal class Boat : AbstractVehicle {
        public Boat() {
            base.SetEngineNumber($"{nameof(Boat)}-123456");
        }
        public override void FuelCapacity() {
            Console.WriteLine("18 Galons");
        }

        public override void FuleType() {
            Console.WriteLine("Diesel");
        }
    }

    internal class F16Falcon : AbstractVehicle {
        public F16Falcon() {
            base.SetEngineNumber($"{nameof(F16Falcon)}-123456");
        }
        public override void FuelCapacity() {
            Console.WriteLine("350000 Galons");
        }

        public override void FuleType() {
            Console.WriteLine("Super Charged Jet Fule");
        }
    }
    #endregion

    #region Polymorphism

    internal class GrandParent {
        public virtual bool Smokes() { return true; }
    }

    internal class Parent : GrandParent {
        public override bool Smokes() { return false; }
    }

    internal class Child : Parent {
        public override bool Smokes() { return false; }
        public virtual bool DoesIce() { return true; }
    }
    #endregion
}
