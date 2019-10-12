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
    public partial class FrmPatientsSelect_Search : DockContent
    {
        public FrmPatientsSelect_Search()
        {
            InitializeComponent();
        }

        private void FrmPatientsSelect_Search_Load(object sender, EventArgs e)
        {
            PatientsServiceSoapClient ss = new PatientsServiceSoapClient();
            DataTable dt = ss.SelectPatients(FrmPatientsSelect.patients);
            DGViewPatients.DataSource = dt.DefaultView;
        }
    }
}
