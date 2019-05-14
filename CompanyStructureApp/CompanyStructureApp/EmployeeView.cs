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
    }
}
