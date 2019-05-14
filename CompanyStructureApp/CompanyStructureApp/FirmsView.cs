using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace CompanyStructureApp
{
    public partial class FirmsView : Form
    {
        private FirmsViewModel _firmsViewModel;

        public FirmsView(FirmsViewModel firmsViewModel)
        {
            _firmsViewModel = firmsViewModel;
            InitializeComponent();
        }

        private void btnAddFirm_Click(object sender, EventArgs e)
        {
            using (var addFirmView = new AddFirmView(new AddFirmViewModel(), TypeOfNode.Firm))
            {
                addFirmView.StartPosition = FormStartPosition.CenterParent;
                addFirmView.ShowDialog();

                if (addFirmView.DialogResult == DialogResult.OK)
                {
                    _firmsViewModel.GetFirms();
                    dGVFirms.DataSource = _firmsViewModel.Firms;
                }
            }
        }

        private void btnEditFirm_Click(object sender, EventArgs e)
        {

        }

        private void btnShowFirm_Click(object sender, EventArgs e)
        {
            //using (var addFirmView = new AddFirmView(new AddFirmViewModel()))
            //{
            //    addFirmView.StartPosition = FormStartPosition.CenterParent;
            //    addFirmView.ShowDialog();
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            using (var employeesView = new EmployeesView(new EmployeesViewModel()))
            {
                employeesView.StartPosition = FormStartPosition.CenterParent;
                employeesView.ShowDialog();
            }
        }

        private void FirmsView_Load(object sender, EventArgs e)
        {
            _firmsViewModel.GetFirms();
            dGVFirms.DataSource = _firmsViewModel.Firms;
            dGVFirms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVFirms.Columns[0].Visible = false;
            dGVFirms.Columns[3].Visible = false;
            dGVFirms.Columns[4].Visible = false;
        }

        private void btnCompanytStructure_Click(object sender, EventArgs e)
        {
            int index = dGVFirms.CurrentRow.Index;
            int firmId = _firmsViewModel.GetFirmIdByIndex(index);
            using (var companyStructureView = new CompanyStructureView(new CompanyStructureViewModel(),firmId))
            {
                companyStructureView.StartPosition = FormStartPosition.CenterParent;
                companyStructureView.ShowDialog();
            }
        }
    }
}
