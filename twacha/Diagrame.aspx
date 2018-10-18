<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Diagrame.aspx.cs" Inherits="twacha.Diagrame" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1
        {
            height: 73px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
            Font-Names="Californian FB" Font-Size="Medium" ForeColor="Black" 
            RepeatDirection="Horizontal" 
            
            
            style="top: 211px; left: 430px; position: absolute; height: 27px; width: 275px">
            <asp:ListItem>Jour</asp:ListItem>
            <asp:ListItem>Semaine</asp:ListItem>
            <asp:ListItem>Mois</asp:ListItem>
            <asp:ListItem>Année</asp:ListItem>
        </asp:RadioButtonList>
    
    </div>
    <asp:Label ID="Label1" runat="server" Font-Names="Californian FB" 
        Font-Size="XX-Large" 
        style="top: 62px; left: 302px; position: absolute; height: 45px; width: 655px; font-weight: 700; color: #FF0000" 
        Text="Diagramme Du Poids Par Intervalle De date"></asp:Label>
    <asp:Panel ID="Panel3" runat="server" BorderStyle="Outset" 
        Direction="LeftToRight" 
        style="top: 56px; left: 95px; position: absolute; height: 46px; width: 1116px">
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" 
        style="top: 294px; left: 33px; position: absolute; height: 107px; width: 1094px">
        <asp:Label ID="Label6" runat="server" Font-Names="Californian FB" 
            style="font-weight: 700; top: 18px; left: 544px; position: absolute; height: 18px; width: 32px" 
            Text="à"></asp:Label>
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
            style="top: 116px; left: 789px; position: absolute; height: 34px; width: 211px; text-align: center">Retour page d&#39;accueil</asp:LinkButton>
    </asp:Panel>

    <p style="height: 415px">
        <asp:Label ID="Label4" runat="server" ForeColor="Black" 
            style="top: 212px; left: 215px; position: absolute; height: 19px; width: 150px; font-weight: 700; right: 749px;" 
            Text="Choisir L'intervalle           :" Font-Names="Californian FB" 
            Font-Size="Medium"></asp:Label>
        <asp:Label ID="Label7" runat="server" Font-Names="Californian FB" 
            style="top: 370px; left: 337px; position: absolute; height: 20px; width: 36px; font-weight: 700" 
            Text="Par   :"></asp:Label>
        </p>
         <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

    <asp:Button ID="Button2" runat="server" BackColor="Silver" BorderColor="White" 
            Font-Names="Californian FB" Font-Size="Medium" ForeColor="Black" 
            onclick="Button1_Click" 
            style="top: 213px; position: absolute; height: 23px; width: 87px; bottom: 194px; left: 824px" 
            Text="Afficher" />
    <asp:Label ID="Label5" runat="server" Font-Names="Californian FB" 
        ForeColor="Black" 
        style="top: 307px; left: 193px; position: absolute; height: 19px; width: 171px; font-weight: 700; right: 778px;" 
        Text="Choisir L'intervalle De :"></asp:Label>
     <asp:TextBox ID="TextBox1" runat="server" 
            
            
            style="top: 307px; left: 417px; position: absolute; height: 22px; width: 128px" 
            BackColor="Silver" BorderColor="White" Font-Names="Californian FB" 
            Font-Size="Medium"></asp:TextBox>
    
    
        <asp:CalendarExtender ID="cext" runat="server" TargetControlID="TextBox1"></asp:CalendarExtender>

    <p>
        &nbsp;</p>
    <p>
          <asp:TextBox ID="TextBox2" runat="server" 
            
            
            style="top: 307px; left: 622px; position: absolute; height: 22px; width: 128px" 
            BackColor="Silver" BorderColor="White" Font-Names="Californian FB" 
            Font-Size="Medium"></asp:TextBox>
    
    
        <asp:CalendarExtender ID="text" runat="server" TargetControlID="TextBox2"></asp:CalendarExtender>
    </p>
    <asp:Button ID="Button3" runat="server" BackColor="Silver" BorderColor="White" 
            Font-Names="Californian FB" Font-Size="Medium" ForeColor="Black" 
            onclick="Button3_Click" 
            style="top: 305px; position: absolute; height: 23px; width: 87px; bottom: 263px; left: 819px" 
            Text="Afficher" />
    
        <asp:RadioButtonList ID="RadioButtonList2" runat="server" 
            Font-Names="Californian FB" Font-Size="Medium" ForeColor="Black" 
            RepeatDirection="Horizontal" 
            
            
        
        style="top: 368px; left: 437px; position: absolute; height: 27px; width: 203px">
            <asp:ListItem>Jour</asp:ListItem>
            <asp:ListItem>Mois</asp:ListItem>
            <asp:ListItem>Année</asp:ListItem>
        </asp:RadioButtonList>
    
    <p>
        &nbsp;</p>
    
    </form>
</body>
</html>
