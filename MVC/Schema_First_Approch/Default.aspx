<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Schema_First_Approch._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   

    <table style="width: 494px; border-color: #CCCC00">
    <tr>
        <td style="width: 87px">&nbsp;</td>
        <td>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="20px" ForeColor="#CC0066" Text="Entity Data Model used to Bind the data"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 87px">&nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="height: 20px; width: 87px">&nbsp;</td>
        <td style="height: 20px">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td style="width: 87px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>

   

</asp:Content>
