<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Approve1.aspx.vb" Inherits="TechTest.Approve1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 119px;
        }
        .style3
        {
            width: 302px;
        }
    .style4
    {
        width: 103px;
    }
    .style5
    {
        width: 108px;
    }
    .style6
    {
        width: 263px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p align="center">
        Contoh Approval dokumen yang pertama</p>
    <p align="center">
        Silahkan pilih Code Barang yang akan di approve pertama</p>
    <p align="center">
        &nbsp;</p>
    <p align="center">
        &nbsp;</p>
    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td class="style2">
                <asp:Label ID="Label1" runat="server" Text="Code"></asp:Label>
            </td>
            <td class="style3">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="23px" Width="102px">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br />

<table class="style1">
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style4">
            <asp:Button ID="Button1" runat="server" Text="Approve" Width="101px" 
                BackColor="#3333CC" ForeColor="White" />
        </td>
        <td class="style5">
            <asp:Button ID="Button2" runat="server" Text="Reject" Width="100px" 
                BackColor="Red" ForeColor="White" />
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
    <br />
    <p align="center" style="font-size: large">
        Approval ke-1</p>
</asp:Content>
