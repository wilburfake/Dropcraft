﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits DevComponents.DotNetBar.Metro.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.UploadButton = New DevComponents.DotNetBar.ButtonX()
        Me.DownloadButton = New DevComponents.DotNetBar.ButtonX()
        Me.OptionsOpenButton = New DevComponents.DotNetBar.ButtonX()
        Me.HelpButton = New DevComponents.DotNetBar.ButtonX()
        Me.backupName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.DownloadName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LoginButton = New DevComponents.DotNetBar.ButtonX()
        Me.Test2 = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'UploadButton
        '
        Me.UploadButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.UploadButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.UploadButton.Location = New System.Drawing.Point(12, 43)
        Me.UploadButton.Name = "UploadButton"
        Me.UploadButton.Size = New System.Drawing.Size(75, 23)
        Me.UploadButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.UploadButton.TabIndex = 7
        Me.UploadButton.Text = "Upload"
        '
        'DownloadButton
        '
        Me.DownloadButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.DownloadButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.DownloadButton.Location = New System.Drawing.Point(195, 43)
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(75, 23)
        Me.DownloadButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DownloadButton.TabIndex = 8
        Me.DownloadButton.Text = "Download"
        '
        'OptionsOpenButton
        '
        Me.OptionsOpenButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.OptionsOpenButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.OptionsOpenButton.Location = New System.Drawing.Point(12, 98)
        Me.OptionsOpenButton.Name = "OptionsOpenButton"
        Me.OptionsOpenButton.Size = New System.Drawing.Size(123, 23)
        Me.OptionsOpenButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.OptionsOpenButton.TabIndex = 9
        Me.OptionsOpenButton.Text = "Options"
        '
        'HelpButton
        '
        Me.HelpButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.HelpButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.HelpButton.Location = New System.Drawing.Point(141, 98)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(129, 23)
        Me.HelpButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.HelpButton.TabIndex = 10
        Me.HelpButton.Text = "Help"
        '
        'backupName
        '
        Me.backupName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.backupName.Border.Class = "TextBoxBorder"
        Me.backupName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.backupName.ForeColor = System.Drawing.Color.Black
        Me.backupName.Location = New System.Drawing.Point(12, 72)
        Me.backupName.Name = "backupName"
        Me.backupName.Size = New System.Drawing.Size(123, 20)
        Me.backupName.TabIndex = 11
        Me.backupName.WatermarkText = "Backup Name"
        '
        'DownloadName
        '
        Me.DownloadName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.DownloadName.Border.Class = "TextBoxBorder"
        Me.DownloadName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DownloadName.ForeColor = System.Drawing.Color.Black
        Me.DownloadName.Location = New System.Drawing.Point(141, 72)
        Me.DownloadName.Name = "DownloadName"
        Me.DownloadName.Size = New System.Drawing.Size(128, 20)
        Me.DownloadName.TabIndex = 12
        Me.DownloadName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DownloadName.WatermarkText = "Backup Name"
        '
        'LoginButton
        '
        Me.LoginButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.LoginButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.LoginButton.Location = New System.Drawing.Point(13, 3)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(257, 23)
        Me.LoginButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LoginButton.TabIndex = 13
        Me.LoginButton.Text = "Login"
        '
        'Test2
        '
        Me.Test2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Test2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Test2.Location = New System.Drawing.Point(103, 32)
        Me.Test2.Name = "Test2"
        Me.Test2.Size = New System.Drawing.Size(75, 23)
        Me.Test2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Test2.TabIndex = 14
        Me.Test2.Text = "Test 2"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 155)
        Me.Controls.Add(Me.Test2)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.DownloadName)
        Me.Controls.Add(Me.backupName)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.OptionsOpenButton)
        Me.Controls.Add(Me.DownloadButton)
        Me.Controls.Add(Me.UploadButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(999, 726)
        Me.MinimumSize = New System.Drawing.Size(16, 38)
        Me.Name = "Main"
        Me.Text = "Dropcraft"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UploadButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DownloadButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents OptionsOpenButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents backupName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DownloadName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LoginButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Test2 As DevComponents.DotNetBar.ButtonX

End Class
