Public Class Sumas

    'Definimos las variables en donde guardaremos los números aleatorios.
    Dim numeroRandom1 As Integer = 0
    Dim numeroRandom2 As Integer = 0

    'Definimos una variable "contador" la cual nos indicará la cantidad de sumas 
    'que va a tener el juego.
    Dim contador As Integer = 2

    'En el LOAD del formulario generamos los números aleatorios.
    Private Sub Sumas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Decimos que la variable numeroRandom1 y numeroRandom2 
        'van a ser igual a un número aleatorio entre 0 y 9.
        numeroRandom1 = Int(9 * Rnd())
        numeroRandom2 = Int(9 * Rnd())

        'Asignamos a los textBox el contenido de las variables que poseen
        'el número aleatorio.
        txtPrimerNumero.Text = numeroRandom1
        txtSegundoNumero.Text = numeroRandom2

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Definimos las variables que utilizaremos en la suma.
        Dim primerNumero As Integer
        Dim segundoNumero As Integer
        Dim resultado As Integer

        'Asignamos a las variables el contenido que hay dentro de los textBox.
        primerNumero = txtPrimerNumero.Text
        segundoNumero = txtSegundoNumero.Text

        'Decimos que la variable resultado será la suma del primerNumero + el segundoNumero.
        resultado = primerNumero + segundoNumero

        'Comprobamos si el resultado de la suma es igual al resultado ingresado
        'en el textBox.
        If resultado = txtResultado.Text Then

            'Si es correcto avisamos con un msgBox, generamos nuevos números y
            'decrementamos el contador en 1.
            MsgBox("CORRECTO.")
            numeroRandom1 = Int(9 * Rnd())
            numeroRandom2 = Int(9 * Rnd())
            contador = contador - 1

            'Si el contador llega al cero quiere decir que no hay mas cuentas por realizar.
            If contador = 0 Then

                'Si el contador es cero avisamos con un msgBox y deshabilitamos 
                'el textBox de resultado y el botón.
                MsgBox("Juego terminado.")
                txtResultado.Enabled = False
                Button1.Enabled = False

            Else

                'Si el contador no es cero volvemos a generar números aleatorios.
                txtPrimerNumero.Text = numeroRandom1
                txtSegundoNumero.Text = numeroRandom2
                txtResultado.Text = ""

            End If

        Else

            'Y por último, si no se dio ninguna de las condiciones anteriores,
            'decimos que el resultado de la cuenta fue incorrecto.
            MsgBox("Incorrecto.")

        End If

    End Sub

End Class