using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricalFormulae
{
    public class Table
    {
        private readonly string[] tableTitles;
        private readonly List<int> widths;
        private readonly List<string[]> rows = new List<string[]>();

        public Table(params string[] titles)
        {
            tableTitles = titles;
            widths = titles.Select(title => title.Length).ToList();
        }

        public void AddRow(params string[] cells)
        {
            // Check that the number of cells entered for the new row matches up with the title number
            if (cells.Length != tableTitles.Length)
            {
                throw new Exception($"You cannot add a row of length {cells.Length} when there are {tableTitles.Length} titles in the table.");
            }
            rows.Add(cells);
            // Change the length of the table columns based on the new inputted cell widths.
            for (int cellIndex = 0; cellIndex < cells.Length; cellIndex++)
            {
                // Increase width for current column if the width of the new cell in that column is greater than the current width
                if (cells[cellIndex].Length > widths[cellIndex])
                {
                    widths[cellIndex] = cells[cellIndex].Length;
                }
            }
        }

        public string GetTableString()
        {
            string table = "";
            // Add top border
            widths.ForEach(width => table += ("+-" + new string('-', width) + "-"));
            table += "+\n";

            // Add titles
            for (int titleIndex = 0; titleIndex < tableTitles.Length; titleIndex++)
            {
                table += ("| " + tableTitles[titleIndex].PadRight(widths[titleIndex]) + " ");
            }
            table += "|\n";

            // Add lower title border
            widths.ForEach(width => table += ("+-" + new string('-', width) + "-"));
            table += "+\n";

            // Add each row
            foreach (string[] row in rows)
            {
                for (int cellIndex = 0; cellIndex < row.Length; cellIndex++)
                {
                    table += "| " + row[cellIndex].PadRight(widths[cellIndex]) + " ";
                }
                table += "|\n";
            }

            // Add lower border
            widths.ForEach(width => table += ("+-" + new string('-', width) + "-"));
            table += "+";

            return table;
        }
    }
}
