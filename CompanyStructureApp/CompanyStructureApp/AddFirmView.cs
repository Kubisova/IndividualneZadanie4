using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models;

namespace CompanyStructureApp
{
    public partial class AddFirmView : Form
    {
        private AddFirmViewModel _addFirmViewModel;

        public AddFirmView(AddFirmViewModel addFirmViewModel)
        {
            _addFirmViewModel = addFirmViewModel;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            _addFirmViewModel.GetEmployees();

            foreach (Employee employee in _addFirmViewModel.Employees)
            {
                cmbHeadOfFirm.Items.Add($"{employee.Name} {employee.Surname}");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _addFirmViewModel.HeadOfFirmId = _addFirmViewModel.Employees[cmbHeadOfFirm.SelectedIndex].EmployeeId; 
            _addFirmViewModel.AddFirm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BindControls()
        {
            txtCode.DataBindings.Add(nameof(txtCode.Text),
                _addFirmViewModel,
                nameof(_addFirmViewModel.FirmCode),
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            txtName.DataBindings.Add(nameof(txtName.Text),
                _addFirmViewModel,
                nameof(_addFirmViewModel.FirmName),
                true,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {

        }
    }
}
