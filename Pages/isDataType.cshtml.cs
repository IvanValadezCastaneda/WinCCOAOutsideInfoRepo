using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WinCCOAOutsideInfoRepo.Pages
{
    public class isDataTypeModel : PageModel
    {
        [BindProperty]
        public string UserInput { get; set; }
        public string DataTypeMessage { get; set; }

        public void OnPost()
        {
            if (int.TryParse(UserInput, out int _))
            {
                DataTypeMessage = "int";
            }
            else if (double.TryParse(UserInput, out double _))
            {
                DataTypeMessage = "double";
            }
            else if (bool.TryParse(UserInput, out bool _))
            {
                DataTypeMessage = "bool";
            }
            else
            {
                DataTypeMessage = "string";
            }
        }
    }
}
