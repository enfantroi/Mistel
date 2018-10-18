using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace twacha
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       
        Double b = 0;
        Double r = 0;
        SqlConnection con = new SqlConnection("Data Source=.\\OUSSAMA;Integrated Security=SSPI;Initial catalog=bascule2");
        string Rg;
        string Zg;
        DataTable tb = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList2.Text == "")
            {
                Label13.Text = "";
            }
            
            Label6.Visible = false;
            Label7.Visible = false;
            Label8.Visible = false;
            Label9.Visible = false;
            Label10.Visible = false;
            Label5.Visible = false;
     
            if (TextBox1.Text == "")
            {
                string strScript = "<script language='JavaScript'>alert('Veuillez sélectionner la date')</script>";
                Page.ClientScript.RegisterStartupScript(GetType(), "PopUp", strScript);
            }
            else if (RadioButtonList1.Text == "")
            {
                string strScript = "<script language='JavaScript'>alert('Sélectionner Intervalle')</script>";
                Page.ClientScript.RegisterStartupScript(GetType(), "PopUp", strScript);
            }
            else
            {
                DateTime d = DateTime.Parse(TextBox1.Text, new CultureInfo("en-US", false));

                if (DropDownList1.Text != "Tout")
                {

                    if (RadioButtonList1.Text == "Mois")
                    {

                       
                        Label9.Visible = true;
                        Label10.Visible = true;
                      
                      

                        Rg = ("select Nfardeau,La_Date,Heur,Poids_Pesé,billettes_lamineé,Poids_Coefficeint,Cumul_Poids_Pesée,Diamètre from pesée where id_Poste in( select id_Poste from Poste where Nom_poste='" + DropDownList1.Text + "') and MONTH(La_Date) =" + d.Date.Month.ToString() + " and YEAR(La_Date)=" + d.Date.Year.ToString() + "");
                        if (DropDownList2.Text != "")
                        {
                            Zg = ("select SUM(Poids_Pesé) from pesée where id_Poste in( select id_Poste from Poste where Nom_poste='" + DropDownList1.Text + "') and MONTH(La_Date) =" + d.Date.Month.ToString() + " and YEAR(La_Date)=" + d.Date.Year.ToString() + " and Diamètre=" + DropDownList2.Text + "");
                        }
                    }
                    else if (RadioButtonList1.Text == "Année")
                    {

                       
                        Label9.Visible = true;
                        Label10.Visible = true;

                        Rg = ("select Nfardeau,La_Date,Heur,Poids_Pesé,billettes_lamineé,Poids_Coefficeint,Cumul_Poids_Pesée,Diamètre from pesée where id_Poste in( select id_Poste from Poste where Nom_poste='" + DropDownList1.Text + "')  and YEAR(La_Date)=" + d.Date.Year.ToString() + "");
                        if (DropDownList2.Text != "")
                        {
                            Zg = ("select SUM(Poids_Pesé) from pesée where id_Poste in( select id_Poste from Poste where Nom_poste='" + DropDownList1.Text + "')  and YEAR(La_Date)=" + d.Date.Year.ToString() + "and Diamètre=" + DropDownList2.Text + "");
                        }

                    }
                    else
                    {
                        Label5.Visible = true;
                        Label6.Visible = true;
                        Label7.Visible = true;
                        Label8.Visible = true;
                        Label9.Visible = true;
                        Label10.Visible = true;
                        Rg = ("select Nfardeau,La_Date,Heur,Poids_Pesé,billettes_lamineé,Poids_Coefficeint,Cumul_Poids_Pesée,Diamètre from pesée where id_Poste in( select id_Poste from Poste where Nom_poste='" + DropDownList1.Text + "') and La_Date= '" + d.ToShortDateString() + "' ");
                        if (DropDownList2.Text != "")
                        {
                            Zg = ("select SUM(Poids_Pesé) from pesée where id_Poste in( select id_Poste from Poste where Nom_poste='" + DropDownList1.Text + "') and La_Date= '" + d.ToShortDateString() + "'and Diamètre=" + DropDownList2.Text + "");
                        }
                    }
                    SqlCommand cmd2 = new SqlCommand(Rg, con);
                    con.Open();
                    SqlDataReader rd2 = cmd2.ExecuteReader();
                    if (!rd2.HasRows)
                    {
                        Label5.Visible = false;
                        Label6.Visible = false;
                        Label7.Visible = false;
                        Label8.Visible = false;
                        Label9.Visible = false;
                        Label10.Visible = false;
                    }
                    tb.Columns.Add("N° Fardeau");
                    tb.Columns.Add("La Date");
                    tb.Columns.Add("L'heur");
                    tb.Columns.Add("Poids de Pesée");
                    tb.Columns.Add("billettes lamineé");
                    tb.Columns.Add("Poids Coefficeint");
                    tb.Columns.Add("Cumul Poids Pesée");
                    tb.Columns.Add("Diamètre");
                    while (rd2.Read())
                    {
                        DataRow a = tb.NewRow();
                        a["N° Fardeau"] = rd2["Nfardeau"];
                        a["La Date"] = String.Format("{0:d}", rd2["La_Date"]);
                        a["L'heur"] = String.Format("{0:T}", rd2["Heur"]);
                        a["Poids de Pesée"] = rd2["Poids_Pesé"];
                        a["billettes lamineé"] = rd2["billettes_lamineé"];
                        a["Poids Coefficeint"] = rd2["Poids_Coefficeint"];
                        a["Cumul Poids Pesée"] = rd2["Cumul_Poids_Pesée"];
                        a["Diamètre"] = rd2["Diamètre"];
                        tb.Rows.Add(a);
                     
                    }
                    con.Close();
                    
                    GridView1.DataSource = tb;
                    GridView1.DataBind();
                    for (int i = 0; i < GridView1.Rows.Count; i++)
                    {
                        
                            int a = GridView1.Rows.Count - 1;
                            DateTime m = DateTime.Parse(GridView1.Rows[0].Cells[2].Text);
                            Label6.Text = m.ToLongTimeString();
                            DateTime c = DateTime.Parse(GridView1.Rows[a].Cells[2].Text);
                            Label8.Text = c.ToLongTimeString();
                            b = b + double.Parse(GridView1.Rows[i].Cells[3].Text);
                            Label10.Text = b.ToString();
                       
                    }
                    if (DropDownList2.Text != "")
                    {
                        con.Open();

                        SqlCommand cmd5 = new SqlCommand(Zg, con);
                        try
                        {
                            int num = (int)cmd5.ExecuteScalar();

                            Label13.Text = num.ToString();

                            con.Close();
                        }
                        catch (Exception)
                        {
                            Label13.Text = "introuvable";
                        }
                        con.Close();
                    }
                }
                else
                {

                
                    if (RadioButtonList1.Text == "Mois")
                    {
                        //if (Label5.Visible == false)
                        //{
                        //    Label5.Visible = true;
                        //    Label6.Visible = true;
                        //    Label7.Visible = true;
                        //    Label8.Visible = true;
                        //}
                        Label9.Visible = true;
                        Label10.Visible = true;

                        Rg = ("select Nom_poste,Nfardeau,La_Date,Heur,Poids_Pesé,billettes_lamineé,Poids_Coefficeint,Cumul_Poids_Pesée,Diamètre from pesée,Poste where pesée.id_Poste=Poste.id_Poste and MONTH(La_Date) =" + d.Date.Month.ToString() + " and YEAR(La_Date)=" + d.Date.Year.ToString() + "");
                        if (DropDownList2.Text != "")
                        {
                            Zg = ("select SUM(Poids_Pesé) from pesée where MONTH(La_Date) =" + d.Date.Month.ToString() + " and YEAR(La_Date)=" + d.Date.Year.ToString() + " and Diamètre=" + DropDownList2.Text + "");
                        }
                    }
                    else if (RadioButtonList1.Text == "Année")
                    {
                        //if (Label5.Visible == false)
                        //{
                        //    Label5.Visible = true;
                        //    Label6.Visible = true;
                        //    Label7.Visible = true;
                        //    Label8.Visible = true;
                        //}
                        Label9.Visible = true;
                        Label10.Visible = true;
                        Rg = ("select Nom_poste,Nfardeau,La_Date,Heur,Poids_Pesé,billettes_lamineé,Poids_Coefficeint,Cumul_Poids_Pesée,Diamètre from pesée,Poste where pesée.id_Poste=Poste.id_Poste and YEAR(La_Date)=" + d.Date.Year.ToString() + "");
                        if (DropDownList2.Text != "")
                        {
                            Zg = ("select SUM(Poids_Pesé) from pesée  where  YEAR(La_Date)=" + d.Date.Year.ToString() + "and Diamètre=" + DropDownList2.Text + "");
                        }
                    }
                    else
                    {
                        Label5.Visible = true;
                        Label6.Visible = true;
                        Label7.Visible = true;
                        Label8.Visible = true;
                        Label9.Visible = true;
                        Label10.Visible = true;
                        Rg = ("select Nom_poste,Nfardeau,La_Date,Heur,Poids_Pesé,billettes_lamineé,Poids_Coefficeint,Cumul_Poids_Pesée,Diamètre from pesée,Poste where pesée.id_Poste=Poste.id_Poste and La_Date= '" + d.ToShortDateString() + "' ");
                        if (DropDownList2.Text != "")
                        {
                            Zg = ("select SUM(Poids_Pesé) from pesée where  Diamètre=" + DropDownList2.Text + " and La_Date='" + d.ToShortDateString()+ "' ");
                        }
                    }

                    SqlCommand cmd3 = new SqlCommand(Rg, con);
                    con.Open();
                    SqlDataReader rd3 = cmd3.ExecuteReader();
                    if (!rd3.HasRows)
                    {
                        Label5.Visible = false;
                        Label6.Visible = false;
                        Label7.Visible = false;
                        Label8.Visible = false;
                        Label9.Visible = false;
                        Label10.Visible = false;
                    }
                    tb.Columns.Add("Nom poste");
                    tb.Columns.Add("N° Fardeau");
                    tb.Columns.Add("La Date");
                    tb.Columns.Add("L'heur");
                    tb.Columns.Add("Poids de Pesée");
                    tb.Columns.Add("billettes lamineé");
                    tb.Columns.Add("Poids Coefficeint");
                    tb.Columns.Add("Cumul Poids Pesée");
                    tb.Columns.Add("Diamètre");
                    while (rd3.Read())
                    {
                        DataRow a1 = tb.NewRow();
                        a1["Nom poste"] = rd3["Nom_poste"];
                        a1["N° Fardeau"] = rd3["Nfardeau"];
                        a1["La Date"] = String.Format("{0:d}", rd3["La_Date"]);
                        a1["L'heur"] = String.Format("{0:T}",rd3["Heur"]);
                        a1["Poids de Pesée"] = rd3["Poids_Pesé"];
                        a1["billettes lamineé"] = rd3["billettes_lamineé"];
                        a1["Poids Coefficeint"] = rd3["Poids_Coefficeint"];
                        a1["Cumul Poids Pesée"] = rd3["Cumul_Poids_Pesée"];
                        a1["Diamètre"] = rd3["Diamètre"];
                        tb.Rows.Add(a1);
                    }
                    con.Close();
                    
               
                    GridView1.DataSource = tb;
                    GridView1.DataBind();
                    for (int i = 0; i < GridView1.Rows.Count; i++)
                    {

                        int a = GridView1.Rows.Count - 1;
                        DateTime m = DateTime.Parse(GridView1.Rows[0].Cells[3].Text);
                        Label6.Text = m.ToLongTimeString();
                        DateTime c = DateTime.Parse(GridView1.Rows[a].Cells[3].Text);
                        Label8.Text = c.ToLongTimeString();
                        r = r + double.Parse(GridView1.Rows[i].Cells[4].Text);
                        Label10.Text = r.ToString();
                    }
                    if (DropDownList2.Text != "")
                    {
                        con.Open();
                        try
                        {
                            SqlCommand cmd4 = new SqlCommand(Zg, con);
                            int num = (int)cmd4.ExecuteScalar();
                            Label13.Text = num.ToString();

                            con.Close();
                        }
                        catch (Exception)
                        {
                            Label13.Text = "N'existe Pas ce Diametre";
                        }
                    }
                }
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Diagrame.aspx");
        }
    }
}