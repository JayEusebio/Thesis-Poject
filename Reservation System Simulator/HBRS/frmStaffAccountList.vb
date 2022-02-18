Imports System.Data.OleDb
Public Class frmStaffAccountList
    Dim data As String

    Private Sub frmStaffAccountList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
    End Sub
    Private Sub ShowData()
        con.Open()
        Dim Dt As New DataTable("tblstaffuser")
        rs = New OleDbDataAdapter("Select * from tblstaffuser", con)
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