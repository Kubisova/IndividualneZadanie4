using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyStructureApp
{
    public partial class EmployeesView : Form
    {
        private EmployeesViewModel _employeesViewModel;

        public EmployeesView(EmployeesViewModel employeesViewModel)
        {
            _employeesViewModel = employeesViewModel;
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (var employeeView = new EmployeeView(new EmployeeViewModel()))
            {
                employeeView.StartPosition = FormStartPosition.CenterParent;
                employeeView.ShowDialog();
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnShowEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EmployeesView_Load(object sender, EventArgs e)
        {
            _employeesViewModel.GetEmployees();
            dgvEmployees.DataSource = _employeesViewModel.Employees;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
