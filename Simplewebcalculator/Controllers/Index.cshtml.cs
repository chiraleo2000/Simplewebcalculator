using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculatorApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public double Number1 { get; set; }
        [BindProperty]
        public double Number2 { get; set; }
        [BindProperty]
        public string Operation { get; set; }

        public double? Result { get; set; }

        public void OnPost()
        {
            switch (Operation)
            {
                case "add":
                    Result = Number1 + Number2;
                    break;
                case "subtract":
                    Result = Number1 - Number2;
                    break;
                case "multiply":
                    Result = Number1 * Number2;
                    break;
                case "divide":
                    Result = Number1 / Number2;
                    break;
            }
        }
    }
}
