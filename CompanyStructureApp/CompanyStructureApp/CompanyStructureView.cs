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
    public partial class CompanyStructureView : Form
    {
        private CompanyStructureViewModel _companyStructureViewModel;
        private int _firmId; 

        public CompanyStructureView(CompanyStructureViewModel companyStructureViewModel, int firmId)
        {
            _companyStructureViewModel = companyStructureViewModel;
            _companyStructureViewModel.GetFirmById(firmId);
            _firmId = firmId;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddDivision_Click(object sender, EventArgs e)
        {
            using (var addFirmView = new AddFirmView(new AddFirmViewModel(), Data.TypeOfNode.Division, _firmId))
            {
                addFirmView.StartPosition = FormStartPosition.CenterParent;
                addFirmView.ShowDialog();

                if (addFirmView.DialogResult == DialogResult.OK)
                {
                    _companyStructureViewModel.GetDivisions();
                    dGVDivision.DataSource = _companyStructureViewModel.Divisions;
                }
            }
        }

        private void CompanyStructureView_Load(object sender, EventArgs e)
        {
            txtFirmCode.Text = _companyStructureViewModel.Firm.CodeOfNode;
            txtFirmName.Text = _companyStructureViewModel.Firm.NameOfNode;
            //txtHeadOfFirm.Text = _companyStructureViewModel.Firm.HeadOfNodeId;

            LoadGridDivisions();
            LoadGridProjects();
        }

        private void LoadGridDivisions()
        {
            _companyStructureViewModel.GetDivisions();
            dGVDivision.DataSource = _companyStructureViewModel.Divisions;
            dGVDivision.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVDivision.Columns[0].Visible = false;
            dGVDivision.Columns[3].Visible = false;
            dGVDivision.Columns[4].Visible = false;
        }

        private void LoadGridProjects()
        {
            _companyStructureViewModel.GetProjects();
            dGVProject.DataSource = _companyStructureViewModel.Projects;
        }
    }
}
