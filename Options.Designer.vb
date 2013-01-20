<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.DropboxLocBox = New System.Windows.Forms.TextBox()
        Me.DropboxBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DropboxLocBox
        '
        Me.DropboxLocBox.Location = New System.Drawing.Point(12, 34)
        Me.DropboxLocBox.Name = "DropboxLocBox"
        Me.DropboxLocBox.Size = New System.Drawing.Size(178, 20)
        Me.DropboxLocBox.TabIndex = 0
        '
        'DropboxBrowse
        '
        Me.DropboxBrowse.Location = New System.Drawing.Point(197, 34)
        Me.DropboxBrowse.Name = "DropboxBrowse"
        Me.DropboxBrowse.Size = New System.Drawing.Size(75, 23)
        Me.DropboxBrowse.TabIndex = 1
        Me.DropboxBrowse.Text = "Browse"
        Me.DropboxBrowse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dropbox Directory"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 66)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DropboxBrowse)
        Me.Controls.Add(Me.DropboxLocBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DropboxLocBox As System.Windows.Forms.TextBox
    Friend WithEvents DropboxBrowse As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
