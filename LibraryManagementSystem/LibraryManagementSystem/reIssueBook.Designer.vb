﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reissuebook
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim AccNoLabel As System.Windows.Forms.Label
        Dim BorrowerIdLabel As System.Windows.Forms.Label
        Me.AccNoTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowerIdTextBox = New System.Windows.Forms.TextBox()
        Me.issueButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        AccNoLabel = New System.Windows.Forms.Label()
        BorrowerIdLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AccNoLabel
        '
        AccNoLabel.AutoSize = True
        AccNoLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AccNoLabel.Location = New System.Drawing.Point(149, 86)
        AccNoLabel.Name = "AccNoLabel"
        AccNoLabel.Size = New System.Drawing.Size(79, 22)
        AccNoLabel.TabIndex = 0
        AccNoLabel.Text = "Book Id:"
        '
        'BorrowerIdLabel
        '
        BorrowerIdLabel.AutoSize = True
        BorrowerIdLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BorrowerIdLabel.Location = New System.Drawing.Point(116, 149)
        BorrowerIdLabel.Name = "BorrowerIdLabel"
        BorrowerIdLabel.Size = New System.Drawing.Size(115, 22)
        BorrowerIdLabel.TabIndex = 2
        BorrowerIdLabel.Text = "Borrower Id:"
        '
        'AccNoTextBox
        '
        Me.AccNoTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccNoTextBox.Location = New System.Drawing.Point(280, 82)
        Me.AccNoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AccNoTextBox.Name = "AccNoTextBox"
        Me.AccNoTextBox.Size = New System.Drawing.Size(333, 30)
        Me.AccNoTextBox.TabIndex = 1
        '
        'BorrowerIdTextBox
        '
        Me.BorrowerIdTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowerIdTextBox.Location = New System.Drawing.Point(280, 145)
        Me.BorrowerIdTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BorrowerIdTextBox.Name = "BorrowerIdTextBox"
        Me.BorrowerIdTextBox.Size = New System.Drawing.Size(333, 30)
        Me.BorrowerIdTextBox.TabIndex = 3
        '
        'issueButton
        '
        Me.issueButton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.issueButton.FlatAppearance.BorderSize = 0
        Me.issueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.issueButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.issueButton.ForeColor = System.Drawing.Color.White
        Me.issueButton.Location = New System.Drawing.Point(805, 110)
        Me.issueButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.issueButton.Name = "issueButton"
        Me.issueButton.Size = New System.Drawing.Size(300, 52)
        Me.issueButton.TabIndex = 4
        Me.issueButton.Text = "Issue"
        Me.issueButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(63, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Reissue Book"
        '
        'reissuebook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.issueButton)
        Me.Controls.Add(AccNoLabel)
        Me.Controls.Add(Me.AccNoTextBox)
        Me.Controls.Add(BorrowerIdLabel)
        Me.Controls.Add(Me.BorrowerIdTextBox)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "reissuebook"
        Me.Size = New System.Drawing.Size(1356, 279)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AccNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BorrowerIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents issueButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
