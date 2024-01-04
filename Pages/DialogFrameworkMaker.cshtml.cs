using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;

namespace WinCCOAOutsideInfoRepo.Pages
{
    public class DialogFrameworkMakerModel : PageModel
    {
        [BindProperty] public string DialogType { get; set; }
        [BindProperty] public string Text { get; set; }
        [BindProperty] public string Title { get; set; }
        [BindProperty] public string ButtonTextOk { get; set; }
        [BindProperty] public string ButtonTextNOk { get; set; }
        [BindProperty] public string TitleColor { get; set; }
        // Add other properties as necessary

        public string GeneratedScript { get; private set; }

        public void OnPost()
        {
            var mappingEntries = new Dictionary<string, string>
            {
                {"text", Text},
                {"title", Title},
                {"buttonTextOk", ButtonTextOk},
                {"buttonTextNOk", ButtonTextNOk},
                {"titleColor", TitleColor},
                // Add other dialog options as key-value pairs
            };

            GeneratedScript = GenerateDialogScript(DialogType, mappingEntries);
        }

        private string GenerateDialogScript(string dialogType, Dictionary<string, string> options)
        {
            var scriptBuilder = new StringBuilder();
            scriptBuilder.AppendLine("#uses \"classes/DialogFramework\"");
            scriptBuilder.AppendLine("main()");
            scriptBuilder.AppendLine("{");
            scriptBuilder.Append($"  int answer = DialogFramework::{dialogType}(");
            scriptBuilder.Append("makeMapping(");

            foreach (var entry in options)
            {
                if (!string.IsNullOrEmpty(entry.Value))
                {
                    scriptBuilder.Append($"\"{entry.Key}\", \"{entry.Value}\", ");
                }
            }

            scriptBuilder.Remove(scriptBuilder.Length - 2, 2); // Remove trailing comma and space
            scriptBuilder.AppendLine("));");
            scriptBuilder.AppendLine("  DebugN(\"Button pressed: \" + answer);");
            scriptBuilder.AppendLine("}");

            return scriptBuilder.ToString();
        }
    }
}
