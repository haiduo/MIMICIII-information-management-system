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
    public partial class Table17 : DockContent
    {
        public Table17()
        {
            InitializeComponent();
        }

        private void Table17_Load(object sender, EventArgs e)
        {
            PatientsServiceSoapClient ss = new PatientsServiceSoapClient();
            DataTable dt = ss.SearchTable17();
            DGViewPatients.DataSource = dt.DefaultView;
        }
    }
}
