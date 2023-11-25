using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals {

    internal interface IEat {
        void Eat();
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

}
