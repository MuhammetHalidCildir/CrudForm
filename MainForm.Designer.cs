
namespace CrudForm
{
    partial class MainForm
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAllEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getAllEmployees,
            this.addNewEmployee});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // getAllEmployees
            // 
            this.getAllEmployees.Name = "getAllEmployees";
            this.getAllEmployees.Size = new System.Drawing.Size(180, 22);
            this.getAllEmployees.Text = "All Employees";
            this.getAllEmployees.Click += new System.EventHandler(this.getAllEmployees_Click);
            // 
            // addNewEmployee
            // 
            this.addNewEmployee.Name = "addNewEmployee";
            this.addNewEmployee.Size = new System.Drawing.Size(180, 22);
            this.addNewEmployee.Text = "Add New";
            this.addNewEmployee.Click += new System.EventHandler(this.addNewEmployee_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "C.R.U.D. Form";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getAllEmployees;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployee;
    }
}

