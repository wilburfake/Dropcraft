Public Class Options

    Private Sub DropboxBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropboxBrowse.Click

        ' Declare a variable named theFolderBrowser of type FolderBrowserDialog.
        Dim theFolderBrowser As New FolderBrowserDialog

        ' Set theFolderBrowser object's Description property to
        '   give the user instructions.
        theFolderBrowser.Description = "Please select your dropbox folder."

        ' Set theFolderBrowser object's ShowNewFolder property to false when
        '   the a FolderBrowserDialog is to be used only for selecting an existing folder.
        theFolderBrowser.ShowNewFolderButton = False

        ' Optionally set the RootFolder and SelectedPath properties to
        '   control which folder will be selected when browsing begings
        '   and to make it the selected folder.
        ' For this example start browsing in the Desktop folder.
        theFolderBrowser.RootFolder = System.Environment.SpecialFolder.Desktop
        ' Default theFolderBrowserDialog object's SelectedPath property to the path to the Desktop folder.
        theFolderBrowser.SelectedPath = My.Computer.FileSystem.SpecialDirectories.Desktop

        ' If the user clicks theFolderBrowser's OK button..
        If theFolderBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' Set the FolderChoiceTextBox's Text to theFolderBrowserDialog's
            '    SelectedPath property.
            Dim dropLocFile As String = My.Application.Info.DirectoryPath & "\droppath.txt"
            Me.DropboxLocBox.Text = theFolderBrowser.SelectedPath
            Dim objWriter As New System.IO.StreamWriter(dropLocFile)
            objWriter.Write(DropboxLocBox.Text)
            objWriter.Close()
            MsgBox("Please restart Dropcraft in order for changes to take effect")
        End If

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dropboxLocation As String
        Dim dropLocFile As String = My.Application.Info.DirectoryPath & "\droppath.txt"

        If System.IO.File.Exists(dropLocFile) = True Then
            dropboxLocation = My.Computer.FileSystem.ReadAllText(dropLocFile)
            DropboxLocBox.Text = dropboxLocation
        Else

        End If
    End Sub

    Private Sub DropboxLocBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropboxLocBox.TextChanged

    End Sub
End Class