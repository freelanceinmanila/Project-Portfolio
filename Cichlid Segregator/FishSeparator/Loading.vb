Imports FishSeparator.mainform
Public Class Loading

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ProgressBar.Value += 1
        Label1.Text = ProgressBar.Value.ToString + "%"
        If ProgressBar.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            mainform.Show()
        End If
    End Sub

    Private Sub Loading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub
End Class