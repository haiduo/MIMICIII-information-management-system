using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using MIMIC.PatientsService;

namespace MIMIC
{
    public partial class FrmCaseSelect_Search : DockContent
    {
        public FrmCaseSelect_Search()
        {
            InitializeComponent();
        }

        private void FrmCaseSelect_Search_Load(object sender, EventArgs e)
        {
            PatientsServiceSoapClient ss = new PatientsServiceSoapClient();
            DataTable dt = ss.CaseSelect(FrmCaseSelect.patients);
            DGViewPatients.DataSource = dt.DefaultView;
        }
    }
}
