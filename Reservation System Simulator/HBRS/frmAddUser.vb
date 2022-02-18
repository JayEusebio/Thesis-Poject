Imports System.Data.OleDb
Public Class frmAddUser
    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If RadioButtonAdmin.Checked Then



            If TextBoxusername.Text.Trim() = "" Or TextBoxpassword.Text.Trim() = "" Then

                MessageBox.Show("One Or More Fields Are Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            ElseIf Not String.Equals(TextBoxpassword.Text, TextBoxverifypassword.Text) Then

                MessageBox.Show("Wrong Confirmation Password", "password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf TextBoxusername.Text = "username" Then

                MessageBox.Show("This Username Already Exists, Choose Another One", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else

                ' add the new user
                con.Open()

                Dim add_account As New OleDbCommand("INSERT INTO tblUser([username],[password]) values ('" & TextBoxusername.Text & "','" & TextBoxpassword.Text & "')", con)

                add_account.ExecuteNonQuery()
                add_account.Dispose()
                con.Close()
                MsgBox("User Admin Added!", vbInformation, "Note")

                TextBoxusername.Text = ""
                TextBoxpassword.Text = ""
                TextBoxverifypassword.Text = ""
                RadioButtonUser.Checked = True
            End If
        End If




        If RadioButtonUser.Checked Then



            If TextBoxusername.Text.Trim() = "" Or TextBoxpassword.Text.Trim() = "" Then

                MessageBox.Show("One Or More Fields Are Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            ElseIf Not String.Equals(TextBoxpassword.Text, TextBoxverifypassword.Text) Then

                MessageBox.Show("Wrong Confirmation Password", "password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf TextBoxusername.Text = "Username" Then

                MessageBox.Show("This Username Already Exists, Choose Another One", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else

                ' add the new user
                con.Open()

                Dim add_account As New OleDbCommand("INSERT INTO tblstaffuser([Username],[Password]) values ('" & TextBoxusername.Text & "','" & TextBoxpassword.Text & "')", con)

                add_account.ExecuteNonQuery()
                add_account.Dispose()
                con.Close()
                MsgBox("User staff Added!", vbInformation, "Note")

                TextBoxusername.Text = ""
                TextBoxpassword.Text = ""
                TextBoxverifypassword.Text = ""
                RadioButtonUser.Checked = True
            End If
        End If

    End Sub
End Class