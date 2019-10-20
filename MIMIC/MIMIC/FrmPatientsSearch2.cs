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
    public partial class FrmPatientsSearch2 : DockContent
    {
        public FrmPatientsSearch2()
        {
            InitializeComponent();
        }

        private void FrmPatientsSearch2_Load(object sender, EventArgs e)
        {
            PatientsServiceSoapClient ss = new PatientsServiceSoapClient();
            DataTable dt = ss.SearchPatients2();
            DGViewPatients.DataSource = dt.DefaultView;
        }
    }
}
