//C++ 
//#include stdio.h
//#include <string>

//Java 
// import System.Io.*

//C#
using System.Collections;
using System.ComponentModel;

namespace CSharpFundamentals {
    public class Program {
        static void Main(string[] args) {

            #region Data Types
            /// ------------------------------------
            /// THE PRIMITIVE DATA TYPES
            /// ------------------------------------
            /// 
            /// byte            1 byte — unsigned value from 0 to 255
            /// sbyte           1 byte — from -128 to 127
            /// 
            /// short           2 byte - from -32,768 to 32,767
            /// ushort          2 byte - from 0 to 65,535
            /// 
            /// int             4 bytes - from -2 billion to 2 billion
            /// uint            4 bytes - from 0 to 4 billion
            /// 
            /// long            8 -9 quintillion to 9 quintillion
            /// ulong           8 0 to 18 quintillion 
            /// 
            /// float           4 bytes 7 significant digits^1 
            /// double          8 bytes —  15 significant digits^2, base 2
            /// decimal         24 bytes - 28 to 29 significant digits^4, base 10
            /// 
            /// object          4 byte address — All C# Objects
            /// char            2 byte Unicode characters single character of data
            /// string          4 byte address - Length up to 2 billion bytes^3
            /// bool            1 byte - Boolean true or false value
            /// DateTime        8 bytes — represents 0:00:00 Jan 1 0001 through 11 :59:59 Dec 31 9999
            /// DateSpan        -10675199.02:48:05.4775808 to 10675199.02:48:05.47758076

            /// ------------------------------------
            /// NULLABLE DATA TYPES
            /// ------------------------------------
            /// 
            /// Nullable types can represent the full range of values of their normal underlying type, along with the additional value of null.
            /// 
            /// bool b; // can be true or false
            /// b = null; // error — can't set b to null
            /// bool? b; // can be true or false, or null
            /// int? i; // can be an integer value, or null
            /// Nullable<long>; // this can be null or a long number
            /// -------------------------------------

            /// ------------------------------------
            /// Double or Decimal
            /// ------------------------------------
            ///                     double                      decimal
            ///
            /// Precision           15-16 Figures               28-29 figures
            /// 
            /// Internal Format     Base 2                      Base 10
            /// 
            /// Speed               native to CPU(very fast)    up to 10x slower than double
            /// 
            /// Good For            Scientific calculations     Financial calculations
            /// 
            /// ------------------------------------

            /// ------------------------------------
            /// Value Types & Reference Types
            /// ------------------------------------
            /// 
            /// 1. Value Types         all permeative types (int,long,float,decimal,short)
            ///     in Value Types are always passed as copy to a function
            ///     
            /// 2. Reference Types     class, array,delegate, interface, record
            ///     in reference types only the address/reference of the variable is passed to the function
            /// 
            /// ------------------------------------
            #endregion

            #region Operators and Precedence
            /// ------------------------------------
            /// THE PRIMITIVE DATA TYPES
            /// ------------------------------------
            /// 
            /// 1. Multiplicative                   * / %
            /// 2. Additive                         + -
            /// 3. Comparison and Type Testing      < > <=  >= is as
            /// 4. Equality                         == !=
            /// 5. Conditional AND                  &&
            /// 6. Conditional OR                   ||
            /// 7. Ternary                          ?:
            /// 8. Assignment                       = *= /= %= += -=
            /// 
            /// Details and more about Operators: 
            /// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/
            /// ------------------------------------
            #endregion

            #region Everything is An Object
            /// ------------------------------------
            /// (ALMOST)EVERYTHING IS AN OBJECT
            /// ------------------------------------
            /// 
            /// 1. Provides a unified way of working with all variable types — you don't treat
            ///     primitive types one way and objects another like in other languages
            ///
            /// 2. Basic variable types in C# have some cool automatic features built in
            /// 
            /// 3. C# types can be converted to and from objects, so they can be passed to
            ///     functions that take objects as parameters
            /// 
            /// ------------------------------------
            #endregion

            #region Conditionals
            PrintTitle("Conditionals");

            // conditionals
            int age = 17;

            if (age < 18) {
                Console.WriteLine("you are too young for this web page");
            }
            else if (age == 18) {
                Console.WriteLine("perfect please fill the registeration from.");
            }
            else {
                Console.WriteLine("Welcome");
            }

            // switch statement
            switch (age) {
                case 17:
                    Console.WriteLine("you are too young for this web page");
                    break;
                case 18:
                    Console.WriteLine("perfect please fill the registeration from.");
                    break;
                default:
                    Console.WriteLine("Welcome");
                    break;
            }

            // switch expression
            var ageRes = age switch {
                17 => "you are too young for this web page",
                18 => "perfect please fill the registeration from.",
                _ => "Welcome",
            };
            Console.WriteLine(ageRes);

            #endregion

            #region Loops
            PrintTitle("Loops");
            PrintTitle("for");
            for (int i = 0; i < 10; i++) {
                var j = (1 + i);
                Console.WriteLine("This is item number" + i + " " + j);
            }

            PrintTitle("foreach");
            var fruits = new string[6];
            fruits[0] = "Apple";
            fruits[1] = "Mango";
            fruits[2] = "Banana";
            fruits[3] = "Dragon Fruit";
            fruits[4] = "Guava";
            fruits[5] = "Avocado";

            foreach (var fruit in fruits) {
                Console.WriteLine(@"I will eat {0}", fruit);
            }

            var bois = new string[] {
                "Ahmed", "Muneeb",
                "Tayyab",
                "Tahir",
            };

            for (int i = 0; i < bois.Length; i++) {
                Console.WriteLine(@"I am {0}", bois[i]);
            }

            Console.WriteLine("\nwhile\n");
            var cities = new List<string>() {
             "Lahore",
             "Islamabad"
            };

            PrintTitle("while");
            cities.Add("Multab");
            cities.Add("Karachi");
            int citiyIndex = 0;
            while (citiyIndex != cities.Count) {
                Console.WriteLine($"I live in {cities[citiyIndex]}");

                citiyIndex++; // postfix adds 1 to the index after assigning value
                //++citiyIndex; // prefix : adds 1 before assigning value
                //citiyIndex += 1; // adds 1 to the index
                //citiyIndex -= 1; // subtracts 1 from index
            }

            #endregion

            #region Enums
            PrintTitle("Enums");
            Console.WriteLine($"\nEnum\n");
            Console.WriteLine($"Gender {Genders.Male.GetHashCode()}");
            Console.WriteLine($"Gender {Genders.Female}");
            Console.WriteLine($"Gender {Genders.Others}");
            #endregion

            #region Functions
            PrintTitle("Functions");
            var gender = CheckGender();
            Console.WriteLine($"Hi I am a {gender}");
            #endregion

            #region Collections
            PrintTitle("Collections");

            /// ------------------------------------
            /// Collections in C#
            /// ------------------------------------
            /// 
            /// arrays
            /// arraylist
            /// list
            /// stacks
            /// queue
            /// dictionaries
            /// 
            /// ------------------------------------


            /// ------------------------------------
            /// Arrays
            /// ------------------------------------ 
            PrintTitle("Arrays");
            /// 
            int[] manyValues = { 1, 18, 745, 34, 16, 94, 73, 4, 17, 200 };

            Console.WriteLine("The fourth number is {0}", manyValues[3]);

            // sorted values
            //Array.Sort(manyValues);
            // reversed values
            // Array.Reverse(manyValues);
            Console.WriteLine(" length of array is > " + manyValues.GetLength(0));
            Console.WriteLine(" length of array is > " + manyValues.Length);
            foreach (int i in manyValues) {
                Console.WriteLine("{0}", i);
            }


            string[] myStrings = { "Joe", "Marini", "Teaches", "C#" };
            for (int i = 0; i < 4; i++) {
                Console.WriteLine("{0}", myStrings[i]);
            }

            int[] otherValues = manyValues;
            otherValues[3] = 0;
            Console.WriteLine("The fourth number is {0}", manyValues[3]);

            Array.Sort(manyValues);
            Console.WriteLine("The fourth number is {0}", manyValues[3]);

            /// ------------------------------------
            /// ArrayLists
            /// ------------------------------------
            /// 
            PrintTitle("Array List");
            ArrayList myAL = new ArrayList();
            myAL.Add("one");
            myAL.Add(2);
            myAL.Add("three");
            myAL.Add(4);
            myAL.Insert(0, 1.25f);

            foreach (object o in myAL) {
                if (o is int) {
                    Console.WriteLine("{0}", o);
                }
                else if (o is string) {
                    Console.WriteLine("{0}", o);
                }
            }

            /// ------------------------------------
            /// Stack
            /// ------------------------------------
           
            PrintTitle("Stack");
            Stack myStack = new Stack();
            myStack.Push("item 1");
            myStack.Push("item 2");
            myStack.Push("item 3");
            Console.WriteLine("{0} Items on the stack", myStack.Count);

            // Have a peek at the top item
            Console.WriteLine("{0} < peek at top", myStack.Peek());

            myStack.Pop(); // pops "item 3" off the top
            // now "item 2" is the top item
            Console.WriteLine("{0}", myStack.Peek());

            myStack.Clear(); // get rid of everything
            Console.WriteLine("{0} Items on the stack", myStack.Count);

            /// ------------------------------------
            /// Queues
            /// ------------------------------------
            PrintTitle("Queues");
            Queue myQ = new Queue();
            myQ.Enqueue("item 1");
            myQ.Enqueue("item 2");
            myQ.Enqueue("item 3");
            myQ.Enqueue("item 4");

            Console.WriteLine("There are {0} items in the Queue", myQ.Count);

            while (myQ.Count > 0) {
                // donkey work
                string? str = myQ.Dequeue() as string;
                Console.WriteLine("Dequeuing object {0}", str);

                // Console.WriteLine($"Dequeuing object {myQ.Dequeue()}"); // smart work
            }

            /// ------------------------------------
            /// Dictionaries
            /// ------------------------------------
           
            PrintTitle("Dictionaries");
            PrintTitle("Hashtable");

            Hashtable myHT = new();
            myHT.Add("SFO", "San Francisco Airport");
            myHT.Add("SEA", "Seattle Tacoma Airport");
            myHT["IAD"] = "Washington Dulles Airport";

            Console.WriteLine("Value for key {0} is {1}", "SEA", myHT["SEA"]);

            Console.WriteLine("There are {0} items", myHT.Count);
            //myHT.Remove("SFO");
            if (myHT.ContainsKey("SFO")) {
                Console.WriteLine("Value for key {0} is {1}", "SFO", myHT["SFO"]);
            }

            PrintTitle("KeyValuePair");
            List<KeyValuePair<long, string>> genders = new();
            genders.Add(new KeyValuePair<long, string>((long)Genders.Male, Genders.Male.ToString()));
            genders.Add(new KeyValuePair<long, string>((long)Genders.Female, Genders.Female.ToString()));
            genders.Add(new KeyValuePair<long, string>((long)Genders.Others, Genders.Others.ToString()));

            genders?.ForEach(genderKeyValuePair => {
                Console.WriteLine($"Key = {genderKeyValuePair.Key} & Value = {genderKeyValuePair.Value}");
            });

            PrintTitle("Dictionary");
            Dictionary<char, string> englishDictionary = new();
            englishDictionary.Add('a', "apple");
            englishDictionary.Add('s', "saib");
            englishDictionary.Add('c', "cat");

            foreach (var key in englishDictionary.Keys) {
                // Console.WriteLine($"for key {key} = {englishDictionary[key]}");
                Console.WriteLine($"for key {key} = {englishDictionary.GetValueOrDefault(key)}");
            }

            PrintTitle("HashSet");
            HashSet<int> hasSet = new HashSet<int>();
            hasSet.Add(1);
            hasSet.Add(2);
            hasSet.Add(3);
            hasSet.Add(4);
            foreach (var val in hasSet) {
                Console.WriteLine(val);
            }
            #endregion

            #region Custom Classes & Objects
            PrintTitle("Custom Classes & Objects");
            Person haseeb = new();
            haseeb.setId(1);
            haseeb.Name = "Haseeb";
            haseeb.Age = 23;
            haseeb.Weight = 50;
            haseeb.Height = 5.7f;
            haseeb.SkinTone = SkinTone.Brown;

            var jaden = new Person {
                Name = "Jaden",
                Age = 18,
                Weight = 80,
                Height = 5.4f,
                SkinTone = SkinTone.Yellow,
            };
            jaden.setId(2);

            var people = new List<Person> {
                haseeb,
                jaden
            };

            people.ForEach(p => {
                Console.WriteLine("\n" + $@"Id:{p.getId()}
name:{p.Name}
age:{p.Age}
weight:{p.Weight}
height:{p.Height}
skinTone:{p.SkinTone}
");
            });
            #endregion

            #region Access Modifiers
            /// ------------------------------------
            /// Access Modifiers
            /// ------------------------------------
            /// 
            /// ----- Default Access
            /// Type                   Default Access
            /// 
            /// class                   internal
            /// struct                  internal
            /// interface               internal
            /// record                  internal
            /// enum                    internal
            /// interface members       internal
            /// ---------------------------
            /// 
            /// 
            /// ---- Summary
            /// 
            /// Caller's Location                       public |(protected internal) | protected |internal |(private protected) |  private
            /// within the class                         ✔️     |  ✔️                 |   ✔️       | ✔️       | ✔️                 |   ✔️
            /// derived class (same assembly)            ✔️     |  ✔️                 |   ✔️       | ✔️       | ✔️                 |   ❌
            /// non-derived class (same assembly)        ✔️     |  ✔️                 |   ❌      | ✔️       | ❌                |   ❌
            /// derived class (different assembly)       ✔️     |  ✔️                 |   ✔️       | ❌      | ❌                |   ❌
            /// non-derived class (different assembly)   ✔️     |  ❌                |   ❌      | ❌      | ❌                |   ❌
            /// 
            /// Details: 
            /// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
            /// ------------------------------------

            #endregion

            #region Postfix & Prefix
            PrintTitle("Postfix & Prefix");
            int a = 10;
            Console.WriteLine("\nprefix a = {0}", ++a);
            int b = 10;
            Console.WriteLine("postfix b = {0}", b++);
            #endregion

            #region Value Type & Reference Type
            PrintTitle("Value Type & Reference Type");
            // in value types value is passed as a copy to a function
            PrintTitle("Value Type"); 
            var ten = 10;
            Console.WriteLine($"\nvalue of ten = {ten}");
            AddTen(ten);
            Console.WriteLine($"value of ten = {ten}");

            // in reference types address/reference of the variable is passed to a function
            PrintTitle("Reference Type"); 
            Person kashif = new() {
                Name = "Kashif"
            };
            Console.WriteLine($"\nBefore {nameof(ChangePersonName)} = {kashif.Name}");
            ChangePersonName(kashif);
            Console.WriteLine($"After {nameof(ChangePersonName)} = {kashif.Name}");
            #endregion

            #region Complex Classes
            PrintTitle("Complex Classes");

            var car = new Car();
            car.ApplyBreak();
            var bike = new Bike();
            bike.ApplyBreak();

            var eaters = new List<IEat>() {
                new Human(),
                new Fish(),
                new Mermaid(),
            };
            eaters.ForEach(eater => {
                eater.Eat();
            });

            #endregion

            Console.ReadKey();
        }

        // expression bodied function
        static void PrintTitle(string title) => Console.WriteLine($"\n------------- {title} --------------\n");
      
        // normal static function
        static void AddTen(int a) {
            a += 10;
            Console.WriteLine($"value of a in {nameof(AddTen)} = {a}");
        }
        static void ChangePersonName(Person p) {
            p.Name = "Captain " + p.Name;
            p.Age = 30;  // for those kids who will ask can we change anything else ?? YES
            Console.WriteLine($"Inside {nameof(ChangePersonName)} scope = {p.Name}");
        }

        static string CheckGender() {
            string result; // = default; // string.Empty; // "";
            Console.Write("Enter\n1 for Male\n2 for Female\n3 for other : ");
            var gender = Convert.ToInt32(Console.ReadLine());
            if (gender == Genders.Male.GetHashCode()) {
                result = "Man";
            }
            else if (gender == (int)Genders.Female) {
                result = "Woman";
            }
            else if (gender == (int)Genders.Others) {
                result = "Proud";
            }
            else {
                result = "Wrong Entry";
                // Exception
            }
            return result;
        }

        enum Genders {
            [Description("Male")]
            Male = 1,
            [Description("Female")]
            Female,
            [Description("Others")]
            Others
        }
    }
}