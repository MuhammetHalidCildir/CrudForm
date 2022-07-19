using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void getAllEmployees_Click(object sender, EventArgs e)
        {
            EmployeeList employeeList = new EmployeeList();
            if (IsOpen(employeeList))
            {
                employeeList.MdiParent = this;
                employeeList.Show();
            }
        }

        private void addNewEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            if (IsOpen(employeeForm))
            {
                employeeForm.MdiParent = this;
                employeeForm.ID = 0;
                employeeForm.Show();
            }

        }

        private bool IsOpen(Form form)
        {
            if (form != null)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name.Equals(form.Name))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
