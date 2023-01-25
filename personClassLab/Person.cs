using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace personClassLab
{
    internal class Person
    {
        private int personId;
        public string firstName;
        private string lastName;
        private string favouriteColor;
        public int age;
        private bool isWorking;

        public Person(int personId, string firstName, string lastName, string favouriteColor, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favouriteColor = favouriteColor;
            this.age = age;
            this.isWorking = isWorking;
        }

        public void DisplayPersonInfo()
        {
            string personInfo = ("PersonId: " + this.personId
                + "\nFirst Name: " + this.firstName
                + "\nLast Name: " + this.lastName
                + "\nFavouriteColor: " + this.favouriteColor
                + "\nAge: " + this.age
                + "\nIs Working: " + this.isWorking);

            Console.WriteLine(personInfo);
        }

        public void DisplayFavouriteColor()
        {
            Console.WriteLine(this.firstName + "s Favourite Color: " + this.favouriteColor);
        }

        public void ChangeFavColor()
        {   
            this.favouriteColor = "White";

            Console.WriteLine(this.firstName + "s Favourite Color: " + this.favouriteColor);
        }

        public void AgeInTenYears() 
        {
            int age = this.age;
            int futureAge = age + 10;

            Console.WriteLine(this.firstName + " " + this.lastName + " Age in 10 years is: " + futureAge);
        }

        public void PersonInfoToString()
        {
            Console.WriteLine(this.personId + ", "
                + this.firstName  + ", " 
                + this.lastName + ", " 
                + this.age + ", " 
                + this.favouriteColor + ", " 
                + this.isWorking);
        }
        public void PersonInfoSentence()
        {
            // 2: Gina James's favorite colour is Green
            Console.WriteLine(this.personId + ":" + this.firstName + " " + this.lastName + "'s favorite colour is " + this.favouriteColor);
        }
    }
}


