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
    public partial class FrmICUPatientsSearch : DockContent
    {
        public FrmICUPatientsSearch()
        {
            InitializeComponent();
        }

        private void FrmICUPatientsSearch_Load(object sender, EventArgs e)
        {
            PatientsServiceSoapClient ss = new PatientsServiceSoapClient();
            DataTable dt = ss.SearchICUPatients();
            DGViewPatients.DataSource = dt.DefaultView;
        }
    }
}
