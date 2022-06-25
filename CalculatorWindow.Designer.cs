
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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeLabel = new System.Windows.Forms.Label();
            this.tableLabel = new System.Windows.Forms.Label();
            this.massButton = new System.Windows.Forms.Button();
            this.abundanceButton = new System.Windows.Forms.Button();
            this.addPromptLabel = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.Window;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
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
            this.addPromptLabel.Location = new System.Drawing.Point(326, 27);
            this.addPromptLabel.Name = "addPromptLabel";
            this.addPromptLabel.Size = new System.Drawing.Size(73, 13);
            this.addPromptLabel.TabIndex = 5;
            this.addPromptLabel.Text = "Add MODE[0]";
            // 
            // CalculatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
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
    }
}

