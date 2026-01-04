using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
// this is where we write the backend c# code for the homepage
namespace html.Pages;

public class IndexModel : PageModel
{   
    [BindProperty]
    public string Username{get; set;} = ""; // stores username from frontend form, "" for if user doesnt submit anything, avoids error down the line (same as required in cshtml -  i prefer required)

    [BindProperty]
    public bool Newsletter{get; set;} // stores if user wants to subscribe to a newsletter

    public bool Submitted{get; set;} // stores if the form has been submitted?
    public void OnPost() // conventional naming method
    {
        Submitted = true;
    }
}
