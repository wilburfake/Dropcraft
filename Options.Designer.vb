<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.DropboxLocBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.DropboxBrowse = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(197, 83)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 3
        Me.ButtonX1.Text = "Browse"
        '
        'TextBoxX1
        '
        Me.TextBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX1.Location = New System.Drawing.Point(12, 83)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(177, 20)
        Me.TextBoxX1.TabIndex = 4
        '
        'DropboxLocBox
        '
        Me.DropboxLocBox.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.DropboxLocBox.Border.Class = "TextBoxBorder"
        Me.DropboxLocBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DropboxLocBox.ForeColor = System.Drawing.Color.Black
        Me.DropboxLocBox.Location = New System.Drawing.Point(12, 28)
        Me.DropboxLocBox.Name = "DropboxLocBox"
        Me.DropboxLocBox.Size = New System.Drawing.Size(177, 20)
        Me.DropboxLocBox.TabIndex = 5
        '
        'DropboxBrowse
        '
        Me.DropboxBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.DropboxBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.DropboxBrowse.Location = New System.Drawing.Point(197, 25)
        Me.DropboxBrowse.Name = "DropboxBrowse"
        Me.DropboxBrowse.Size = New System.Drawing.Size(75, 23)
        Me.DropboxBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DropboxBrowse.TabIndex = 6
        Me.DropboxBrowse.Text = "Browse"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 54)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(260, 23)
        Me.LabelX1.TabIndex = 7
        Me.LabelX1.Text = "Minecraft Location"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(12, -1)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(260, 23)
        Me.LabelX2.TabIndex = 8
        Me.LabelX2.Text = "Dropbox Location"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 118)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.DropboxBrowse)
        Me.Controls.Add(Me.DropboxLocBox)
        Me.Controls.Add(Me.TextBoxX1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Options"
        Me.Text = "Options"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DropboxLocBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DropboxBrowse As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
End Class
