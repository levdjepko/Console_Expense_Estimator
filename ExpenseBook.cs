using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleExpenseTracking_withClasses
{
    class ExpenseBook
    {
        public ExpenseBook(string bookName)
        {
            BookName = bookName ?? throw new ArgumentNullException(nameof(bookName));
        }

        public List<double> allExpenses = new List<double>();
        public double Expense {get; private set;}
        public void AddExpense (double value)
        {
            if (value > 0.00 && value < 1000.00)
            {
                Expense = value;
                allExpenses.Add(Expense);
                Console.WriteLine($"\tExpense of {Expense} has been added to your book");
            }
            else Console.WriteLine("Invlaid amount, should be between 0 and 1000 $");
        }
        public string BookName { get; set; }


        public void ShowAllExpenses()
        {
            foreach (var expense in allExpenses)
            {
                Console.WriteLine($"Your expenses: {expense}");
            }
        }

        public double CalculateTotalSpending()
        {
            double sumOfAllValues = 0.0;
            foreach (var expense in allExpenses)
            {
                sumOfAllValues = sumOfAllValues + expense;
            }
            return sumOfAllValues;
        }
    }


}
