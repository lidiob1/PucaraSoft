Public Class FrmSplash
    Dim contador As Integer = 4

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Me.Opacity -= 0.07
            If Me.Opacity = 0.0 Then
                FrmMenu.Show()
                Me.Hide()
                Timer1.Enabled = False
            End If
        Else
            ProgressBar1.Value += 4
            If ProgressBar1.Value = contador Then
                Label1.Text = "Iniciando..."
            ElseIf ProgressBar1.Value = contador + 16 Then
                Label1.Text = ""
                contador += 20
            End If
            If ProgressBar1.Value = 28 Then
                Label2.Text = "CopyRight © 2017 All Rights Reserved"
            End If
        End If
    End Sub

    Private Sub FrmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class