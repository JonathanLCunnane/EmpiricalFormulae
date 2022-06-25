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
            // If new mode is Mass enable Abundance button and return all elements to the selector.
            if (mode[1] == "Mass")
            {
                subModeButtons["Abundance"].Enabled = true;
                selectorComboBox.Items.Clear();
                foreach (string element in Consts.elements.Keys)
                {
                    selectorComboBox.Items.Add(element);
                }
            }
            // If new mode is Abundance enable Mass button
            else
            {
                subModeButtons["Mass"].Enabled = true;
            }

            // Change table to new main mode
            table = new Table(mode[0], mode[1], "Units");
            tableLabel.Text = table.GetTableString();

            // Set mode label text
            modeLabel.Text = $"Mode: {mode[0]} => {mode[1]}";

            // Set prompt text
            addPromptLabel.Text = $"Add {mode[0]}:";
            selectPromptLabel.Text = $"Select {mode[0]}:";
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
            if (unitSelectorComboBox.SelectedItem == null)
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
            
            // Add current data to table and clear the input fields
            table.AddRow(selectorComboBox.SelectedItem.ToString(), amountInputBox.Text, unitSelectorComboBox.SelectedItem.ToString());
            tableLabel.Text = table.GetTableString();

            // Clear current inputs and remove element
            selectorComboBox.Items.Remove(selectorComboBox.SelectedItem);
            amountInputBox.Text = "";
            unitSelectorComboBox.SelectedItem = null;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateWindowWithCurrMode();
        }
    }
}
