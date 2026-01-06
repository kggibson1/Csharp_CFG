using System.ComponentModel;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BudgetTrackerWebApp.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public double Expense1 {get; set;}

    [BindProperty]
    public double Expense2 {get; set;}

    [BindProperty]
    public double Expense3 {get; set;}

    [BindProperty]
    public double Expense4 {get; set;}

    [BindProperty]
    public double Expense5 {get; set;}

    public double TotalExpenses{get; set;} // dont need to bind as variable will be used for calculating users total expenses
    public void OnPost()
    {
        TotalExpenses = Expense1 + Expense2 + Expense3 + Expense4 + Expense5;
    }
}
