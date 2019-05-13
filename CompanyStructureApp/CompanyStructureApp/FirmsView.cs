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
    public partial class FirmsView : Form
    {
        public FirmsView()
        {
            InitializeComponent();
        }

        private void btnAddFirm_Click(object sender, EventArgs e)
        {
            using (var AddFirmView = new AddFirmView(new AddFirmViewModel()))
            {
                AddFirmView.StartPosition = FormStartPosition.CenterParent;
                AddFirmView.ShowDialog();
            }
        }

        private void btnEditFirm_Click(object sender, EventArgs e)
        {

        }

        private void btnShowFirm_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {

        }
    }
}
