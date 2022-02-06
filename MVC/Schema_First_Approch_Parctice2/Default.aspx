<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Schema_First_Approch_Parctice2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <table style="width: 659px; height: 278px">
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Entity Data Connection "></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="height: 171px">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </td>
        <td style="height: 171px"></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>

    
</asp:Content>
