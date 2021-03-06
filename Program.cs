﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleExpenseTracking_withClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //this app will be a simple recorder of all the expenses and will use a text file to keep the information
            Console.WriteLine("What month is it?");
            var newName = Console.ReadLine();
            var book1 = new ExpenseBook(newName);
            Console.WriteLine($"Your expense book will be for the month of {book1.BookName}");

            FileAccesser.WriteToFile(book1.BookName);

            Console.WriteLine("Type expense amount, type q to exit");
            FileAccesser.WriteAValue("Expenses list: ");

            string keyInput = "";

            while (keyInput != "q")
            {
                keyInput = Console.ReadLine();
                try
                {
                    book1.AddExpense(double.Parse(keyInput));
                    FileAccesser.WriteAValue(double.Parse(keyInput));
                }
                catch
                {
                    continue;
                }
                
            }

            book1.ShowAllExpenses();

            double totalSpent = book1.CalculateTotalSpending();//get the total number of monthly spending

            Console.WriteLine("\tYour total spending for this month is: " + totalSpent);
            //get the estimate in 10 years
            Console.WriteLine("Total amount of money such spending costs you in 10 years is: \n" + 
                String.Format("{0:0.##}", WealthEstimator.GetEstimate(totalSpent)));

            //try to write it to a file
            FileAccesser.WriteToFile(WealthEstimator.GetEstimate(totalSpent));
        }
    }
}
