using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WinCCOAOutsideInfoRepo.Pages
{
    public class StructInfoModel : PageModel
    {
        [BindProperty]
        public string StructName { get; set; }

        [BindProperty]
        public int NumMembers { get; set; }

        public string[] MemberTypes { get; set; }

        public string GeneratedStruct { get; private set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            MemberTypes = new string[NumMembers];
            for (int i = 0; i < NumMembers; i++)
            {
                MemberTypes[i] = Request.Form["MemberType_" + i];
            }

            GenerateStructExample();

            // Store input values in TempData
            TempData[nameof(StructName)] = StructName;
            TempData[nameof(NumMembers)] = NumMembers;
            for (int i = 0; i < NumMembers; i++)
            {
                TempData[$"MemberType_{i}"] = MemberTypes[i];
            }

            return Page();
        }

        private void GenerateStructExample()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"struct {StructName} {{");
            for (int i = 0; i < NumMembers; i++)
            {
                sb.AppendLine($"    {MemberTypes[i]} member{i};");
            }
            sb.AppendLine($"}}");

            GeneratedStruct = sb.ToString();
        }
    }
}
