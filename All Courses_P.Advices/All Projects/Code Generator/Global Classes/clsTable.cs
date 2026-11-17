using System;


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global_Classes
{
    public class clsTable
    {
        private string _tablename;



        public string TableName
        {
            get { return _tablename; }
            set { _tablename = value; }
        }

        public string TableSingularName
        {
            get { return GetSingularName(_tablename); }

        }

        public string TableBusinessClassName
        {
            get { return "cls" + TableSingularName; }

        }

        public string TableDataAccessClassName
        {
            get { return TableBusinessClassName + "Data"; }

        }

        public List<clsColumn> ClassColumns { get; set; }

        public List<clsColumn> ProcedureColumns { get; set; }

        public clsTable()
        {

        }


        private static string GetSingularName(string tableName)
        {
            // Handle common irregular plurals first
            var irregulars = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "People", "Person" },
            { "Children", "Child" },
            { "Men", "Man" },
            { "Women", "Woman" },
            { "Teeth", "Tooth" },
            { "Feet", "Foot" },
            { "Mice", "Mouse" },
            { "Geese", "Goose" },
            // Add more irregular plurals as needed
        };

            if (irregulars.TryGetValue(tableName, out string singular))
            {
                return singular;
            }

            // Handle 'ies' plurals (e.g., Countries -> Country)
            if (tableName.EndsWith("ies", StringComparison.OrdinalIgnoreCase))
            {
                string stem = tableName.Substring(0, tableName.Length - 3);
                if (stem.Length > 0 && !IsVowel(stem[stem.Length - 1])) // Check if last character is consonant
                {
                    return stem + "y";
                }
            }

            // Handle 'es' plurals for words ending with s, x, z, ch, sh
            if (tableName.EndsWith("es", StringComparison.OrdinalIgnoreCase))
            {
                string stem = tableName.Substring(0, tableName.Length - 2);
                if (stem.EndsWith("s", StringComparison.OrdinalIgnoreCase) ||
                    stem.EndsWith("x", StringComparison.OrdinalIgnoreCase) ||
                    stem.EndsWith("z", StringComparison.OrdinalIgnoreCase) ||
                    stem.EndsWith("ch", StringComparison.OrdinalIgnoreCase) ||
                    stem.EndsWith("sh", StringComparison.OrdinalIgnoreCase))
                {
                    return stem;
                }
            }

            // Handle simple 's' plurals
            if (tableName.EndsWith("s", StringComparison.OrdinalIgnoreCase))
            {
                return tableName.Substring(0, tableName.Length - 1);
            }

            // Return original if no plural pattern matches
            return tableName;
        }

        private static bool IsVowel(char c)
        {
            char lower = char.ToLower(c);
            return lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u';
        }
    }


}

