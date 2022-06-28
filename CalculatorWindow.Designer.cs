
namespace EmpiricalFormulae
{
    partial class CalculatorWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorWindow));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementsModeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.combustionProductsModeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeLabel = new System.Windows.Forms.Label();
            this.tableLabel = new System.Windows.Forms.Label();
            this.massButton = new System.Windows.Forms.Button();
            this.abundanceButton = new System.Windows.Forms.Button();
            this.addPromptLabel = new System.Windows.Forms.Label();
            this.amountInputBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.selectPromptLabel = new System.Windows.Forms.Label();
            this.selectorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.unitSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.mrCheckBox = new System.Windows.Forms.CheckBox();
            this.mrTextBox = new System.Windows.Forms.TextBox();
            this.resultPromptLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.Window;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(584, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elementsModeButton,
            this.combustionProductsModeButton});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // elementsModeButton
            // 
            this.elementsModeButton.Name = "elementsModeButton";
            this.elementsModeButton.Size = new System.Drawing.Size(190, 22);
            this.elementsModeButton.Text = "Elements";
            this.elementsModeButton.Click += new System.EventHandler(this.elementsModeButton_Click);
            // 
            // combustionProductsModeButton
            // 
            this.combustionProductsModeButton.Name = "combustionProductsModeButton";
            this.combustionProductsModeButton.Size = new System.Drawing.Size(190, 22);
            this.combustionProductsModeButton.Text = "Combustion Products";
            this.combustionProductsModeButton.Click += new System.EventHandler(this.combustionProductsModeButton_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(13, 28);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(39, 13);
            this.modeLabel.TabIndex = 1;
            this.modeLabel.Text = "MODE";
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLabel.Location = new System.Drawing.Point(16, 45);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(40, 11);
            this.tableLabel.TabIndex = 2;
            this.tableLabel.Text = "TABLE";
            // 
            // massButton
            // 
            this.massButton.Location = new System.Drawing.Point(326, 45);
            this.massButton.Name = "massButton";
            this.massButton.Size = new System.Drawing.Size(75, 23);
            this.massButton.TabIndex = 3;
            this.massButton.Text = "Mass";
            this.massButton.UseVisualStyleBackColor = true;
            this.massButton.Click += new System.EventHandler(this.massButton_Click);
            // 
            // abundanceButton
            // 
            this.abundanceButton.Location = new System.Drawing.Point(407, 45);
            this.abundanceButton.Name = "abundanceButton";
            this.abundanceButton.Size = new System.Drawing.Size(75, 23);
            this.abundanceButton.TabIndex = 4;
            this.abundanceButton.Text = "Abundance";
            this.abundanceButton.UseVisualStyleBackColor = true;
            this.abundanceButton.Click += new System.EventHandler(this.abundanceButton_Click);
            // 
            // addPromptLabel
            // 
            this.addPromptLabel.AutoSize = true;
            this.addPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPromptLabel.Location = new System.Drawing.Point(323, 26);
            this.addPromptLabel.Name = "addPromptLabel";
            this.addPromptLabel.Size = new System.Drawing.Size(94, 16);
            this.addPromptLabel.TabIndex = 5;
            this.addPromptLabel.Text = "Add MODE[0]:";
            // 
            // amountInputBox
            // 
            this.amountInputBox.Location = new System.Drawing.Point(326, 127);
            this.amountInputBox.Name = "amountInputBox";
            this.amountInputBox.Size = new System.Drawing.Size(100, 20);
            this.amountInputBox.TabIndex = 6;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(323, 111);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(74, 13);
            this.amountLabel.TabIndex = 7;
            this.amountLabel.Text = "Enter Amount:";
            // 
            // selectPromptLabel
            // 
            this.selectPromptLabel.AutoSize = true;
            this.selectPromptLabel.Location = new System.Drawing.Point(323, 71);
            this.selectPromptLabel.Name = "selectPromptLabel";
            this.selectPromptLabel.Size = new System.Drawing.Size(87, 13);
            this.selectPromptLabel.TabIndex = 8;
            this.selectPromptLabel.Text = "Select MODE[0]:";
            // 
            // selectorComboBox
            // 
            this.selectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectorComboBox.FormattingEnabled = true;
            this.selectorComboBox.Location = new System.Drawing.Point(326, 87);
            this.selectorComboBox.Name = "selectorComboBox";
            this.selectorComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectorComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Units:";
            // 
            // unitSelectorComboBox
            // 
            this.unitSelectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitSelectorComboBox.FormattingEnabled = true;
            this.unitSelectorComboBox.Items.AddRange(new object[] {
            "g",
            "mg",
            "t"});
            this.unitSelectorComboBox.Location = new System.Drawing.Point(436, 127);
            this.unitSelectorComboBox.Name = "unitSelectorComboBox";
            this.unitSelectorComboBox.Size = new System.Drawing.Size(121, 21);
            this.unitSelectorComboBox.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(326, 154);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(326, 244);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(231, 23);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "Calculate Empirical Formula";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // mrCheckBox
            // 
            this.mrCheckBox.AutoSize = true;
            this.mrCheckBox.Location = new System.Drawing.Point(326, 221);
            this.mrCheckBox.Name = "mrCheckBox";
            this.mrCheckBox.Size = new System.Drawing.Size(44, 17);
            this.mrCheckBox.TabIndex = 14;
            this.mrCheckBox.Text = "Mr: ";
            this.mrCheckBox.UseVisualStyleBackColor = true;
            this.mrCheckBox.CheckedChanged += new System.EventHandler(this.mrCheckBox_CheckedChanged);
            // 
            // mrTextBox
            // 
            this.mrTextBox.Enabled = false;
            this.mrTextBox.Location = new System.Drawing.Point(371, 221);
            this.mrTextBox.Name = "mrTextBox";
            this.mrTextBox.Size = new System.Drawing.Size(100, 20);
            this.mrTextBox.TabIndex = 15;
            // 
            // resultPromptLabel
            // 
            this.resultPromptLabel.AutoSize = true;
            this.resultPromptLabel.Location = new System.Drawing.Point(326, 274);
            this.resultPromptLabel.Name = "resultPromptLabel";
            this.resultPromptLabel.Size = new System.Drawing.Size(40, 13);
            this.resultPromptLabel.TabIndex = 16;
            this.resultPromptLabel.Text = "Result:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(329, 291);
            this.resultLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 17;
            // 
            // CalculatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultPromptLabel);
            this.Controls.Add(this.mrTextBox);
            this.Controls.Add(this.mrCheckBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.unitSelectorComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectorComboBox);
            this.Controls.Add(this.selectPromptLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.amountInputBox);
            this.Controls.Add(this.addPromptLabel);
            this.Controls.Add(this.abundanceButton);
            this.Controls.Add(this.massButton);
            this.Controls.Add(this.tableLabel);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "CalculatorWindow";
            this.Text = "Empirical Formulae Calculator";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementsModeButton;
        private System.Windows.Forms.ToolStripMenuItem combustionProductsModeButton;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.Button massButton;
        private System.Windows.Forms.Button abundanceButton;
        private System.Windows.Forms.Label addPromptLabel;
        private System.Windows.Forms.TextBox amountInputBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label selectPromptLabel;
        private System.Windows.Forms.ComboBox selectorComboBox;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox unitSelectorComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.CheckBox mrCheckBox;
        private System.Windows.Forms.TextBox mrTextBox;
        private System.Windows.Forms.Label resultPromptLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}

