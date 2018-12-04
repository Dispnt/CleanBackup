Imports System.IO
Imports MaterialSkin

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        '======MaterialSkin结束

        TabPage1.Text = "Select Path"
        TabPage2.Text = "Then Find Pics"
        TabPage3.Text = "And Copy Them"

    End Sub
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles Page1NextStepButton.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub PathTextBox_Click(sender As Object, e As EventArgs) Handles TargetPathTextBox.Click
        TargetPathSelect.ShowDialog()
        TargetPathTextBox.Text = TargetPathSelect.SelectedPath + "\"
    End Sub
    Private Sub MaterialSingleLineTextField1_Click(sender As Object, e As EventArgs) Handles OriginalPathSelectTextBox.Click
        OriginalPathSelect.ShowDialog()
        OriginalPathSelectTextBox.Text = OriginalPathSelect.SelectedPath
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles Page2FindPicButton.Click
        ListView1.Items.Clear()
        '列出jpg
        Dim fileEntries As String() = Directory.GetFiles(OriginalPathSelectTextBox.Text, "*.jpg")
        For Each fileName In fileEntries
            ListView1.Items.Add(fileName)
        Next
        '列出png
        fileEntries = Directory.GetFiles(OriginalPathSelectTextBox.Text, "*.png")
        For Each fileName In fileEntries
            ListView1.Items.Add(fileName)
        Next
        '文件夹内jpg
        Dim folderEntries As String() = Directory.GetDirectories(OriginalPathSelectTextBox.Text)
        For Each folderName In folderEntries '每个文件夹内
            Dim fileInFolderEntries As String() = Directory.GetFiles(folderName, "*-final.jpg") '文件夹内每个final
            For Each fileName In fileInFolderEntries
                ListView1.Items.Add(fileName)
            Next
        Next
        '文件夹内png
        For Each folderName In folderEntries
            Dim fileInFolderEntries As String() = Directory.GetFiles(folderName, "*-final.png")
            For Each fileName In fileInFolderEntries
                ListView1.Items.Add(fileName)
            Next
        Next
        '数数
        itemsLabel.Text = ListView1.Items.Count
        '路径
        TargetPathLabel.Text = TargetPathTextBox.Text


        Page2NextStepButton.Visible = True
    End Sub

    Private Sub ListView1_ItemActivate(sender As Object, e As EventArgs) Handles ListView1.ItemActivate
        Process.Start(ListView1.SelectedItems(0).Text)
    End Sub

    Private Sub Page3CopyButton_Click(sender As Object, e As EventArgs) Handles Page3CopyButton.Click
        If ifOverwriteCheckBox.Checked = True Then
            Dim i As Integer
            For i = 0 To itemsLabel.Text - 1
                Dim fileName As String = ListView1.Items(i).Text.Substring(OriginalPathSelectTextBox.Text.Length + 1)
                fileName = fileName.Replace("\", "-")
                File.Copy(ListView1.Items(i).Text, TargetPathTextBox.Text + fileName, True)
            Next i
        Else
            Dim i As Integer
            For i = 0 To itemsLabel.Text - 1
                Dim fileName As String = ListView1.Items(i).Text.Substring(OriginalPathSelectTextBox.Text.Length + 1)
                fileName = fileName.Replace("\", "-")
                On Error Resume Next
                File.Copy(ListView1.Items(i).Text, TargetPathTextBox.Text + fileName, False)
            Next i
        End If
        MsgBox("Done")
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles Page2NextStepButton.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub
End Class
