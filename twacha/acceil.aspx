<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="acceil.aspx.cs" Inherits="twacha.WebForm1" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body
        {
          
        }
    </style>
</head>
<body style="height: 56px">
    <form id="form1" runat="server">
    <div style="height: 54px; width: 1307px">
    
        <asp:TextBox ID="TextBox1" runat="server" 
            
            
            style="top: 236px; left: 626px; position: absolute; height: 22px; width: 128px" 
            BackColor="Silver" BorderColor="White" Font-Names="Californian FB" 
            Font-Size="Medium"></asp:TextBox>
    
    
        <asp:CalendarExtender ID="cext" runat="server" TargetControlID="TextBox1"></asp:CalendarExtender>
    
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    
        <asp:Image ID="Image1" runat="server" BackColor="Gray" 
            ForeColor="Silver" GenerateEmptyAlternateText="True" ImageUrl="~/mis (2).jpg" 
            
            
            
            style="text-align: center; top: 11px; left: 1087px; position: absolute; height: 31px; width: 228px; right: -156px" />
    
    
        <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" 
            DataSourceID="SqlDataSource1" DataTextField="Nom_poste" 
            DataValueField="Nom_poste" 
            
            
            style="top: 237px; left: 251px; position: absolute; height: 22px; width: 96px" 
            BackColor="Silver">
            <asp:ListItem>Tout</asp:ListItem>
        </asp:DropDownList>
        <asp:HoverMenuExtender ID="SqlDataSource1_HoverMenuExtender" runat="server" 
            TargetControlID="SqlDataSource1">
        </asp:HoverMenuExtender>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:basculeConnectionString %>" 
            SelectCommand="SELECT DISTINCT [Nom_poste] FROM [Poste]">
        </asp:SqlDataSource>
    
    
        <asp:Label ID="Label14" runat="server" Font-Names="Californian FB" 
            Font-Size="XX-Large" ForeColor="Red" 
            style="top: 116px; left: 347px; position: absolute; height: 64px; width: 578px; text-align: center; font-weight: 700" 
            Text="Tableau du poids par intervalle De date"></asp:Label>
    
    
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Font-Overline="False" Font-Size="Medium" 
            ForeColor="Black" 
            style="top: 234px; left: 144px; position: absolute; height: 22px; width: 59px; font-weight: 700;" 
            Text="Poste     :" Font-Names="Californian FB"></asp:Label>
        <asp:Label ID="Label4" runat="server" ForeColor="Black" 
            style="top: 237px; left: 429px; position: absolute; height: 19px; width: 145px; font-weight: 700;" 
            Text="Choisir L'intervalle  :" Font-Names="Californian FB" 
            Font-Size="Medium"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
            ForeColor="Black" 
            
            
            style="top: 228px; left: 824px; position: absolute; height: 23px; width: 196px" 
            Font-Names="Californian FB" Font-Size="Medium" 
            onselectedindexchanged="Page_Load" RepeatDirection="Horizontal">
            <asp:ListItem>Jour</asp:ListItem>
            <asp:ListItem>Mois</asp:ListItem>
            <asp:ListItem>Année</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="Button1" runat="server" BackColor="Silver" BorderColor="White" 
            Font-Names="Californian FB" Font-Size="Medium" ForeColor="Black" 
            onclick="Button1_Click" 
            style="top: 266px; position: absolute; height: 70px; width: 122px; bottom: 71px; left: 1107px" 
            Text="Afficher" />
    
    
    </div>
        <asp:DropDownList ID="DropDownList2" runat="server" BackColor="Silver" 
        Font-Names="Californian FB" Font-Size="Medium" 
        
        
        style="top: 314px; left: 345px; position: absolute; height: 22px; width: 96px; right: 701px">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
            <asp:ListItem>14</asp:ListItem>
            <asp:ListItem>16</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
    </asp:DropDownList>
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
        style="top: 350px; left: 1095px; position: absolute; height: 19px; width: 156px">Page Diagramme</asp:LinkButton>
    <asp:Panel ID="Panel1" runat="server" BorderStyle="Outset" 
        style="top: 116px; left: 62px; position: absolute; height: 43px; width: 1094px">
    </asp:Panel>
        <asp:Label ID="Label12" runat="server" ForeColor="Black" 
        style="top: 317px; left: 534px; position: absolute; height: 19px; width: 214px; font-weight: 700;" 
        Text="Total Pesée Pour Le Diamètre" Font-Names="Californian FB" 
        Font-Size="Medium"></asp:Label>
    <asp:Label ID="Label13" runat="server" 
        
        
        style="top: 314px; left: 794px; position: absolute; height: 25px; width: 102px; right: 246px;" 
        BorderColor="White" Font-Names="Californian FB" Font-Size="Medium" 
        ForeColor="Red">...</asp:Label>
    <asp:Label ID="Label8" runat="server" ForeColor="Red" 
        style="top: 380px; left: 510px; position: absolute; height: 15px; width: 48px; right: 584px;" 
        Text="..." Font-Names="Californian FB" Font-Size="Medium"></asp:Label>
    <asp:Label ID="Label11" runat="server" ForeColor="Black" 
        style="top: 317px; left: 137px; position: absolute; height: 19px; width: 150px; font-weight: 700;" 
        Text="Choisir Uu Diamétre :" Font-Names="Californian FB"></asp:Label>
        <asp:Label ID="Label9" runat="server" ForeColor="Black" 
        style="top: 378px; left: 688px; position: absolute; height: 22px; width: 115px; right: 339px; font-weight: 700;" 
        Text="Total Pesée :" Font-Names="Californian FB" Font-Size="Medium"></asp:Label>
    <asp:Label ID="Label10" runat="server" ForeColor="Red" 
        style="top: 377px; left: 841px; position: absolute; height: 19px; width: 35px" 
        Text="..." Font-Names="Californian FB" Font-Size="Medium"></asp:Label>
    <asp:Label ID="Label5" runat="server" ForeColor="Black" 
        style="top: 381px; left: 134px; position: absolute; height: 19px; width: 115px; right: 893px; font-weight: 700;" 
        Text="Heure Debut  :" Font-Names="Californian FB" Font-Size="Medium"></asp:Label>
    <asp:Label ID="Label7" runat="server" ForeColor="Black" 
        style="top: 379px; left: 390px; position: absolute; height: 19px; width: 84px; font-weight: 700;" 
        Text="Heure Fin :" Font-Names="Californian FB" Font-Size="Medium"></asp:Label>
    <asp:Label ID="Label6" runat="server" ForeColor="Red" 
        style="top: 381px; left: 271px; position: absolute; height: 19px; width: 34px; right: 837px" 
        Text="..." Font-Names="Californian FB" Font-Size="Medium"></asp:Label>
        <asp:GridView ID="GridView1" runat="server"
            BorderColor="White" BorderWidth="1px" 
        CellPadding="4" ForeColor="Black" 
        
        
        style="top: 428px; left: 163px; position: absolute; height: 130px; width: 879px;" 
        BackColor="#FFFFCC" CaptionAlign="Bottom" HorizontalAlign="Center" >
            <EmptyDataRowStyle BorderStyle="None" />
            <EmptyDataTemplate>
                Donnée introuvable ...!!
            </EmptyDataTemplate>
            <FooterStyle BackColor="Silver" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="true" ForeColor="White" 
                Font-Size="Small" BorderWidth="1px"/>
            <EditRowStyle Font-Size="Small" 
                BorderWidth="1px" BorderStyle="Double" HorizontalAlign="Center" 
                VerticalAlign="Top"/>

            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />

            <RowStyle Font-Size="Small" HorizontalAlign="Left" 
                BorderWidth="1px" />
            <AlternatingRowStyle Font-Size="Small"/>
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="true" ForeColor="White" 
                Font-Size="Small" BorderWidth="1px" />


            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />


        </asp:GridView>
    </form>
</body>
</html>
