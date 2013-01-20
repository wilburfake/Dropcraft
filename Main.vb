Public Class Main

    Dim dropboxLocation As String
    Dim appData As String = Environment.GetEnvironmentVariable("AppData")

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dropLocFile As String = My.Application.Info.DirectoryPath & "\droppath.txt"

        dropboxLocation = My.Computer.FileSystem.ReadAllText(dropLocFile)
        If dropboxLocation.Contains(":") Then

        Else
            MsgBox("Your config file is empty, you will need to fill out some information in the options window so Dropcraft can function correctly.")
        End If

        If My.Computer.FileSystem.DirectoryExists(dropboxLocation & "/minecraft-storage/") Then

        Else
            My.Computer.FileSystem.CreateDirectory(dropboxLocation & "/minecraft-storage/")
        End If
    End Sub

    Private Sub UploadButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UploadButton.Click
        If My.Computer.FileSystem.DirectoryExists(dropboxLocation & "/minecraft-storage/" & backupName.Text) Then
            If My.Computer.FileSystem.DirectoryExists(dropboxLocation & "/minecraft-storage/" & backupName.Text & ".old") Then
                MsgBox("Warning: There are two backups with this name, removing oldest backup and uploading current backup")
                My.Computer.FileSystem.DeleteDirectory(dropboxLocation & "/minecraft-storage/" & backupName.Text & ".old", FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.RenameDirectory(dropboxLocation & "/minecraft-storage/" & backupName.Text, backupName.Text & ".old")
            Else
                MsgBox("Updating backup, renaming old backup to " & backupName.Text & ".old")
                My.Computer.FileSystem.RenameDirectory(dropboxLocation & "/minecraft-storage/" & backupName.Text, backupName.Text & ".old")
            End If
        Else
            My.Computer.FileSystem.CreateDirectory(dropboxLocation & "/minecraft-storage/" & backupName.Text)
        End If
        MsgBox("This next step may take a while. Press ok to continue")
        My.Computer.FileSystem.CopyDirectory(appData & "\.minecraft", dropboxLocation & "/minecraft-storage/" & backupName.Text, True)
        MsgBox("Uploaded To Dropbox!")
    End Sub

    Private Sub DownloadButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadButton.Click
        Dim Response As Integer

        If My.Computer.FileSystem.DirectoryExists(dropboxLocation & "/minecraft-storage/" & DownloadName.Text) Then
            ' Displays a message box with the yes and no options.
            Response = MsgBox(Prompt:="WARNING: This will overwrite your current minecraft files, do you want to continue?", Buttons:=vbYesNo)

            ' If statement to check if the yes button was selected.
            If Response = vbYes Then
                My.Computer.FileSystem.DeleteDirectory(appData & "\.minecraft", FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.CopyDirectory(dropboxLocation & "/minecraft-storage/" & DownloadName.Text, appData & "\.minecraft", True)
                MsgBox("Downloaded!")
            Else
                ' The no button was selected.
            End If
        Else
            MsgBox("No Such Backup")
        End If
    End Sub

    Private Sub OptionsOpenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsOpenButton.Click
        Options.Show()
    End Sub

    Private Sub HelpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpButton.Click
        Dim helpCommand As String

        helpCommand = "notepad " & My.Application.Info.DirectoryPath & "\help.txt"
        Shell(helpCommand)
    End Sub
End Class
