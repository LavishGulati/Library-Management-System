﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.buttonPanel = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnEditProfile = New System.Windows.Forms.Button()
        Me.btnItemsCheckedout = New System.Windows.Forms.Button()
        Me.btnMyProfile = New System.Windows.Forms.Button()
        Me.contentPanel = New System.Windows.Forms.Panel()
        Me.buttonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonPanel
        '
        Me.buttonPanel.BackColor = System.Drawing.Color.MidnightBlue
        Me.buttonPanel.Controls.Add(Me.btnLogout)
        Me.buttonPanel.Controls.Add(Me.btnEditProfile)
        Me.buttonPanel.Controls.Add(Me.btnItemsCheckedout)
        Me.buttonPanel.Controls.Add(Me.btnMyProfile)
        Me.buttonPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.buttonPanel.ForeColor = System.Drawing.Color.Black
        Me.buttonPanel.Location = New System.Drawing.Point(0, 0)
        Me.buttonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonPanel.Name = "buttonPanel"
        Me.buttonPanel.Size = New System.Drawing.Size(329, 838)
        Me.buttonPanel.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(0, 199)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(329, 55)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnEditProfile
        '
        Me.btnEditProfile.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnEditProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditProfile.FlatAppearance.BorderSize = 0
        Me.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditProfile.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditProfile.ForeColor = System.Drawing.Color.White
        Me.btnEditProfile.Location = New System.Drawing.Point(0, 146)
        Me.btnEditProfile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditProfile.Name = "btnEditProfile"
        Me.btnEditProfile.Size = New System.Drawing.Size(329, 55)
        Me.btnEditProfile.TabIndex = 2
        Me.btnEditProfile.Text = "Edit Profile"
        Me.btnEditProfile.UseVisualStyleBackColor = False
        '
        'btnItemsCheckedout
        '
        Me.btnItemsCheckedout.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnItemsCheckedout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnItemsCheckedout.FlatAppearance.BorderSize = 0
        Me.btnItemsCheckedout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItemsCheckedout.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemsCheckedout.ForeColor = System.Drawing.Color.White
        Me.btnItemsCheckedout.Location = New System.Drawing.Point(0, 94)
        Me.btnItemsCheckedout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnItemsCheckedout.Name = "btnItemsCheckedout"
        Me.btnItemsCheckedout.Size = New System.Drawing.Size(329, 55)
        Me.btnItemsCheckedout.TabIndex = 1
        Me.btnItemsCheckedout.Text = "Items Checked Out"
        Me.btnItemsCheckedout.UseVisualStyleBackColor = False
        '
        'btnMyProfile
        '
        Me.btnMyProfile.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnMyProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyProfile.FlatAppearance.BorderSize = 0
        Me.btnMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyProfile.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyProfile.ForeColor = System.Drawing.Color.White
        Me.btnMyProfile.Location = New System.Drawing.Point(0, 41)
        Me.btnMyProfile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMyProfile.Name = "btnMyProfile"
        Me.btnMyProfile.Size = New System.Drawing.Size(329, 55)
        Me.btnMyProfile.TabIndex = 0
        Me.btnMyProfile.Text = "My Profile"
        Me.btnMyProfile.UseVisualStyleBackColor = False
        '
        'contentPanel
        '
        Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.contentPanel.Location = New System.Drawing.Point(340, 0)
        Me.contentPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(1345, 838)
        Me.contentPanel.TabIndex = 1
        '
        'StudentLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1685, 838)
        Me.Controls.Add(Me.buttonPanel)
        Me.Controls.Add(Me.contentPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StudentLogin"
        Me.Text = "StudentLogin"
        Me.buttonPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents buttonPanel As System.Windows.Forms.Panel
    Friend WithEvents btnItemsCheckedout As System.Windows.Forms.Button
    Friend WithEvents btnMyProfile As System.Windows.Forms.Button
    Friend WithEvents contentPanel As System.Windows.Forms.Panel
    Friend WithEvents btnEditProfile As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
