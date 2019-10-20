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
    public partial class Table13 : DockContent
    {
        public Table13()
        {
            InitializeComponent();
        }

        private void Table13_Load(object sender, EventArgs e)
        {
            PatientsServiceSoapClient ss = new PatientsServiceSoapClient();
            DataTable dt = ss.SearchTable13();
            DGViewPatients.DataSource = dt.DefaultView;
        }
    }
}
