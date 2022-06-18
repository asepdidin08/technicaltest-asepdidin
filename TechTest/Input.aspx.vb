Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class Input
    Inherits System.Web.UI.Page
    Dim connect As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=technicalTestdb;User ID=sa; PWD=11111; Integrated security=true;MultipleActiveResultSets=True;")

    Public Sub DGVList()
        Dim sql As String
        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter
        Dim tbl As New DataTable

        sql = "Select codeBarang, namaBarang, jenisBarang, unitBarang, hargaBarang, stockBarang, approve1, approve2 from tbbarang"
        cmd = New SqlCommand(sql, connect)
        da = New SqlDataAdapter(cmd)
        da.Fill(tbl)
        GridView1.DataSource = tbl
        GridView1.DataBind()
    End Sub

    Public Sub clear()
        txcode.Text = ""
        txnama.Text = ""
        DropDownList1.Text = ""
        DropDownList2.Text = ""
        txharga.Text = ""
        txstock.Text = ""
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DGVList()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim cmd As SqlCommand
        If txcode.Text = "" Then
            MsgBox("Silahkan isi code barang!")
            txcode.Focus()
        ElseIf txnama.Text = "" Then
            MsgBox("Silahkan isi nama barang!")
            txnama.Focus()
        ElseIf txharga.Text = "" Then
            MsgBox("Silahkan isi harga barang!")
            txharga.Focus()
        ElseIf txstock.Text = "" Then
            MsgBox("Silahkan isi stock barang!")
            txstock.Focus()
        Else
            connect.Open()
            Dim codeBarang As String = txcode.Text
            Dim namaBarang As String = txnama.Text
            Dim jenisBarang As String = DropDownList1.Text
            Dim unitBarang As String = DropDownList2.Text
            Dim hargaBarang As Integer = txharga.Text
            Dim stockBarang As Integer = txstock.Text
            Dim approve1 As String = ""
            Dim approve2 As String = ""

            sql = "insert into tbbarang values('" & codeBarang & "','" & namaBarang & "','" & jenisBarang & "','" & unitBarang & "','" & hargaBarang & "','" & stockBarang & "','" & approve1 & "','" & approve2 & "')"
            cmd = New SqlCommand(sql, connect)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil ditambahkan")
            connect.Close()
            clear()
            DGVList()
        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim sql As String
        Dim cmd As SqlCommand
        If txcode.Text = "" Then
            MsgBox("Silahkan isi code barang!")
            txcode.Focus()
        ElseIf txnama.Text = "" Then
            MsgBox("Silahkan isi nama barang!")
            txnama.Focus()
        ElseIf txharga.Text = "" Then
            MsgBox("Silahkan isi harga barang!")
            txharga.Focus()
        ElseIf txstock.Text = "" Then
            MsgBox("Silahkan isi stock barang!")
            txstock.Focus()
        Else
            connect.Open()
            Dim codeBarang As String = txcode.Text
            Dim namaBarang As String = txnama.Text
            Dim jenisBarang As String = DropDownList1.Text
            Dim unitBarang As String = DropDownList2.Text
            Dim hargaBarang As Integer = txharga.Text
            Dim stockBarang As Integer = txstock.Text
            Dim approve1 As String = ""
            Dim approve2 As String = ""

            sql = "Update tbbarang set codeBarang='" & codeBarang & "', namaBarang= '" & namaBarang & "', jenisBarang='" & jenisBarang & "', unitBarang= '" & unitBarang & "', hargaBarang = '" & hargaBarang & "', stockBarang = '" & stockBarang & "' where codeBarang='" & codeBarang & "'"
            cmd = New SqlCommand(sql, connect)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil diupdate")
            connect.Close()
            clear()
            DGVList()
        End If
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Dim sql As String
        Dim cmd As SqlCommand
        If txcode.Text = "" Then
            MsgBox("Silahkan isi code barang!")
            txcode.Focus()
        Else
            connect.Open()
            Dim codeBarang As String = txcode.Text
            sql = "Delete tbbarang where codeBarang='" & codeBarang & "'"
            cmd = New SqlCommand(sql, connect)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Didelete")
            connect.Close()
            clear()
            DGVList()
        End If
    End Sub
End Class