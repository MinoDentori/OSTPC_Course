using System;
using System.Collections.Generic;
using System.Text;

namespace OSTPC_Less5_Home
{
   public class Order
    {
        private List<string> personListOfDishes;

        public string PersonName { get; set; }
        public Order() {
            PersonName = GetPersonName();
            personListOfDishes = GetDishesToList();
        }
        public Order(string personName, List<string> personListOfDishes)
        {
            PersonName = personName;
            this.personListOfDishes = personListOfDishes;
        }
        private string GetPersonName() {
            string personName;
            do
            {
                Console.WriteLine("Print person's name please.");
                personName = Console.ReadLine();
            } while (IsStringInputedCorrectly(personName) == false);
            return personName;
        }
        private List<string> GetDishesToList() {
            List<string> currentDishes = new List<string>();
            string controllWord = "Yes";
            string currentDish = "";
            while (controllWord == "Yes") {
                do
                {
                    Console.WriteLine("Print the name of dishes, that you want add to order.");
                    currentDish = Console.ReadLine();
                } while (IsStringInputedCorrectly(currentDish) == false);
                do
                {
                    Console.WriteLine("Print 'Yes' to add external dish or 'No' to continue.");
                    controllWord = Console.ReadLine();
                } while (IsStringInputedCorrectly(controllWord) == false);
                currentDishes.Add(currentDish);
            }
            return currentDishes;
        }

        public void PrintDishesFromOrder() {
            foreach (string variable in personListOfDishes) {
                Console.WriteLine($"-{variable}");
            }
        
        }
        private bool IsStringInputedCorrectly(string inputedString) {
            if (String.IsNullOrWhiteSpace(inputedString) == true)
            {
                Console.WriteLine("You inputed string uncorrectly.");
                return false;
            }
            return true;
        }
    }

}
