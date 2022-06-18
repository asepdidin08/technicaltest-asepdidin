Imports System.Data
Imports System.Data.SqlClient

Public Class _Default
    Inherits System.Web.UI.Page
    Dim connect As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=technicalTestdb;User ID=sa; PWD=11111; Integrated security=true;")

    Public Sub Chart()
        Dim sql As String
        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter
        Dim tbl As New DataTable

        sql = "Select codeBarang, namaBarang, jenisBarang, unitBarang, hargaBarang, stockBarang, approve1, approve2 from tbbarang"
        cmd = New SqlCommand(sql, connect)
        da = New SqlDataAdapter(cmd)
        da.Fill(tbl)
        Chart1.DataSource = tbl
        Chart1.Series("Series1").XValueMember = "codeBarang"
        Chart1.Series("Series1").YValueMembers = "stockBarang"
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Chart()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Response.Redirect("Input.aspx")
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Response.Redirect("Approve1.aspx")
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Response.Redirect("Approve2.aspx")
    End Sub
End Class