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
using Data;

namespace CompanyStructureApp
{
    public partial class AddFirmView : Form
    {
        private AddFirmViewModel _addFirmViewModel;
        private TypeOfNode _typeOfNode;
        private int _parentId;

        public AddFirmView(AddFirmViewModel addFirmViewModel, TypeOfNode typeOfNode)
        {
            _addFirmViewModel = addFirmViewModel;
            _typeOfNode = typeOfNode;
            InitializeComponent();
            Init();
        }

        public AddFirmView(AddFirmViewModel addFirmViewModel, TypeOfNode typeOfNode, int parentId)
        {
            _addFirmViewModel = addFirmViewModel;
            _typeOfNode = typeOfNode;
            _parentId = parentId;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            _addFirmViewModel.GetEmployeesByFirm();

            foreach (Employee employee in _addFirmViewModel.Employees)
            {
                cmbHeadOfFirm.Items.Add($"{employee.Name} {employee.Surname}");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _addFirmViewModel.CodeOfNode = txtCode.Text;
            _addFirmViewModel.NameOfNode = txtName.Text;
            if (cmbHeadOfFirm.SelectedIndex > -1)
            {
                _addFirmViewModel.HeadOfNodeId = _addFirmViewModel.Employees[cmbHeadOfFirm.SelectedIndex].EmployeeId;
            }

            if (_parentId == 0)
            {
                _addFirmViewModel.AddNode(_typeOfNode);
            }
            else
            {
                _addFirmViewModel.AddNode(_typeOfNode, _parentId);
            }
            
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {

        }
    }
}
