using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace WinCCOAOutsideInfoRepo.Pages
{
    public class SQLQueriesModel : PageModel
    {
        [BindProperty]
        public string TableName { get; set; }
        [BindProperty]
        public string Columns { get; set; }
        [BindProperty]
        public string Conditions { get; set; }
        public string GeneratedQuery { get; private set; }

        public void OnPost()
        {
            string[] columnsArray = !string.IsNullOrEmpty(Columns) ? Columns.Split(',') : new string[0];
            string[] conditionsArray = !string.IsNullOrEmpty(Conditions) ? Conditions.Split(new string[] { " AND " }, StringSplitOptions.None) : new string[0];

            GeneratedQuery = GenerateSqlQuery(TableName, columnsArray, conditionsArray);
        }

        private string GenerateSqlQuery(string tableName, string[] columns, string[] conditions)
        {
            string query = "SELECT ";

            if (columns.Length > 0)
            {
                for (int i = 0; i < columns.Length; i++)
                {
                    columns[i] = "\"" + columns[i].Trim() + "\"";
                }
                query += string.Join(", ", columns);
            }
            else
            {
                query += "*";
            }

            query += " FROM \"" + tableName.Trim() + "\"";

            if (conditions.Length > 0)
            {
                for (int i = 0; i < conditions.Length; i++)
                {

                    var conditionParts = conditions[i].Split(new char[] { '=' }, 2);
                    if (conditionParts.Length == 2)
                    {
                        var columnName = conditionParts[0].Trim();
                        var value = conditionParts[1].Trim();

                        if (!int.TryParse(value, out _) && !decimal.TryParse(value, out _) && !bool.TryParse(value, out _))
                        {
                            value = "'" + value + "'";
                        }
                        conditions[i] = "\"" + columnName + "\" = " + value;
                    }
                }
                query += " WHERE " + string.Join(" AND ", conditions);
            }

            return query;
        }

    }
}
