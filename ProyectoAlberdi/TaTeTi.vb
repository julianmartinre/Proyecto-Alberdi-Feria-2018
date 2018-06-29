Public Class TaTeTi

    Dim tateti(2, 2) As Char
    Dim anterior As Char

    Private Sub TaTeTi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tateti(0, 0) = "e"
        tateti(0, 1) = "e"
        tateti(0, 2) = "e"
        tateti(1, 0) = "e"
        tateti(1, 1) = "e"
        tateti(1, 2) = "e"
        tateti(2, 0) = "e"
        tateti(2, 1) = "e"
        tateti(2, 2) = "e"

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        If anterior = "o" Or anterior = "e" Then
            PictureBox1.Image = New Bitmap("x.png")
            tateti(0, 0) = "x"
            anterior = "x"
            PictureBox1.Enabled = False
        Else
            PictureBox1.Image = New Bitmap("o.png")
            tateti(0, 0) = "o"
            anterior = "o"
            PictureBox1.Enabled = False
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        If anterior = "o" Or anterior = "e" Then
            PictureBox2.Image = New Bitmap("x.png")
            tateti(0, 1) = "x"
            anterior = "x"
            PictureBox2.Enabled = False
        Else
            PictureBox2.Image = New Bitmap("o.png")
            tateti(0, 1) = "o"
            anterior = "o"
            PictureBox2.Enabled = False
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        If anterior = "o" Or anterior = "e" Then
            PictureBox3.Image = New Bitmap("x.png")
            tateti(0, 2) = "x"
            anterior = "x"
            PictureBox3.Enabled = False
        Else
            PictureBox3.Image = New Bitmap("o.png")
            tateti(0, 2) = "o"
            anterior = "o"
            PictureBox3.Enabled = False
        End If

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        If anterior = "o" Or anterior = "e" Then
            PictureBox4.Image = New Bitmap("x.png")
            tateti(1, 0) = "x"
            anterior = "x"
            PictureBox4.Enabled = False
        Else
            PictureBox4.Image = New Bitmap("o.png")
            tateti(1, 0) = "o"
            anterior = "o"
            PictureBox4.Enabled = False
        End If

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        If anterior = "o" Or anterior = "e" Then
            PictureBox5.Image = New Bitmap("x.png")
            tateti(1, 1) = "x"
            anterior = "x"
            PictureBox5.Enabled = False
        Else
            PictureBox5.Image = New Bitmap("o.png")
            tateti(1, 1) = "o"
            anterior = "o"
            PictureBox5.Enabled = False
        End If

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

        If anterior = "o" Or anterior = "e" Then
            PictureBox6.Image = New Bitmap("x.png")
            tateti(1, 2) = "x"
            anterior = "x"
            PictureBox6.Enabled = False
        Else
            PictureBox6.Image = New Bitmap("o.png")
            tateti(1, 2) = "o"
            anterior = "o"
            PictureBox6.Enabled = False
        End If

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

        If anterior = "o" Or anterior = "e" Then
            PictureBox7.Image = New Bitmap("x.png")
            tateti(2, 0) = "x"
            anterior = "x"
            PictureBox7.Enabled = False
        Else
            PictureBox7.Image = New Bitmap("o.png")
            tateti(2, 0) = "o"
            anterior = "o"
            PictureBox7.Enabled = False
        End If

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

        If anterior = "o" Or anterior = "e" Then
            PictureBox8.Image = New Bitmap("x.png")
            tateti(2, 1) = "x"
            anterior = "x"
            PictureBox8.Enabled = False
        Else
            PictureBox8.Image = New Bitmap("o.png")
            tateti(2, 1) = "o"
            anterior = "o"
            PictureBox8.Enabled = False
        End If

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

        If anterior = "o" Or anterior = "e" Then
            PictureBox9.Image = New Bitmap("x.png")
            tateti(2, 2) = "x"
            anterior = "x"
            PictureBox9.Enabled = False
        Else
            PictureBox9.Image = New Bitmap("o.png")
            tateti(2, 2) = "o"
            anterior = "o"
            PictureBox9.Enabled = False
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'XOO
        'XOO
        'XOO
        If tateti(0, 0) = "x" Then
            If tateti(1, 0) = "x" Then
                If tateti(2, 0) = "x" Then
                    Timer1.Enabled = False
                    MsgBox("Ganó X.")
                End If
            End If
        End If

        'OXO
        'OXO
        'OXO
        If tateti(0, 1) = "x" Then
            If tateti(1, 1) = "x" Then
                If tateti(2, 1) = "x" Then
                    Timer1.Enabled = False
                    MsgBox("Ganó X.")
                End If
            End If
        End If

        'OOX
        'OOX
        'OOX
        If tateti(0, 2) = "x" Then
            If tateti(1, 2) = "x" Then
                If tateti(2, 2) = "x" Then
                    Timer1.Enabled = False
                    MsgBox("Ganó X.")
                End If
            End If
        End If

        'XXX
        'OOO
        'OOO
        If tateti(0, 0) = "x" Then
            If tateti(0, 1) = "x" Then
                If tateti(0, 2) = "x" Then
                    Timer1.Enabled = False
                    MsgBox("Ganó X.")
                End If
            End If
        End If

        'OOO
        'XXX
        'OOO
        If tateti(1, 0) = "x" Then
            If tateti(1, 1) = "x" Then
                If tateti(1, 2) = "x" Then
                    Timer1.Enabled = False
                    MsgBox("Ganó X.")
                End If
            End If
        End If

        'OOO
        'OOO
        'XXX
        If tateti(2, 0) = "x" Then
            If tateti(2, 1) = "x" Then
                If tateti(2, 2) = "x" Then
                    Timer1.Enabled = False
                    MsgBox("Ganó X.")
                End If
            End If
        End If

        'XOO
        'OXO
        'OOX
        If tateti(0, 0) = "x" Then
            If tateti(1, 1) = "x" Then
                If tateti(2, 2) = "x" Then
                    Timer1.Enabled = False
                    MsgBox("Ganó X.")
                End If
            End If
        End If

        'OOX
        'OXO
        'XOO
        If tateti(0, 2) = "x" Then
            If tateti(1, 1) = "x" Then
                If tateti(2, 0) = "x" Then
                    Timer1.Enabled = False
                    MsgBox("Ganó X.")
                End If
            End If
        End If

        'XOO
        'XOO
        'XOO
        If tateti(0, 0) = "o" Then
            If tateti(1, 0) = "o" Then
                If tateti(2, 0) = "o" Then
                    Timer1.Enabled = False
                    MsgBox("Ganó O.")
                End If
            End If
        End If

        'OXO
        'OXO
        'OXO
        If tateti(0, 1) = "o" Then
            If tateti(1, 1) = "o" Then
                If tateti(2, 1) = "o" Then
                    Timer1.Enabled = False
                    MsgBox("Ganó O.")
                End If
            End If
        End If

        'OOX
        'OOX
        'OOX
        If tateti(0, 2) = "o" Then
            If tateti(1, 2) = "o" Then
                If tateti(2, 2) = "o" Then
                    Timer1.Enabled = False
                    MsgBox("Ganó O.")
                End If
            End If
        End If

        'XXX
        'OOO
        'OOO
        If tateti(0, 0) = "o" Then
            If tateti(0, 1) = "o" Then
                If tateti(0, 2) = "o" Then
                    Timer1.Enabled = False
                    MsgBox("Ganó O.")
                End If
            End If
        End If

        'OOO
        'XXX
        'OOO
        If tateti(1, 0) = "o" Then
            If tateti(1, 1) = "o" Then
                If tateti(1, 2) = "o" Then
                    Timer1.Enabled = False
                    MsgBox("Ganó O.")
                End If
            End If
        End If

        'OOO
        'OOO
        'XXX
        If tateti(2, 0) = "o" Then
            If tateti(2, 1) = "o" Then
                If tateti(2, 2) = "o" Then
                    Timer1.Enabled = False
                    MsgBox("Ganó O.")
                End If
            End If
        End If

        'XOO
        'OXO
        'OOX
        If tateti(0, 0) = "o" Then
            If tateti(1, 1) = "o" Then
                If tateti(2, 2) = "o" Then
                    Timer1.Enabled = False
                    MsgBox("Ganó O.")
                End If
            End If
        End If

        'OOX
        'OXO
        'XOO
        If tateti(0, 2) = "o" Then
            If tateti(1, 1) = "o" Then
                If tateti(2, 0) = "o" Then
                    Timer1.Enabled = False
                    MsgBox("Ganó O.")
                End If
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ReiniciarJuego()

    End Sub

    Public Sub ReiniciarJuego()

        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        PictureBox3.Image = Nothing
        PictureBox4.Image = Nothing
        PictureBox5.Image = Nothing
        PictureBox6.Image = Nothing
        PictureBox7.Image = Nothing
        PictureBox8.Image = Nothing
        PictureBox9.Image = Nothing

        PictureBox1.Enabled = True
        PictureBox2.Enabled = True
        PictureBox3.Enabled = True
        PictureBox4.Enabled = True
        PictureBox5.Enabled = True
        PictureBox6.Enabled = True
        PictureBox7.Enabled = True
        PictureBox8.Enabled = True
        PictureBox9.Enabled = True

        tateti(0, 0) = "e"
        tateti(0, 1) = "e"
        tateti(0, 2) = "e"
        tateti(1, 0) = "e"
        tateti(1, 1) = "e"
        tateti(1, 2) = "e"
        tateti(2, 0) = "e"
        tateti(2, 1) = "e"
        tateti(2, 2) = "e"

        Timer1.Enabled = True

    End Sub

End Class