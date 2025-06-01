using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Data.Service
{
    public class ExpensesService : IExpensesService
    {
        private readonly ExpenseTrackerContext _context;

        public ExpensesService(ExpenseTrackerContext context)
        {
            _context = context;
        }
        public  async Task Add(Expense expense)
        {
            _context.Expenses.Add(expense);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Expense>> GetAll()
        {

            var expenses = await _context.Expenses.ToListAsync();
            return expenses;
        }
    }
}
