<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Input.aspx.vb" Inherits="TechTest.Input" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style1
    {
        width: 85%;
    }
    .style2
    {
        width: 100%;
    }
    .style3
    {
        width: 106px;
    }
    .style4
    {
        width: 102px;
    }
        .style5
        {
            width: 99px;
        }
        .style6
        {
            width: 103px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <asp:Label ID="Label1" runat="server" Text="Form Transaksi"></asp:Label>
</p>

<table class="style2">
    <tr>
        <td class="style5">
            <asp:Button ID="Button1" runat="server" Text="Tambah" Width="100px" 
                BackColor="#3333CC" ForeColor="White" />
        </td>
        <td class="style6">
            <asp:Button ID="Button2" runat="server" Text="Edit" Width="100px" 
                BackColor="Lime" />
        </td>
        <td class="style6">
            <asp:Button ID="Button3" runat="server" Text="Delete" Width="101px" 
                BackColor="#CC0000" ForeColor="White" />
        </td>
        <td class="style4">
            &nbsp;</td>
        <td class="style3">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
<table class="style1">
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Code"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txcode" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txnama" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label4" runat="server" Text="Jenis"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Makanan</asp:ListItem>
                <asp:ListItem>Minuman</asp:ListItem>
                <asp:ListItem>Obat</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label5" runat="server" Text="Satuan"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>Pcs</asp:ListItem>
                <asp:ListItem>Kg</asp:ListItem>
                <asp:ListItem>Unit</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label6" runat="server" Text="Harga"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txharga" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label7" runat="server" Text="Stock"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txstock" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
        GridLines="None" Height="164px" Width="929px">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
<br />
<br />
</asp:Content>
