using CrudForm.Data;
using CrudForm.Data.Repositories;
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
    public partial class EmployeeForm : Form
    {
        private void Buttons()
        {
            if (ID > 0)
            {
                btnCreate.Visible = false;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                btnCreate.Visible = true;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
        }
        public int ID { get; set; }
        private Employee employee;
        public EmployeeForm()
        {
            InitializeComponent();
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            lblID.Text = ID.ToString();
            Buttons();
            cbxDepartment.Items.AddRange(Repositories.employeeRepository.ReadMany().Select(x => x.deparment).Distinct().ToArray());
        }

        private void FillEmployee()
        {
            try
            {
                employee = new Employee
                {
                    id = ID,
                    first_name = string.IsNullOrEmpty(txtFirstname.Text)?throw new Exception("Firstname alanı boş olamaz."):txtFirstname.Text,
                    last_name = string.IsNullOrEmpty(txtLastname.Text) ? throw new Exception("Lastname alanı boş olamaz.") : txtLastname.Text,
                    email = string.IsNullOrEmpty(txtEmail.Text) ? throw new Exception("E-Mail alanı boş olamaz.") : txtEmail.Text,
                    address = txtAddress.Text,
                    deparment = cbxDepartment.SelectedItem.ToString(),
                    salary = decimal.Parse(txtSalary.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form Bilgileri Hatalı.\nHata Mesajı:" + ex.Message, "Form Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                FillEmployee();
                Repositories.employeeRepository.Create(employee);
                MessageBox.Show( "Kayıt başarılı.", "Kayıt Ekle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show( "Kayıt başarısız.\nHata Mesajı:" + ex.Message, "Kayıt Ekle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Emin misiniz?", "Son karar mı?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FillEmployee();
                Repositories.employeeRepository.Update(employee);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Emin misiniz?", "Son karar mı?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Repositories.employeeRepository.Delete(ID);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
