using System;
using System.Threading;



namespace ClassObject
{
    class Animal                            // base class (parent)
    {
        // fields                           // Eigenschaften/Attribute
        public int age;                     // Alter
        public string name;                 // Name

        // methods                          // Methoden/Funktionen
        public void sleep()                 // schlafen (normal void)
        {
            Thread.Sleep(1000);
            Console.WriteLine("*schlafen*");
        }
        public void eat()                   // essen (normal void)
        {
            // your code                    // dein Programmcode
        }
        public virtual void makeSound()     // Tiergeräusch machen (virtual void)
        {
            Console.WriteLine("*Tiergeräusch*");
        }
    }


    class Dog : Animal                      // derived class (child)
    {
        // fields                           // Eigenschaften/Attribute
        public string breed;                // Rasse

        // methods                          // Methoden/Funktionen
        public override void makeSound()    // bellen (override void)
        {
            Console.WriteLine("Wuff");      // dein Programmcode
        }
    }

    class Elephant : Animal                 // derived class (child)
    {
        // fields                           // Eigenschaften/Attribute
        public int weight;                  // Gewicht

        // methods                          // Methoden/Funktionen
        public override void makeSound()    // trompeten (override void)
        {
            Console.WriteLine("Töröö!");
        }
    }


    class Program
    {
        /// <summary>
        /// Beispielprogramm zu Polymorphisus (Polymorphism)
        /// </summary>
        static void Main(string[] args)     // Hauptprogramm
        {
            // create Animal object                 // Tier-Objekt erzeugen (erstes)
            Animal myFirstAnimal = new Animal();    // meinErstesTier

            // set name of Animal           // Name des Tiers festlegen (tierspezifische Eigenschaft/Attribut)
            myFirstAnimal.name = "Ada";     // string

            // access method of animal      // Zugriff auf Methode von Tieren
            myFirstAnimal.sleep();          // Tier schläft (tierspezifische Methode/Funktion)
            myFirstAnimal.makeSound();      // Aufgrund des Polymorphisus kann das Tier einen Tierlaut machen

            // get name of animal           // Name des Tieres abfragen
            Console.WriteLine(myFirstAnimal.name);

            #region Zeile Abstsand in der Konsole
            Console.WriteLine(Environment.NewLine);
            #endregion

            // create Dog object            // Hund-Objekt erzeugen (erstes)
            Dog myFirstDog = new Dog();     // meinErsterHund

            // set name of dog              // Name des Hundes festlegen (nicht hundespezifische Eigenschaft/Attribut)
            myFirstDog.name = "Hektor";     // string

            // set age of dog               // Alter des Hundes festlegen (nicht hundespezifische Eigenschaft/Attribut)
            myFirstDog.age = 13;            // integer

            // set breed of dog             // Rasse des Hundes festlegen (hundespezifische Eigenschaft/Attribut)
            myFirstDog.breed = "Dalmatian"; // string

            // access method of dog         // Zugriff auf Methode von Hunden
            myFirstDog.sleep();             // Hund schläft (nicht hundespezifische Methode/Funktion)
            myFirstDog.makeSound();         // Hund bellt (hundespezifische Methode/Funktion) xxxxxxxxxx

            // get name of dog              // Name des Hundes abfragen
            Console.WriteLine(myFirstDog.name);


            // create Dog object            // Hund-Objekt erzeugen (zweites)
            Dog mySecondDog = new Dog();    // meinZweiterHund

            // set breed of dog             // Rasse des Hundes festlegen
            mySecondDog.breed = "Poodle";   // string

            /*
            etc.
            etc.
            etc.
             */

            #region Zeile Abstsand in der Konsole
            Console.WriteLine(Environment.NewLine);
            #endregion

            Elephant myFirstElephant = new Elephant();      // Elefant-Objekt erzeugen (erstes)

            // set name of elephant                         // Name des Elefantes festlegen (nicht elefantspezifische Eigenschaft/Attribut)
            myFirstElephant.name = "Benjamin Blümchen";     // string

            // set weight of elephant                       // Gewicht des Elefantes (elefantspezifische Eigenschaft/Attribut)
            myFirstElephant.weight = 6000;                  // integer

            // access method of elephant                    // Zugriff auf Methode von Elefanten 
            myFirstElephant.sleep();                        // Elefant schläft (nicht elefantspezifische Methode/Funktion)
            myFirstElephant.makeSound();                    // Elefant trompeteter (elefantspezifische Methode/Funktion)  xxxx

            // get name of elephant                         // Name des Elefants abfragen
            Console.WriteLine(myFirstElephant.name);

            /*
            etc.
            etc.
            etc.
             */

            #region Damit die Konsole sich nicht schliesst
            Console.WriteLine(Environment.NewLine + "Press any key to close programme.");
            Console.ReadKey();
            #endregion
        }
    }
}