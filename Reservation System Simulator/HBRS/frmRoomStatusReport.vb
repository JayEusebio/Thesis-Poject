Imports System.Data.OleDb
Public Class frmRoomStatusReport
    Dim data As String

    Private Sub frmRoomStatusReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
    End Sub
    Private Sub ShowData()
        con.Open()
        Dim Dt As New DataTable("tblRoom")
        rs = New OleDbDataAdapter("Select * from tblRoom", con)
        data = rs.Fill(Dt)

        If Data > 0 Then
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dtchkout As New DataTable
        With dtchkout
            .Columns.Add("RoomNumber")
            .Columns.Add("RoomType")
            .Columns.Add("RoomRate")
            .Columns.Add("NoOfOccupancy")
            .Columns.Add("Status")



        End With
        For Each dgr As DataGridViewRow In Me.DataGridView1.Rows
            dtchkout.Rows.Add(dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value, dgr.Cells(4).Value, dgr.Cells(5).Value)
        Next

        Dim reportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument

        reportDocument = New CrystalReport6
        reportDocument.SetDataSource(dtchkout)
        Dim log As New CheckoutReportForm()
        'reportDocument.SetParameterValue("ILAN", intRow.ToString())
        log.CrystalReportViewer1.ReportSource = reportDocument
        log.ShowDialog()
    End Sub
End Class