using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace twacha
{
    public partial class WebFormA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.peséeTableAdapter b = new DataSet1TableAdapters.peséeTableAdapter();
            DataSet1TableAdapters.PosteTableAdapter c = new DataSet1TableAdapters.PosteTableAdapter();
            DataSet1 i = new DataSet1();
            b.Fill(i.pesée);
            c.Fill(i.Poste);
            CrystalReportA ab = new CrystalReportA();
            ab.SetDataSource(i);
            ab.SetParameterValue("c", Diagrame.c);
            ab.SetParameterValue("d", Diagrame.d);


            CrystalReportViewer1.ReportSource = ab;

        }

        protected void CrystalReportViewer1_Init(object sender, EventArgs e)
        {
            
        }
    }
}