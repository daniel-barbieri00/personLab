using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace personClassLab
{
    internal class Program
    {
        static void Main()
        {
            //Creation of Persons
            Person ianB = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person ginaJ = new Person(2, "Gina", "James", "Green", 18, false);
            Person mikeB = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person maryB = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            //creation of list of people
            Person[] people = { ianB, ginaJ, mikeB, maryB };

            //creation of lowest age variable for looping
            //set to 200 because no one is 200 years old so I can start the search for the lowest with < 
            int lowestAge = 200;
            Person youngestPerson = null;

            foreach (Person x in people)
            {
                if (x.age < lowestAge)
                {
                    lowestAge = x.age;
                    youngestPerson = x;
                }
            }

            //creation of variables to find oldest person
            //set to 0 for the same reasons lowestAge was get to 200 but reversed
            int highestAge = 0;
            Person oldestPerson = null;

            foreach (Person x in people)
            {
                if (x.age > highestAge)
                {
                    highestAge = x.age;
                    oldestPerson = x;
                }
            }

            //Creation of variables to find average age
            float averageAge = 0;
            float totalAge = 0;
            int amountOfPeople = 0;

            //Loop to Find average age and store it into variable
            foreach (Person x in people)
            {
                totalAge = x.age + totalAge;
                amountOfPeople = amountOfPeople + 1;
                averageAge = totalAge / amountOfPeople;
            }

            //Calling to get correct order to match output on assignment
            ginaJ.PersonInfoSentence();
            mikeB.DisplayPersonInfo();

            ianB.DisplayFavouriteColor();
            ianB.ChangeFavColor();

            maryB.AgeInTenYears();


            Console.WriteLine("Average age is: " + averageAge);
            Console.WriteLine("The youngest person is: " + youngestPerson.firstName);
            Console.WriteLine("The oldest person is: " + oldestPerson.firstName);

            mikeB.DisplayPersonInfo();

            ianB.PersonInfoToString();
        }
    }
}
