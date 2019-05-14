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
    public partial class EmployeeView : Form
    {
        private EmployeeViewModel _employeeViewModel;

        public EmployeeView(EmployeeViewModel employeeViewModel)
        {
            _employeeViewModel = employeeViewModel;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void BindControls()
        {
            txtName.DataBindings.Add(nameof(txtName.Text),
                _employeeViewModel,
                nameof(_employeeViewModel.Name),
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            txtSurname.DataBindings.Add(nameof(txtSurname.Text),
                _employeeViewModel,
                nameof(_employeeViewModel.Surname),
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            numtxtPhone.DataBindings.Add(nameof(numtxtPhone.Text),
                _employeeViewModel,
                nameof(_employeeViewModel.Phone),
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            txtEmail.DataBindings.Add(nameof(txtEmail.Text),
                _employeeViewModel,
                nameof(_employeeViewModel.Email),
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            
        }
    }
}
