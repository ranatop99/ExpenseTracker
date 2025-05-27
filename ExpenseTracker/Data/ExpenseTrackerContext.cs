using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;
namespace ExpenseTracker.Data
{
    public class ExpenseTrackerContext : DbContext
    {
        public ExpenseTrackerContext(DbContextOptions<ExpenseTrackerContext> options): base(options)
        {

        }

        DbSet<Expense> Expenses { get; set; }  



    }
  
}
