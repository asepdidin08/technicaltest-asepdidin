Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class Approve1
    Inherits System.Web.UI.Page
    Dim connect As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=technicalTestdb;User ID=sa; PWD=11111; Integrated security=true;MultipleActiveResultSets=True;")

    Public Sub Dropdown()
        Dim sql As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim tbl As New DataTable

        connect.Open()
        Dim approve1 As String = ""
        sql = "Select codeBarang from tbbarang where approve1 = '" & approve1 & "' "
        cmd = New SqlCommand(sql, connect)
        dr = cmd.ExecuteReader
        DropDownList1.Items.Clear()
        If dr.HasRows Then
            Do While dr.Read
                DropDownList1.Items.Add(dr("codeBarang"))
            Loop
        End If
        connect.Close()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dropdown()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim cmd As SqlCommand

        connect.Open()
        Dim codeBarang As String = DropDownList1.Text
        Dim approve1 As String = "Approved"

        sql = "Update tbbarang set approve1='" & approve1 & "' where codeBarang='" & codeBarang & "'"
        cmd = New SqlCommand(sql, connect)
        cmd.ExecuteNonQuery()
        MsgBox("Data DiApprove")
        DropDownList1.Items.Clear()
        connect.Close()

        Dropdown()
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim sql As String
        Dim cmd As SqlCommand

        connect.Open()
        Dim codeBarang As String = DropDownList1.Text
        Dim approve1 As String = "Reject"

        sql = "Update tbbarang set approve1='" & approve1 & "' where codeBarang='" & codeBarang & "'"
        cmd = New SqlCommand(sql, connect)
        cmd.ExecuteNonQuery()
        MsgBox("Data Reject")
        DropDownList1.Items.Clear()
        connect.Close()

        Dropdown()
    End Sub
End Class