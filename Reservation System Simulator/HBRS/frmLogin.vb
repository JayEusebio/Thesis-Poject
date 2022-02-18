Imports System.Data.OleDb
Public Class frmLogin
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Please Fill all the TextBoxes!!")


        ElseIf RadioButtonAdmin.Checked Then

            con.Open()
            Dim sql = "SELECT * FROM tblUser WHERE username = '" & UsernameTextBox.Text & "' AND password = '" & PasswordTextBox.Text & "'"

            Dim cmd = New OleDbCommand(sql, con)
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            Try
                If dr.Read = False Then
                    MsgBox("Login Failed!", vbCritical, "Note")
                Else
                    MsgBox("Login Successful!", vbInformation, "Note")
                    frmMain.status.Items(0).Text = "Login as : " & Trim(UsernameTextBox.Text)
                    Dim datenow As Date = Now
                    frmMain.status.Items(2).Text = "Date and Time : " & datenow.ToString("MMMM dd, yyyy") & " " & TimeOfDay
                    con.Close()
                    Me.Hide()
                    frmMain.ShowDialog()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            con.Close()

        ElseIf RadioButtonUser.Checked Then

            con.Open()
            Dim sql = "SELECT * FROM tblstaffuser WHERE username = '" & UsernameTextBox.Text & "' AND password = '" & PasswordTextBox.Text & "'"

            Dim cmd = New OleDbCommand(sql, con)
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            Try
                If dr.Read = False Then
                    MsgBox("Login Failed!", vbCritical, "Note")
                Else
                    MsgBox("Login Successful!", vbInformation, "Note")
                    frmStaff.status.Items(0).Text = "Login as : " & Trim(UsernameTextBox.Text)
                    Dim datenow As Date = Now
                    frmStaff.status.Items(2).Text = "Date and Time : " & datenow.ToString("MMMM dd, yyyy") & " " & TimeOfDay
                    con.Close()
                    Me.Hide()
                    frmStaff.ShowDialog()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            con.Close()
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        End
    End Sub


End Class
