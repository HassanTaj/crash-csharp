

namespace CSharpFundamentals {
    /// <summary>
    /// A class an abstraction of real world objects.
    /// </summary>
    public class Person {

        // field
        private int id;
        // getters and setters
        public int getId() { return id; }
        public void setId(int id) { this.id = id; }

        // Properties
        // Full Property
        private int age; // This is a field
        public int Age {
            get { return age; }
            set { age = value; }
        }

        // Automatic Properties
        public string Name { get; set; }
        public SkinTone SkinTone { get; set; }
        
        public float Height { get; set; }
        public int Weight { get; set; }
        public void Eat() {
            Console.WriteLine("Person is eating");
        }
    }

    public enum SkinTone {
        White,
        Black,
        Yellow,
        Brown
    }
}
