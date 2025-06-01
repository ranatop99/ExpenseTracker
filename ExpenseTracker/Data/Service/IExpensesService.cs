using ExpenseTracker.Models;
namespace ExpenseTracker.Data.Service
{
    public interface IExpensesService
    {
        Task<IEnumerable<Expense>> GetAll();
        Task Add(Expense expense);
    }
}
