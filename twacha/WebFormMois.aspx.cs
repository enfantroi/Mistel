using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace twacha
{
    public partial class WebFormMois : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataSet1TableAdapters.peséeTableAdapter b = new DataSet1TableAdapters.peséeTableAdapter();
            DataSet1TableAdapters.PosteTableAdapter c = new DataSet1TableAdapters.PosteTableAdapter();
            DataSet1 i = new DataSet1();
            b.Fill(i.pesée);
            c.Fill(i.Poste);
            CrystalReportMois ab = new CrystalReportMois();
            ab.SetDataSource(i);
            ab.SetParameterValue("Mois", DateTime.Now.Month);
            ab.SetParameterValue("Annee", DateTime.Now.Year);

            CrystalReportViewer1.ReportSource = ab;
        }

        protected void CrystalReportViewer1_Init(object sender, EventArgs e)
        {

        }
    }
}