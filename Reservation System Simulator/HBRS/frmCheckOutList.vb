Imports System.Data.OleDb
Public Class frmCheckOutList
    Dim command As String
    Dim data As String

    Private Sub frmCheckOutList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ShowData()
        'Button1.Enabled = True



    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ShowData()
        con.Open()
        Dim Dt As New DataTable("tblTransactionReportQuery")
        rs = New OleDbDataAdapter("Select * from tblTransactionReportQuery", con)
        data = rs.Fill(Dt)

        If data > 0 Then
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = Dt
            DataGridView1.Columns(2).DefaultCellStyle.Format = "c"
            DataGridView1.DefaultCellStyle.ForeColor = Color.Black
            DataGridView1.ClearSelection()
        Else
            DataGridView1.DataSource = Dt
        End If
        rs.Dispose()

        con.Close()
    End Sub


End Class