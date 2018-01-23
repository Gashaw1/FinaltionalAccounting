using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class Expense : BusinessOwner
    {
        public int ExpenseID { get; set; }        
        public double expenseAmount { get; set; }
        ExpenseType expenseType { get; set; }
        public string Items { get; set; }        
        public DateTime dateTime { get; set; }
    }

    enum ExpenseType
    {
        wageExpense,
        rentExpense,
        suppliesExpense,
        utitlityEzpesne,
        miscellaneourExpense
    }
}
