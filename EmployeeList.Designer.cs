
namespace CrudForm
{
    partial class EmployeeList
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dataCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.employeeGrid = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.employeeListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seçilenleriAktarAGrubuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aGrubuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGrubuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exceleAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.employeeListMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dataCount
            // 
            this.dataCount.Name = "dataCount";
            this.dataCount.Size = new System.Drawing.Size(0, 17);
            // 
            // employeeGrid
            // 
            this.employeeGrid.AllowUserToAddRows = false;
            this.employeeGrid.AllowUserToDeleteRows = false;
            this.employeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGrid.ContextMenuStrip = this.employeeListMenu;
            this.employeeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeGrid.Location = new System.Drawing.Point(0, 0);
            this.employeeGrid.Name = "employeeGrid";
            this.employeeGrid.ReadOnly = true;
            this.employeeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeGrid.Size = new System.Drawing.Size(800, 362);
            this.employeeGrid.TabIndex = 1;
            this.employeeGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeGrid_CellDoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtEmail);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtLastname);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtFirstname);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.employeeGrid);
            this.splitContainer1.Size = new System.Drawing.Size(800, 428);
            this.splitContainer1.SplitterDistance = 62;
            this.splitContainer1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-Mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(227, 31);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lastname:";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(121, 31);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 20);
            this.txtLastname.TabIndex = 2;
            this.txtLastname.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firstname:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(15, 31);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 20);
            this.txtFirstname.TabIndex = 0;
            this.txtFirstname.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // employeeListMenu
            // 
            this.employeeListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçilenleriAktarAGrubuToolStripMenuItem,
            this.exceleAktarToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.employeeListMenu.Name = "employeeListMenu";
            this.employeeListMenu.Size = new System.Drawing.Size(181, 92);
            // 
            // seçilenleriAktarAGrubuToolStripMenuItem
            // 
            this.seçilenleriAktarAGrubuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aGrubuToolStripMenuItem,
            this.bGrubuToolStripMenuItem});
            this.seçilenleriAktarAGrubuToolStripMenuItem.Name = "seçilenleriAktarAGrubuToolStripMenuItem";
            this.seçilenleriAktarAGrubuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seçilenleriAktarAGrubuToolStripMenuItem.Text = "Seçilenleri Aktar";
            // 
            // aGrubuToolStripMenuItem
            // 
            this.aGrubuToolStripMenuItem.Name = "aGrubuToolStripMenuItem";
            this.aGrubuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aGrubuToolStripMenuItem.Text = "A Grubu";
            this.aGrubuToolStripMenuItem.Click += new System.EventHandler(this.aGrubuToolStripMenuItem_Click);
            // 
            // bGrubuToolStripMenuItem
            // 
            this.bGrubuToolStripMenuItem.Name = "bGrubuToolStripMenuItem";
            this.bGrubuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bGrubuToolStripMenuItem.Text = "B Grubu";
            this.bGrubuToolStripMenuItem.Click += new System.EventHandler(this.bGrubuToolStripMenuItem_Click);
            // 
            // exceleAktarToolStripMenuItem
            // 
            this.exceleAktarToolStripMenuItem.Name = "exceleAktarToolStripMenuItem";
            this.exceleAktarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exceleAktarToolStripMenuItem.Text = "Excel\'e Aktar";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "EmployeeList";
            this.Text = "EmployeeList";
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.employeeListMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel dataCount;
        private System.Windows.Forms.DataGridView employeeGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.ContextMenuStrip employeeListMenu;
        private System.Windows.Forms.ToolStripMenuItem seçilenleriAktarAGrubuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aGrubuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGrubuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exceleAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
    }
}