﻿Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient

Public Class Prof_UserControl
    Dim field As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter a valid ISBN")
            Return
        End If

        If ComboBox1.Text = "" Then
            MessageBox.Show("Please select a department")
            Return
        End If

        Dim newISBN As String = ""
        For Each c In TextBox1.Text
            If Not Char.IsNumber(c) And Not c = "-" Then
                MessageBox.Show("Please enter a valid ISBN")
            End If

            If Not c = "-" Then
                newISBN += c
            End If
        Next

        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Recommendations WHERE ISBN = '" & newISBN & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim ct As Integer = 0

        Dim selectString2 As String = "SELECT * FROM Books WHERE ISBN = '" & newISBN & "'"
        Dim cmd2 As OleDbCommand = New OleDbCommand(selectString2, cn)
        Dim reader2 As OleDbDataReader = cmd2.ExecuteReader()

        If Not reader2.HasRows Then
            MessageBox.Show("This book does not exist in the library")
            Return
        End If

        While reader.Read()
            'MessageBox.Show("Yo")
            If reader("Field") = ComboBox1.SelectedItem And reader("ProfName") = StudentLogin.UserName Then
                ct += 1
            End If
        End While
        cn.Close()
        'reader.Close()
        'MessageBox.Show(ct)
        If ct = 0 Then
            cn.Open()
            Dim cmdString As String = "insert into Recommendations (ISBN, Field, ProfName, RecDate) values('" & newISBN & "', '" & ComboBox1.SelectedItem & "', '" & StudentLogin.UserName & "', '" & DateTime.Now.ToString("dd-MM-yyyy") & "')"
            cmd = New OleDbCommand(cmdString, cn)
            If cmd.ExecuteNonQuery > 0 Then
                cmd.Dispose()
                MessageBox.Show("Inserted")
            End If
            reader.Close()
            cn.Close()
        Else
            MessageBox.Show("You Have already recommended this book for the selected field. Please try different ISBN or different Field")
        End If

        TextBox1.Clear()
        ComboBox1.SelectedIndex = -1
        StudentLogin.refreshRecommend()

    End Sub


    Private Sub Prof_UserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As OleDbConnection = New OleDbConnection(MainPage.connectionString)
        cn.Open()

        Dim selectString As String = "SELECT * FROM Users WHERE UserName = '" & StudentLogin.UserName & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
    

        Dim selectString2 As String = "SELECT * FROM Recommendations WHERE ProfName = '" & StudentLogin.UserName & "'"
        Dim cmd2 As OleDbCommand = New OleDbCommand(selectString2, cn)
        Dim reader2 As OleDbDataReader = cmd2.ExecuteReader()

        Dim boxWidth As Integer = (Panel1.Width / 2) - 10
        Dim boxHeight As Integer = 100
        Dim nextX As Integer = 0
        Dim nextY As Integer = 0
        Dim countX As Integer = 0
        Dim countY As Integer = 0

        While reader2.Read
            field = reader2("Field")
            Dim selectString3 As String = "SELECT * FROM Books WHERE ISBN = '" & reader2("ISBN") & "'"
            Dim cmd3 As OleDbCommand = New OleDbCommand(selectString3, cn)
            Dim reader3 As OleDbDataReader = cmd3.ExecuteReader()

            Dim profName As String = reader2("ProfName")

            Dim selectString4 As String = "SELECT * FROM Users WHERE UserName = '" & profName & "'"
            Dim cmd4 As OleDbCommand = New OleDbCommand(selectString4, cn)
            Dim reader4 As OleDbDataReader = cmd4.ExecuteReader()
            Dim profFullName As String = ""

            If reader4.Read Then
                profFullName = reader4("ProfileName")
            End If

            Dim recDate As String = reader2("RecDate")

            If reader3.Read Then

                Dim backPicBox As New PictureBox

                Dim Titlelabel As New LinkLabel
                Dim lblprofName As New Label
                Dim lblMessage1 As New Label
                Dim lblMessage2 As New Label
                Dim lblDate As New Label

                Titlelabel.Size = New Size(250, 20)
                Titlelabel.Tag = reader3("ISBN")
                Titlelabel.Text = reader3("Title")

                lblprofName.Size = New Size(250, 20)
                lblprofName.Text = field

                lblMessage1.Text = "You recommended the book "
                lblMessage1.AutoSize = True

                lblMessage2.Text = "to students of "
                lblMessage2.AutoSize = True

                lblDate.Size = New Size(400, 20)
                lblDate.Text = "on " & recDate

                Titlelabel.Location = New Point(nextX + 180, nextY + 10)   ' Set location
                lblprofName.Location = New Point(nextX + 95, nextY + 40)
                lblMessage1.Location = New Point(nextX + 10, nextY + 10)
                lblMessage2.Location = New Point(nextX + 10, nextY + 40)
                lblDate.Location = New Point(nextX + 10, nextY + 70)
                backPicBox.Location = New Point(nextX, nextY)

                backPicBox.Size = New Size(boxWidth - 20, boxHeight)
                backPicBox.SendToBack()

                If countX Mod 2 = 0 Then
                    If countY Mod 2 = 0 Then
                        backPicBox.BackColor = Color.Salmon
                        Titlelabel.BackColor = Color.Salmon
                        lblprofName.BackColor = Color.Salmon
                        lblMessage1.BackColor = Color.Salmon
                        lblDate.BackColor = Color.Salmon
                        lblMessage2.BackColor = Color.Salmon
                    Else
                        backPicBox.BackColor = Color.SandyBrown
                        Titlelabel.BackColor = Color.SandyBrown
                        lblprofName.BackColor = Color.SandyBrown
                        lblMessage1.BackColor = Color.SandyBrown
                        lblDate.BackColor = Color.SandyBrown
                        lblMessage2.BackColor = Color.SandyBrown
                    End If
                Else
                    If countY Mod 2 = 0 Then
                        backPicBox.BackColor = Color.DarkKhaki
                        Titlelabel.BackColor = Color.DarkKhaki
                        lblprofName.BackColor = Color.DarkKhaki
                        lblMessage1.BackColor = Color.DarkKhaki
                        lblDate.BackColor = Color.DarkKhaki
                        lblMessage2.BackColor = Color.DarkKhaki
                    Else
                        backPicBox.BackColor = Color.LightSteelBlue
                        Titlelabel.BackColor = Color.LightSteelBlue
                        lblprofName.BackColor = Color.LightSteelBlue
                        lblMessage1.BackColor = Color.LightSteelBlue
                        lblDate.BackColor = Color.LightSteelBlue
                        lblMessage2.BackColor = Color.LightSteelBlue
                    End If
                End If

                Titlelabel.Font = New Font("Times New Roman", 11, FontStyle.Regular)
                lblprofName.Font = New Font("Times New Roman", 11, FontStyle.Bold)
                lblMessage1.Font = New Font("Times New Roman", 11, FontStyle.Regular)
                lblMessage2.Font = New Font("Times New Roman", 11, FontStyle.Regular)
                lblDate.Font = New Font("Times New Roman", 11, FontStyle.Regular)

                Titlelabel.AutoEllipsis = True
                lblprofName.AutoEllipsis = True
                lblMessage1.AutoEllipsis = True
                lblMessage2.AutoEllipsis = True
                lblDate.AutoEllipsis = True

                Me.Panel1.Controls.Add(Titlelabel)
                Me.Panel1.Controls.Add(lblprofName)
                Me.Panel1.Controls.Add(lblMessage1)
                Me.Panel1.Controls.Add(lblMessage2)
                Me.Panel1.Controls.Add(lblDate)
                Me.Panel1.Controls.Add(backPicBox)

                AddHandler Titlelabel.Click, AddressOf Titlelabel_click

                nextX += boxWidth
                countY = 1
                If nextX > Panel1.Width / 2 Then
                    nextX = 0
                    nextY += boxHeight + 10
                    countX += 1
                    countY = 0
                End If

            End If

        End While

        cn.Close()
    End Sub

    Private Sub Titlelabel_click(ByVal sender As Object, ByVal e As EventArgs)
        Dim frm As New BookDetails
        frm.passISBN = sender.tag
        frm.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class