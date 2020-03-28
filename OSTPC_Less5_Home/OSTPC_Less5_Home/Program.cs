using System;
using System.Collections.Generic;
namespace OSTPC_Less5_Home
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, welcome to our restaurant.");
            int numberOfPerson = GetNumberOfPerson();
            List<Order> currentOrders = new List<Order>();
            currentOrders = GetAllOrders(numberOfPerson);
            PrintAllOrders(currentOrders);
        }

        public static int GetNumberOfPerson() {
            int inputedNumberOfPerson=0;
            try
            {
                do
                {
                    Console.WriteLine("Please, input a number of person, who will make an order.");
                    inputedNumberOfPerson = int.Parse(Console.ReadLine());
                } while (IsNumberInputedCorrectly(inputedNumberOfPerson) == false);
                return inputedNumberOfPerson;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please try again.");
                return GetNumberOfPerson();
            }
        }

        public static List<Order> GetAllOrders(int numberOfPerson) {
            List<Order> currentOrderList = new List<Order>();
            for (int i = 0; i<numberOfPerson; i++) {
                Console.WriteLine($"Order for {i+1} person.");
                Order currentOrder = new Order();
                currentOrderList.Add(currentOrder);
            }
            return currentOrderList;
        }

        public static void PrintAllOrders(List<Order> currentOrdersList) {
            foreach (Order variable in currentOrdersList) {
                Console.WriteLine($"Order for {variable.PersonName}:");
                variable.PrintDishesFromOrder();
            }
        
        }
        public static bool IsNumberInputedCorrectly(int inputedNumber) {
            if (inputedNumber <= 0)
            {
                Console.WriteLine("Your input is uncorrectly. Please try again.");
                return false;
            }
            return true;
        }
       
    }
   
}
