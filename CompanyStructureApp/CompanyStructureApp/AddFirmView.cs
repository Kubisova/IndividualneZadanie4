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
    public partial class AddFirmView : Form
    {
        private AddFirmViewModel _addFirmViewModel;

        public AddFirmView(AddFirmViewModel addFirmViewModel)
        {
            _addFirmViewModel = addFirmViewModel;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _addFirmViewModel.AddFirm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BindControls()
        {
            numTBCode.DataBindings.Add(nameof(numTBCode.Text),
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
    }
}
