using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace twacha
{
    public partial class Diagrame : System.Web.UI.Page
    {
       public static DateTime a;
       public static DateTime b;
       public static int c;
       public static int d;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.Text == "")
            {
                string strScript = "<script language='JavaScript'>alert('Sélectionner Intervalle')</script>";
                Page.ClientScript.RegisterStartupScript(GetType(), "PopUp", strScript);
              
            }
            else
            {
                if (RadioButtonList1.Text == "Jour")
                {
                    Response.Redirect("WebJour.aspx");
                }
                else if (RadioButtonList1.Text == "Semaine")
                {
                    Response.Redirect("WebFormSemaine.aspx");
                }
                else if (RadioButtonList1.Text == "Mois")
                {
                    Response.Redirect("WebFormMois.aspx");
                }
                else
                {
                    Response.Redirect("WebFormAnnée.aspx");

                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                string strScript = "<script language='JavaScript'>alert('Veuillez sélectionner la date')</script>";
                Page.ClientScript.RegisterStartupScript(GetType(), "PopUp", strScript);
            }

            else if (RadioButtonList2.Text == "")
            {
                string strScri = "<script language='JavaScript'>alert('Sélectionner Intervalle ')</script>";
                Page.ClientScript.RegisterStartupScript(GetType(), "PopUp", strScri);
            }
            else
            {
                a = DateTime.Parse(TextBox1.Text, new CultureInfo("en-US", false));
                b = DateTime.Parse(TextBox2.Text, new CultureInfo("en-US", false));

                if (RadioButtonList2.Text == "Jour")
                {
                    a = DateTime.Parse(a.Date.ToString());
                    b = DateTime.Parse(b.Date.ToString());
                    Response.Redirect("WebFormJ.aspx");
                }
                else if (RadioButtonList2.Text == "Mois")
                {


                    c = int.Parse(a.Date.Month.ToString());
                    d = int.Parse(b.Date.Month.ToString());
                    Response.Redirect("WebFormM.aspx");
                }

                else
                {
                    c = int.Parse(a.Date.Year.ToString());
                    d = int.Parse(b.Date.Year.ToString());
                    Response.Redirect("WebFormA.aspx");

                }
            }

        }
        protected void Button3_Click1(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("acceil.aspx");
        }
    }
}