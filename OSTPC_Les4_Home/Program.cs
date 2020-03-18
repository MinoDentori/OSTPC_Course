using System;
using System.Collections.Generic;
namespace OSTPC_Les4_Home
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int numbers = GetNumberOfEnteredNumbers();
            list =  GetNumbersToList(numbers);
            PrintList(list,-1);
            List<int> evenList = new List<int>();
            List<int> notEvenList = new List<int>();
            evenList = GetAllEvenNumbers(list);
            notEvenList = GetAllNotEvenNumbers(list);
            PrintList(evenList,0);
            PrintList(notEvenList,1);
        }

        static int GetNumberOfEnteredNumbers() {
            try
            {
                int enteredNumber = 0;
                Console.WriteLine("Please, input a number of numbers:");
                enteredNumber = int.Parse(Console.ReadLine());
                if (enteredNumber < 1)
                {
                    Console.WriteLine("Input error.Try again");
                    return GetNumberOfEnteredNumbers();

                }
                Console.WriteLine("Complete");
                return enteredNumber;
            }
            catch(FormatException e) {
                Console.WriteLine(e.Message);
                return GetNumberOfEnteredNumbers();
            }
        }


        static int GetNumber(int i)
        {
            int enteredNumber=0;
            try
            {
                Console.WriteLine($"Please, input a {i+1} number");
                enteredNumber = int.Parse(Console.ReadLine());
                return enteredNumber;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return GetNumber(i);
            }
        }
        static List<int> GetNumbersToList(int numbers){
            Console.WriteLine(" ");
            List<int> list = new List<int>();
            for (int i = 0; i < numbers; i++) {
                list.Add(GetNumber(i));   
            }
            return list;
        }
        static void PrintList(List<int> list, int flag) {
            switch (flag) {
                default:
                    Console.WriteLine("List: ");
                    break;
                case 0:
                    Console.WriteLine("Even List: ");
                    break;
                case 1:
                    Console.WriteLine("Not even List: ");
                    break;
            }
           
            foreach (int variable in list) {
                Console.Write($"{variable}  " );
            }
            Console.WriteLine();
        }
        static List<int> GetAllEvenNumbers(List<int> list) {
            List<int> evenList = new List<int>();
            foreach (int variable in list) {
                if (variable % 2 == 0) {
                    evenList.Add(variable);
                }
            }
            return evenList;
        }
        static List<int> GetAllNotEvenNumbers(List<int> list)
        {
            List<int> notEvenList = new List<int>();
            foreach (int variable in list)
            {
                if ((variable%2)!= 0)
                {
                    notEvenList.Add(variable);
                }
            }
            return notEvenList;
        }
        static void ClearList(List<int> list) {
            foreach (int variable in list) {
                list.Remove(variable);
            }
        }
    }
}
