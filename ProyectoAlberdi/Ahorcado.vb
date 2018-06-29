Public Class Ahorcado

    Dim CantidadDeErrores As Integer
    Dim VectorPalabra(5) As Char

    Private Sub txtLetra1_TextChanged(sender As Object, e As EventArgs) Handles txtLetra1.TextChanged

        If txtLetra1.Text = "Ñ" Or txtLetra1.Text = "ñ" Then

            txtLetra1.BackColor = Color.GreenYellow
            VectorPalabra(0) = "Ñ"
            txtLetra1.Enabled = False

        Else

            If txtLetra1.Text = "" Then

                txtLetra1.BackColor = Color.Aqua

            Else

                txtLetra1.BackColor = Color.IndianRed
                CantidadDeErrores = CantidadDeErrores + 1
                MsgBox("Letra incorrecta.")
                txtLetra1.Text = ""

            End If

        End If

        If CantidadDeErrores = 1 Then
            PictureBox1.Image = New Bitmap("8.PNG")
        Else
            If CantidadDeErrores = 2 Then
                PictureBox1.Image = New Bitmap("7.PNG")
            Else
                If CantidadDeErrores = 3 Then
                    PictureBox1.Image = New Bitmap("6.PNG")
                Else
                    If CantidadDeErrores = 4 Then
                        PictureBox1.Image = New Bitmap("5.PNG")
                    Else
                        If CantidadDeErrores = 5 Then
                            PictureBox1.Image = New Bitmap("4.PNG")
                        Else
                            If CantidadDeErrores = 6 Then
                                PictureBox1.Image = New Bitmap("3.PNG")
                            Else

                                If CantidadDeErrores = 7 Then
                                    PictureBox1.Image = New Bitmap("2.PNG")
                                Else
                                    If CantidadDeErrores = 8 Then
                                        PictureBox1.Image = New Bitmap("1.PNG")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub txtLetra2_TextChanged(sender As Object, e As EventArgs) Handles txtLetra2.TextChanged

        If txtLetra2.Text = "O" Or txtLetra2.Text = "o" Then

            txtLetra2.BackColor = Color.GreenYellow
            VectorPalabra(1) = "O"
            txtLetra2.Enabled = False

        Else

            If txtLetra2.Text = "" Then

                txtLetra2.BackColor = Color.Aqua

            Else

                txtLetra2.BackColor = Color.IndianRed
                CantidadDeErrores = CantidadDeErrores + 1
                MsgBox("Letra incorrecta.")
                txtLetra2.Text = ""

            End If

        End If

        If CantidadDeErrores = 1 Then
            PictureBox1.Image = New Bitmap("8.PNG")
        Else
            If CantidadDeErrores = 2 Then
                PictureBox1.Image = New Bitmap("7.PNG")
            Else
                If CantidadDeErrores = 3 Then
                    PictureBox1.Image = New Bitmap("6.PNG")
                Else
                    If CantidadDeErrores = 4 Then
                        PictureBox1.Image = New Bitmap("5.PNG")
                    Else
                        If CantidadDeErrores = 5 Then
                            PictureBox1.Image = New Bitmap("4.PNG")
                        Else
                            If CantidadDeErrores = 6 Then
                                PictureBox1.Image = New Bitmap("3.PNG")
                            Else

                                If CantidadDeErrores = 7 Then
                                    PictureBox1.Image = New Bitmap("2.PNG")
                                Else
                                    If CantidadDeErrores = 8 Then
                                        PictureBox1.Image = New Bitmap("1.PNG")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub txtLetra3_TextChanged(sender As Object, e As EventArgs) Handles txtLetra3.TextChanged

        If txtLetra3.Text = "Q" Or txtLetra3.Text = "q" Then

            txtLetra3.BackColor = Color.GreenYellow
            VectorPalabra(2) = "Q"
            txtLetra3.Enabled = False

        Else

            If txtLetra3.Text = "" Then

                txtLetra3.BackColor = Color.Aqua

            Else

                txtLetra3.BackColor = Color.IndianRed
                CantidadDeErrores = CantidadDeErrores + 1
                MsgBox("Letra incorrecta.")
                txtLetra3.Text = ""

            End If

        End If

        If CantidadDeErrores = 1 Then
            PictureBox1.Image = New Bitmap("8.PNG")
        Else
            If CantidadDeErrores = 2 Then
                PictureBox1.Image = New Bitmap("7.PNG")
            Else
                If CantidadDeErrores = 3 Then
                    PictureBox1.Image = New Bitmap("6.PNG")
                Else
                    If CantidadDeErrores = 4 Then
                        PictureBox1.Image = New Bitmap("5.PNG")
                    Else
                        If CantidadDeErrores = 5 Then
                            PictureBox1.Image = New Bitmap("4.PNG")
                        Else
                            If CantidadDeErrores = 6 Then
                                PictureBox1.Image = New Bitmap("3.PNG")
                            Else

                                If CantidadDeErrores = 7 Then
                                    PictureBox1.Image = New Bitmap("2.PNG")
                                Else
                                    If CantidadDeErrores = 8 Then
                                        PictureBox1.Image = New Bitmap("1.PNG")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub txtLetra4_TextChanged(sender As Object, e As EventArgs) Handles txtLetra4.TextChanged

        If txtLetra4.Text = "U" Or txtLetra4.Text = "u" Then

            txtLetra4.BackColor = Color.GreenYellow
            VectorPalabra(3) = "U"
            txtLetra4.Enabled = False

        Else

            If txtLetra4.Text = "" Then

                txtLetra4.BackColor = Color.Aqua

            Else

                txtLetra4.BackColor = Color.IndianRed
                CantidadDeErrores = CantidadDeErrores + 1
                MsgBox("Letra incorrecta.")
                txtLetra4.Text = ""

            End If

        End If

        If CantidadDeErrores = 1 Then
            PictureBox1.Image = New Bitmap("8.PNG")
        Else
            If CantidadDeErrores = 2 Then
                PictureBox1.Image = New Bitmap("7.PNG")
            Else
                If CantidadDeErrores = 3 Then
                    PictureBox1.Image = New Bitmap("6.PNG")
                Else
                    If CantidadDeErrores = 4 Then
                        PictureBox1.Image = New Bitmap("5.PNG")
                    Else
                        If CantidadDeErrores = 5 Then
                            PictureBox1.Image = New Bitmap("4.PNG")
                        Else
                            If CantidadDeErrores = 6 Then
                                PictureBox1.Image = New Bitmap("3.PNG")
                            Else

                                If CantidadDeErrores = 7 Then
                                    PictureBox1.Image = New Bitmap("2.PNG")
                                Else
                                    If CantidadDeErrores = 8 Then
                                        PictureBox1.Image = New Bitmap("1.PNG")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub txtLetra5_TextChanged(sender As Object, e As EventArgs) Handles txtLetra5.TextChanged

        If txtLetra5.Text = "I" Or txtLetra5.Text = "i" Then

            txtLetra5.BackColor = Color.GreenYellow
            VectorPalabra(4) = "I"
            txtLetra5.Enabled = False

        Else

            If txtLetra5.Text = "" Then

                txtLetra5.BackColor = Color.Aqua

            Else

                txtLetra5.BackColor = Color.IndianRed
                CantidadDeErrores = CantidadDeErrores + 1
                MsgBox("Letra incorrecta.")
                txtLetra5.Text = ""

            End If

        End If

        If CantidadDeErrores = 1 Then
            PictureBox1.Image = New Bitmap("8.PNG")
        Else
            If CantidadDeErrores = 2 Then
                PictureBox1.Image = New Bitmap("7.PNG")
            Else
                If CantidadDeErrores = 3 Then
                    PictureBox1.Image = New Bitmap("6.PNG")
                Else
                    If CantidadDeErrores = 4 Then
                        PictureBox1.Image = New Bitmap("5.PNG")
                    Else
                        If CantidadDeErrores = 5 Then
                            PictureBox1.Image = New Bitmap("4.PNG")
                        Else
                            If CantidadDeErrores = 6 Then
                                PictureBox1.Image = New Bitmap("3.PNG")
                            Else

                                If CantidadDeErrores = 7 Then
                                    PictureBox1.Image = New Bitmap("2.PNG")
                                Else
                                    If CantidadDeErrores = 8 Then
                                        PictureBox1.Image = New Bitmap("1.PNG")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtLetra6_TextChanged(sender As Object, e As EventArgs) Handles txtLetra6.TextChanged

        If txtLetra6.Text = "S" Or txtLetra6.Text = "s" Then

            txtLetra6.BackColor = Color.GreenYellow
            VectorPalabra(5) = "S"
            txtLetra6.Enabled = False

        Else

            If txtLetra6.Text = "" Then

                txtLetra6.BackColor = Color.Aqua

            Else

                txtLetra6.BackColor = Color.IndianRed
                CantidadDeErrores = CantidadDeErrores + 1
                MsgBox("Letra incorrecta.")
                txtLetra6.Text = ""

            End If

        End If

        If CantidadDeErrores = 1 Then
            PictureBox1.Image = New Bitmap("8.PNG")
        Else
            If CantidadDeErrores = 2 Then
                PictureBox1.Image = New Bitmap("7.PNG")
            Else
                If CantidadDeErrores = 3 Then
                    PictureBox1.Image = New Bitmap("6.PNG")
                Else
                    If CantidadDeErrores = 4 Then
                        PictureBox1.Image = New Bitmap("5.PNG")
                    Else
                        If CantidadDeErrores = 5 Then
                            PictureBox1.Image = New Bitmap("4.PNG")
                        Else
                            If CantidadDeErrores = 6 Then
                                PictureBox1.Image = New Bitmap("3.PNG")
                            Else

                                If CantidadDeErrores = 7 Then
                                    PictureBox1.Image = New Bitmap("2.PNG")
                                Else
                                    If CantidadDeErrores = 8 Then
                                        PictureBox1.Image = New Bitmap("1.PNG")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If VectorPalabra(0) = "Ñ" And VectorPalabra(1) = "O" And VectorPalabra(2) = "Q" And VectorPalabra(3) = "U" And VectorPalabra(4) = "I" And VectorPalabra(5) = "S" Then
            VectorPalabra(0) = ""
            MsgBox("Correcto!")
        End If

    End Sub

End Class