Public Class Form1

    Private Sub TSBuka_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBuka.Click
        OpenDlg.ShowDialog()
        If Microsoft.VisualBasic.FileIO.FileSystem.FileExists(OpenDlg.FileName) Then
            Timer.Start()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        OpenDlg.Title = "Open Image"
        OpenDlg.Filter = "Image Files (*.Bmp, *.Jpg)|*.bmp;*.jpg"
        Pic.SizeMode = PictureBoxSizeMode.StretchImage
        TSBuka.ToolTipText = "Open Image"
    End Sub

    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer.Tick
            Pic.Image = Image.FromFile(OpenDlg.FileName)
    End Sub

    Private Function GetShortFileName(ByVal LongFileName As String) As String
        Dim Pos As Integer
        Do
            Pos = InStr(LongFileName, "\")
            If Pos > 0 Then
                LongFileName = Mid(LongFileName, Pos + 1)
            End If
        Loop Until Pos <= 0
        Return LongFileName
    End Function

    Private Sub Pic_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Pic.MouseMove
        ToolTip.Show(OpenDlg.FileName, Pic, e.X, e.Y)
    End Sub
End Class