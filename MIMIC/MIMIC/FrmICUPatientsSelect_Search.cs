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
    public partial class FrmICUPatientsSelect_Search : DockContent
    {
        public FrmICUPatientsSelect_Search()
        {
            InitializeComponent();
        }

        private void FrmICUPatientsSelect_Search_Load(object sender, EventArgs e)
        {
            PatientsServiceSoapClient ss = new PatientsServiceSoapClient();
            DataTable dt = ss.ICUSelectPatients(FrmICUPatientsSelect.patients);
            DGViewPatients.DataSource = dt.DefaultView;
        }
    }
}
