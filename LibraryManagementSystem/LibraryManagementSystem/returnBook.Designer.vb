﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class returnBook
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
        Me.issueButton = New System.Windows.Forms.Button()
        Me.AccNoTextBox = New System.Windows.Forms.TextBox()
        AccNoLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AccNoLabel
        '
        AccNoLabel.AutoSize = True
        AccNoLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AccNoLabel.Location = New System.Drawing.Point(114, 47)
        AccNoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        AccNoLabel.Name = "AccNoLabel"
        AccNoLabel.Size = New System.Drawing.Size(63, 19)
        AccNoLabel.TabIndex = 7
        AccNoLabel.Text = "Book Id:"
        '
        'issueButton
        '
        Me.issueButton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.issueButton.FlatAppearance.BorderSize = 0
        Me.issueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.issueButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.issueButton.ForeColor = System.Drawing.Color.White
        Me.issueButton.Location = New System.Drawing.Point(593, 35)
        Me.issueButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.issueButton.Name = "issueButton"
        Me.issueButton.Size = New System.Drawing.Size(225, 42)
        Me.issueButton.TabIndex = 11
        Me.issueButton.Text = "Return"
        Me.issueButton.UseVisualStyleBackColor = False
        '
        'AccNoTextBox
        '
        Me.AccNoTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccNoTextBox.Location = New System.Drawing.Point(247, 44)
        Me.AccNoTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AccNoTextBox.Name = "AccNoTextBox"
        Me.AccNoTextBox.Size = New System.Drawing.Size(251, 26)
        Me.AccNoTextBox.TabIndex = 8
        '
        'returnBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.issueButton)
        Me.Controls.Add(AccNoLabel)
        Me.Controls.Add(Me.AccNoTextBox)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "returnBook"
        Me.Size = New System.Drawing.Size(1017, 227)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents issueButton As System.Windows.Forms.Button
    Friend WithEvents AccNoTextBox As System.Windows.Forms.TextBox

End Class
