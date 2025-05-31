using ExpenseTracker.Data;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly ExpenseTrackerContext _context;

        public ExpensesController(ExpenseTrackerContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            var expenses = _context.Expenses.ToList();
            return View(expenses);
        }
    }
}
