using System;

// in c++
// include stdio.h
// include statements

// in java / kotlin
// import System.String
// import swing.*

// java script / node
// const fs = require('fs')

namespace _01_Introduction {
    class Program {
        // entry point of program
        static void Main(string[] args) {
            //string hello = "Hello World";

            //// cout << hello <<  endl; // c++
            //// println(hello);  // kotlin
            //// print hello      // python
            //// System.Out.Print(hello) // java
            //Console.WriteLine(hello);

            //// return 0;
            //// system('pause');
            //Console.ReadLine();

            ///////// basic data types

            var name = "Tayab"; // variable
            int aint = 1;
            long lng = 0002;
            double dbl = 3.14733d;
            float f = 3.1473333333333333333f;

            string animal = "Dog";

            dynamic d = name;
            //d = dbl;
            //d = f;
            //d = animal;


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



        }
    }
}