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
        Table testTable;
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
            // If new mode is Mass enable Abundance button
            if (mode[1] == "Mass")
            {
                subModeButtons["Abundance"].Enabled = true;
            }
            // If new mode is Abundance enable Mass button
            else
            {
                subModeButtons["Mass"].Enabled = true;
            }

            // Change table to new main mode
            testTable = new Table(mode[0], mode[1], "Units");
            tableLabel.Text = testTable.GetTableString();

            // Set mode label text
            modeLabel.Text = $"Mode: {mode[0]} => {mode[1]}";

            // Set prompt text
            addPromptLabel.Text = $"Add {mode[0]}:";
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
    }
}
