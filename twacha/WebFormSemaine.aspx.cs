using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace twacha
{
    public partial class WebFormSemaine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.peséeTableAdapter b = new DataSet1TableAdapters.peséeTableAdapter();
            DataSet1TableAdapters.PosteTableAdapter c = new DataSet1TableAdapters.PosteTableAdapter();
            DataSet1 i = new DataSet1();
            b.Fill(i.pesée);
            c.Fill(i.Poste);
            CrystalReportSemaine ab = new CrystalReportSemaine();
            ab.SetDataSource(i);
            DateTime d;
            d = DateTime.Today;
            int JourDsSemaine = (int)d.DayOfWeek;
            d = d.AddDays((-1) * JourDsSemaine + 1);
            ab.SetParameterValue("Jour", DateTime.Today.AddDays(-1).Date.ToString());
            ab.SetParameterValue("Semaine", d);


            CrystalReportViewer1.ReportSource = ab;
         
        }
    }
}