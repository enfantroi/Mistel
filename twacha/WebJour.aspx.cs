using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace twacha
{
    public partial class WebJour : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.peséeTableAdapter b = new DataSet1TableAdapters.peséeTableAdapter();
            DataSet1TableAdapters.PosteTableAdapter c = new DataSet1TableAdapters.PosteTableAdapter();
            DataSet1 i = new DataSet1();
            b.Fill(i.pesée);
            c.Fill(i.Poste);
            CrystalReportJour ab = new CrystalReportJour();
            ab.SetDataSource(i);
            ab.SetParameterValue("Jour", DateTime.Today.AddDays(-1).Date.ToString());


            CrystalReportViewer1.ReportSource = ab;
        }

        protected void CrystalReportViewer1_Init(object sender, EventArgs e)
        {

        }
    }
}