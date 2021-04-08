Public Class Start

    Private Sub Start_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Shell("nwrg.exe")
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("reg.txt")
        Dim lol As String
        lol = ("")
       If (fileReader) = lol Then
            Form1.Show()
            Me.Hide()
        ElseIf (fileReader) = ("T67ZH-XYTZU") Then
            Form3.Show()
            Me.Hide()
        Else : Form1.Show()
        End If
    End Sub
End Class
