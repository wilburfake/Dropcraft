<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.UploadButton = New System.Windows.Forms.Button()
        Me.DownloadButton = New System.Windows.Forms.Button()
        Me.backupName = New System.Windows.Forms.TextBox()
        Me.OptionsOpenButton = New System.Windows.Forms.Button()
        Me.DownloadName = New System.Windows.Forms.TextBox()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UploadButton
        '
        Me.UploadButton.Location = New System.Drawing.Point(12, 8)
        Me.UploadButton.Name = "UploadButton"
        Me.UploadButton.Size = New System.Drawing.Size(75, 23)
        Me.UploadButton.TabIndex = 0
        Me.UploadButton.Text = "Upload"
        Me.UploadButton.UseVisualStyleBackColor = True
        '
        'DownloadButton
        '
        Me.DownloadButton.Location = New System.Drawing.Point(196, 8)
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(75, 23)
        Me.DownloadButton.TabIndex = 1
        Me.DownloadButton.Text = "Download"
        Me.DownloadButton.UseVisualStyleBackColor = True
        '
        'backupName
        '
        Me.backupName.Location = New System.Drawing.Point(12, 37)
        Me.backupName.Name = "backupName"
        Me.backupName.Size = New System.Drawing.Size(123, 20)
        Me.backupName.TabIndex = 2
        '
        'OptionsOpenButton
        '
        Me.OptionsOpenButton.Location = New System.Drawing.Point(12, 63)
        Me.OptionsOpenButton.Name = "OptionsOpenButton"
        Me.OptionsOpenButton.Size = New System.Drawing.Size(259, 23)
        Me.OptionsOpenButton.TabIndex = 4
        Me.OptionsOpenButton.Text = "Options"
        Me.OptionsOpenButton.UseVisualStyleBackColor = True
        '
        'DownloadName
        '
        Me.DownloadName.Location = New System.Drawing.Point(142, 37)
        Me.DownloadName.Name = "DownloadName"
        Me.DownloadName.Size = New System.Drawing.Size(128, 20)
        Me.DownloadName.TabIndex = 5
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(12, 92)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(259, 23)
        Me.HelpButton.TabIndex = 6
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 118)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.DownloadName)
        Me.Controls.Add(Me.OptionsOpenButton)
        Me.Controls.Add(Me.backupName)
        Me.Controls.Add(Me.DownloadButton)
        Me.Controls.Add(Me.UploadButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(999, 726)
        Me.MinimumSize = New System.Drawing.Size(1, 1)
        Me.Name = "Form1"
        Me.Text = "Dropcraft"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UploadButton As System.Windows.Forms.Button
    Friend WithEvents DownloadButton As System.Windows.Forms.Button
    Friend WithEvents backupName As System.Windows.Forms.TextBox
    Friend WithEvents OptionsOpenButton As System.Windows.Forms.Button
    Friend WithEvents DownloadName As System.Windows.Forms.TextBox
    Friend WithEvents HelpButton As System.Windows.Forms.Button

End Class
