using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpiricalFormulae
{
    public partial class CalculatorWindow : Form
    {
        string[] mode = new string[2] { "Element",  "Mass" };
        Dictionary<string, Button> subModeButtons = new Dictionary<string, Button>();
        Dictionary<string, double> currentTableElements = new Dictionary<string, double>();
        Table table;
        public CalculatorWindow()
        {
            InitializeComponent();
            // Sub mode buttons
            subModeButtons.Add("Mass", massButton);
            subModeButtons.Add("Abundance", abundanceButton);
            // Update window
            updateWindowWithCurrMode();
        }

        private void updateWindowWithCurrMode()
        {
            // Disable curr modes button
            subModeButtons[mode[1]].Enabled = false;
            // If new mode is Mass enable Abundance button and enable units.
            if (mode[1] == "Mass")
            {
                subModeButtons["Abundance"].Enabled = true;
                unitSelectorComboBox.Enabled = true;
            }
            // If new mode is Abundance enable Mass button and disable units.
            else
            {
                subModeButtons["Mass"].Enabled = true;
                unitSelectorComboBox.Enabled = false;
                unitSelectorComboBox.SelectedItem = null;
            }

            // Reset the element selector combo box.
            selectorComboBox.Items.Clear();
            foreach (string element in Consts.elements.Keys)
            {
                selectorComboBox.Items.Add(element);
            }

            // Change table to new main mode
            table = new Table(mode[0], mode[1], "Units");
            tableLabel.Text = table.GetTableString();

            // Clear the curr elements dict
            currentTableElements.Clear();

            // Set mode label text
            modeLabel.Text = $"Mode: {mode[0]} => {mode[1]}";

            // Set prompt text
            addPromptLabel.Text = $"Add {mode[0]}:";
            selectPromptLabel.Text = $"Select {mode[0]}:";

            // Clear the result label
            resultLabel.Text = "";
        }

        private void abundanceButton_Click(object sender, EventArgs e)
        {
            // Change sub mode
            mode[1] = "Abundance";
            // Update window
            updateWindowWithCurrMode();
        }

        private void massButton_Click(object sender, EventArgs e)
        {
            // Change sub mode
            mode[1] = "Mass";
            // Update window
            updateWindowWithCurrMode();
        }

        private void elementsModeButton_Click(object sender, EventArgs e)
        {
            // Change mode
            mode[0] = "Element";
            // Update window
            updateWindowWithCurrMode();
        }

        private void combustionProductsModeButton_Click(object sender, EventArgs e)
        {
            // Change mode
            mode[0] = "Combustion Product";
            // Update window
            updateWindowWithCurrMode();
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            // Check that there is selected data in each input field
            List<string> fields = new List<string>();
            if (selectorComboBox.SelectedItem == null)
            {
                fields.Add(mode[0]);
            }
            if (amountInputBox.Text == null || amountInputBox.Text == "")
            {
                fields.Add("Amount");
            }
            if (unitSelectorComboBox.SelectedItem == null & mode[1] != "Abundance")
            {
                fields.Add("Units");
            }
            if (fields.Count != 0)
            {
                string fieldsstr = "";
                fields.ForEach(field => fieldsstr += $"- {field}\n");
                MessageBox.Show($"The following field(s) need to have something selected/typed in:\n{fieldsstr}",
                    "Insufficient Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            // Check that the amount inputted is an integer
            string stramount = amountInputBox.Text;
            double amount;
            // If entered data type is not a number.
            if (!double.TryParse(stramount, out amount))
            {
                MessageBox.Show($"In the 'Amount' field the inputted data must be a positive floating point decimal or integer.",
                    "Incorrect Data Type",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }
            // OR if entered data type is zero or negative.
            else if (amount <= 0)
            {
                MessageBox.Show($"In the 'Amount' field the inputted data must be a positive floating point decimal or integer.",
                    "Incorrect Data Type",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            string element = selectorComboBox.SelectedItem.ToString();
            string unit;
            // Override units if abundance mode is being used
            if (mode[1] == "Abundance")
            {
                unit = "%";
            }
            else
            {
                unit = unitSelectorComboBox.SelectedItem.ToString();
            }

            // Add current data to table and clear the input fields
            table.AddRow(element, amount.ToString(), unit);
            tableLabel.Text = table.GetTableString();

            // Clear current inputs and remove element
            selectorComboBox.Items.Remove(selectorComboBox.SelectedItem);
            amountInputBox.Text = "";
            unitSelectorComboBox.SelectedItem = null;

            // Add element and mass to the curr elements dict
            double mass; // Mass is converted into grams
            switch (unit)
            {
                case "mg":
                    mass = amount * Math.Pow(10, -3);
                    break;
                case "g":
                    mass = amount;
                    break;
                case "kg":
                    mass = amount * Math.Pow(10, 3);
                    break;
                case "t":
                    mass = amount * Math.Pow(10, 6);
                    break;
                case "%":
                    mass = amount;
                    break;
                default:
                    mass = 0;
                    break;
            }
            currentTableElements.Add(element, mass);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateWindowWithCurrMode();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Firstly check if there is an element in the table
            List<string> fields = new List<string>();
            if (currentTableElements.Count == 0)
            {
                fields.Add($"There needs to be at least one '{mode[0]}' in the table.");
            }
            // Check abundances add to 100% if the mode is Abundance
            if (mode[1] == "Abundance")
            {
                double totalAbundance = 0;
                foreach (double abundance in currentTableElements.Values)
                {
                    totalAbundance += abundance;
                }
                // If total abundance is not 100
                if (totalAbundance != 100)
                {
                    MessageBox.Show($"You entered '{mode[0]}s' with a total abundance of {totalAbundance}%. The total abundance must add to 100%.",
                    "Total Abundance Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                }
            }
            if (fields.Count != 0)
            {
                string fieldsstr = "";
                fields.ForEach(field => fieldsstr += $"- {field}\n");
                MessageBox.Show($"The following field(s) need to have some action taken on them before a calculation is carried out:\n{fieldsstr}",
                    "Insufficient Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            // Calculate the empirical formula of the compound
            resultLabel.Text = Calculator.FormulaFromElements(currentTableElements);

        }
    }
}
