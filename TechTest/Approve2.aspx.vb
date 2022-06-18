Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class Approve2
    Inherits System.Web.UI.Page
    Dim connect As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=technicalTestdb;User ID=sa; PWD=11111; Integrated security=true;MultipleActiveResultSets=True;")

    Public Sub Dropdown()
        Dim sql As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim tbl As New DataTable


        connect.Open()
        Dim approve2 As String = ""

        sql = "Select codeBarang from tbbarang where approve1<> '' and approve2 = '" & approve2 & "' "
        cmd = New SqlCommand(sql, connect)
        DropDownList1.Items.Clear()
        dr = cmd.ExecuteReader
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
        Dim approve2 As String = "Approved"

        sql = "Update tbbarang set approve2='" & Approve2 & "' where codeBarang='" & codeBarang & "'"
        cmd = New SqlCommand(sql, connect)
        cmd.ExecuteNonQuery()
        MsgBox("Data Approved")
        DropDownList1.Items.Clear()
        connect.Close()

        Dropdown()
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim sql As String
        Dim cmd As SqlCommand

        connect.Open()
        Dim codeBarang As String = DropDownList1.Text
        Dim approve2 As String = "Reject"

        sql = "Update tbbarang set approve2='" & approve2 & "' where codeBarang='" & codeBarang & "'"
        cmd = New SqlCommand(sql, connect)
        cmd.ExecuteNonQuery()
        MsgBox("Data Reject")
        DropDownList1.Items.Clear()
        connect.Close()

        Dropdown()
    End Sub
End Class