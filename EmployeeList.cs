using CrudForm.Data;
using CrudForm.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudForm
{
    public partial class EmployeeList : Form
    {
        public EmployeeList()
        {
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string fnTerm = txtFirstname.Text.ToLower();
            string lnTerm = txtLastname.Text.ToLower();
            string emTerm = txtEmail.Text.ToLower();

            FillDataGrid(x =>
                (!string.IsNullOrEmpty(fnTerm) && x.first_name.ToLower().Contains(fnTerm)) ||
                (!string.IsNullOrEmpty(lnTerm) && x.last_name.ToLower().Contains(lnTerm)) ||
                (!string.IsNullOrEmpty(emTerm) && x.email.ToLower().Contains(emTerm))
            );
        }

        private void FillDataGrid(Expression<Func<Employee, bool>> expression = null)
        {
            var data = Repositories.employeeRepository.GetEmployeeList(expression);
            employeeGrid.DataSource = data.ToList();
            dataCount.Text = string.Format("Toplam {0} adet kayıt bulunmaktadır.", data.Count());
        }

        private void employeeGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = (int)employeeGrid.Rows[e.RowIndex].Cells[0].Value;
            EmployeeForm employeeForm = new EmployeeForm();
            if (IsOpen(employeeForm))
            {
                employeeForm.ID = ID;
                employeeForm.MdiParent = Application.OpenForms["MainForm"];
                employeeForm.Show();
            }
            else
            {
                employeeForm = null;
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

        private void aGrubuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selected = employeeGrid.SelectedRows;
            List<Employee> selectedEmployees = new List<Employee>();
            foreach (DataGridViewRow item in selected)
            {
                Employee employee = Repositories.employeeRepository.ReadOne(item.Cells[0].Value);
                EmployeeA employeeA = new EmployeeA
                {
                    id = employee.id,
                    first_name = employee.first_name,
                    last_name = employee.last_name,
                    email = employee.email,
                    address = employee.address,
                    salary = employee.salary,
                    deparment = employee.deparment
                };
                Repositories.employeeaRepository.Create(employeeA);
            }
        }

        private void bGrubuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selected = employeeGrid.SelectedRows;
            List<Employee> selectedEmployees = new List<Employee>();
            foreach (DataGridViewRow item in selected)
            {
                Employee employee = Repositories.employeeRepository.ReadOne(item.Cells[0].Value);
                EmployeeB employeeB = new EmployeeB
                {
                    id = employee.id,
                    first_name = employee.first_name,
                    last_name = employee.last_name,
                    email = employee.email,
                    address = employee.address,
                    salary = employee.salary,
                    deparment = employee.deparment
                };
                Repositories.employeebRepository.Create(employeeB);
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
