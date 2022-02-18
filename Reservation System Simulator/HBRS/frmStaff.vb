Public Class frmStaff
    Dim r As New Random()

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim exit_app As String = MsgBox("Exit application?", vbQuestion + vbYesNo, "Exit")
        If exit_app = vbNo Then
            e.Cancel = True
        Else
            End
        End If
    End Sub
    Private Sub frmStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NewCheckIN_Click(sender As Object, e As EventArgs) Handles NewCheckIN.Click
        frmCheckin.ShowDialog()
    End Sub

    Private Sub NewReservation_Click(sender As Object, e As EventArgs) Handles NewReservation.Click
        frmReserve.ShowDialog()
    End Sub

    Private Sub ToolbarExit_Click(sender As Object, e As EventArgs) Handles ToolbarExit.Click
        Dim out_app As String = MsgBox("Logout from application?", vbQuestion + vbYesNo, "Logout")
        If out_app = vbYes Then
            con.Close()
            Me.Hide()
            frmLogin.Show()
        End If
    End Sub

    Private Sub FileLogOut_Click(sender As Object, e As EventArgs) Handles FileLogOut.Click
        Dim out_app As String = MsgBox("Logout from application?", vbQuestion + vbYesNo, "Logout")
        If out_app = vbYes Then
            Me.Hide()
            frmLogin.Show()
        End If
    End Sub

    Private Sub FileExit_Click(sender As Object, e As EventArgs) Handles FileExit.Click
        Me.Close()
    End Sub

    Private Sub CheckInListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckInListToolStripMenuItem.Click
        frmCheckinListMonitor.ShowDialog()
    End Sub

    Private Sub ResevedListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResevedListToolStripMenuItem.Click
        frmReserveListMonitor.ShowDialog()
    End Sub

    Private Sub CheckOutListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckOutListToolStripMenuItem.Click
        frmCheckOutList.ShowDialog()
    End Sub

    Private Sub RoomListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomListToolStripMenuItem.Click
        frmRoomListMonitor.ShowDialog()
    End Sub

    Private Sub toolbarCheckIn_Click(sender As Object, e As EventArgs) Handles toolbarCheckIn.Click
        frmCheckin.ShowDialog()
    End Sub

    Private Sub toolbarCheckOut_Click(sender As Object, e As EventArgs) Handles toolbarCheckOut.Click
        frmCheckout.ShowDialog()
    End Sub

    Private Sub toolbarReserve_Click(sender As Object, e As EventArgs) Handles toolbarReserve.Click
        frmReserve.ShowDialog()
    End Sub

    Private Sub ToolbarAddGuest_Click(sender As Object, e As EventArgs) Handles ToolbarAddGuest.Click
        frmGuest.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim datenow As Date = Now
        status.Items(2).Text = "Date and Time : " & datenow.ToString("MMMM dd, yyyy") & " " & TimeOfDay
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim i As Integer = +1

        PictureBox1.Image = My.Resources.ResourceManager.GetObject("Image" & r.Next(i, 7))
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Timer2.Start()
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Timer2.Start()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Timer2.Stop()
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Timer2.Stop()
    End Sub
End Class