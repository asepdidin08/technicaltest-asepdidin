<%@ Page Title="Home Page" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="Default.aspx.vb" Inherits="TechTest._Default" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 101px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Technical Test .net Developer</h2>
    <table class="style1">
        <tr>
            <td class="style2">
                <asp:Button ID="Button1" runat="server" Text="Form" Width="100px" 
                    BackColor="#3333CC" ForeColor="White" />
            </td>
            <td class="style2">
                <asp:Button ID="Button2" runat="server" Text="Approve 1" Width="101px" 
                    BackColor="#3333CC" ForeColor="White" />
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" Text="Approve 2" Width="100px" 
                    BackColor="#3333CC" ForeColor="White" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <p>
        <asp:Chart ID="Chart1" runat="server" Width="930px" Palette="Excel">
            <series>
                <asp:Series Name="Series1" ChartType="Line" YValuesPerPoint="4">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
    </p>
    </asp:Content>
