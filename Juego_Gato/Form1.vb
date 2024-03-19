Public Class Form1
    Dim nj As Integer
    Dim c As Integer
    Sub REINICIAR()
        Dim OBJ As Control
        For Each OBJ In Me.Controls
            If TypeOf OBJ Is PictureBox Then
                Dim IMG As PictureBox
                OBJ.Tag = ""
                IMG = OBJ
                IMG.Image = Nothing
            End If
            'MessageBox.Show(OBJ.Name)
            nj = 0
            c = 0
            RadioButton1.Enabled = True
            RadioButton1.Checked = True
            RadioButton2.Checked = False
            RadioButton2.Enabled = True
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nj = 1
        c = 0
    End Sub

    Private Sub C11_Click(sender As System.Object, ByVal e As System.EventArgs) Handles C11.Click, C12.Click, C13.Click, C21.Click, C22.Click, C23.Click, C31.Click, C32.Click, C33.Click
        If nj <= 1 Then
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
        End If
        If sender.tag = "" Then
            If nj Mod 2 = 0 Then
                sender.image = Image.FromFile("C:\Users\LolaA\source\repos\Juego_Gato\Juego_Gato\Image\x.png")
                sender.tag = "x"
            Else
                sender.image = Image.FromFile("C:\Users\LolaA\source\repos\Juego_Gato\Juego_Gato\Image\o.png")
                sender.tag = "o"
            End If
            nj += 1
            c += 1
        Else
            MessageBox.Show("Celda Ocupada por:" + sender.tag)
        End If

        If C11.Tag = sender.Tag And C12.Tag = sender.Tag And C13.Tag = sender.Tag Then
            MsgBox("BIEN HECHO, GANO " & sender.Tag, MsgBoxStyle.Information, "ACIERTO")
            REINICIAR()
        ElseIf C11.Tag = sender.Tag And C21.Tag = sender.Tag And C31.Tag = sender.Tag Then
            MsgBox("BIEN HECHO, GANO " & sender.Tag, MsgBoxStyle.Information, "ACIERTO")
            REINICIAR()
        ElseIf C13.Tag = sender.Tag And C23.Tag = sender.Tag And C33.Tag = sender.Tag Then
            MsgBox("BIEN HECHO, GANO " & sender.Tag, MsgBoxStyle.Information, "ACIERTO")
            REINICIAR()
        ElseIf C31.Tag = sender.Tag And C32.Tag = sender.Tag And C33.Tag = sender.Tag Then
            MsgBox("BIEN HECHO, GANO " & sender.Tag, MsgBoxStyle.Information, "ACIERTO")
            REINICIAR()
        ElseIf C11.Tag = sender.Tag And C22.Tag = sender.Tag And C33.Tag = sender.Tag Then
            MsgBox("BIEN HECHO, GANO " & sender.Tag, MsgBoxStyle.Information, "ACIERTO")
            REINICIAR()
        ElseIf C13.Tag = sender.Tag And C22.Tag = sender.Tag And C31.Tag = sender.Tag Then
            MsgBox("BIEN HECHO, GANO " & sender.Tag, MsgBoxStyle.Information, "ACIERTO")
            REINICIAR()
        ElseIf C21.Tag = sender.Tag And C22.Tag = sender.Tag And C23.Tag = sender.Tag Then
            MsgBox("BIEN HECHO, GANO " & sender.Tag, MsgBoxStyle.Information, "ACIERTO")
            REINICIAR()
        ElseIf C12.Tag = sender.Tag And C22.Tag = sender.Tag And C32.Tag = sender.Tag Then
            MsgBox("BIEN HECHO, GANO " & sender.Tag, MsgBoxStyle.Information, "ACIERTO")
            REINICIAR()
        ElseIf c = 9 Then
            MsgBox("EL JUEGO TERMINO, NO HAY GANADOR.", MsgBoxStyle.Critical, "DESACIERTO")
            REINICIAR()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        nj = 0
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        nj = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        REINICIAR()
    End Sub
End Class