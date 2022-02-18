Imports System.Data.OleDb
Public Class frmCheckInReport
    Dim data As String
    Private Sub frmCheckInReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
    End Sub
    Private Sub ShowData()
        con.Open()
        Dim Dt As New DataTable("tblTransaction")
        rs = New OleDbDataAdapter("Select * from tblTransaction, tblGuest, tblDiscount, tblRoom WHERE tblTransaction.GuestID = tblGuest.ID AND tblTransaction.DiscountID = tblDiscount.ID AND tblTransaction.RoomNum = tblRoom.RoomNumber AND tblTransaction.Remarks = 'Checkin' AND tblTransaction.Status = 'Active'", con)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dtchkout As New DataTable
        With dtchkout
            .Columns.Add("TransID")
            .Columns.Add("GuestLName")
            .Columns.Add("RoomNumber")
            .Columns.Add("RoomType")
            .Columns.Add("CheckInDate")
            .Columns.Add("CheckOutDate")
            .Columns.Add("NoOfChild")
            .Columns.Add("NoOfAdult")
            .Columns.Add("AdvancePayment")
            .Columns.Add("DiscountType")


        End With
        For Each dgr As DataGridViewRow In Me.DataGridView1.Rows
            dtchkout.Rows.Add(dgr.Cells(0).Value, dgr.Cells(13).Value, dgr.Cells(27).Value, dgr.Cells(28).Value, dgr.Cells(3).Value, dgr.Cells(4).Value, dgr.Cells(6).Value, dgr.Cells(7).Value, dgr.Cells(8).Value, dgr.Cells(23).Value)
        Next

        Dim reportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument

        reportDocument = New CrystalReport2
        reportDocument.SetDataSource(dtchkout)
        Dim log As New CheckoutReportForm()
        'reportDocument.SetParameterValue("ILAN", intRow.ToString())
        log.CrystalReportViewer1.ReportSource = reportDocument
        log.ShowDialog()
    End Sub
End Class