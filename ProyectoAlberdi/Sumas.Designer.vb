<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sumas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtPrimerNumero = New System.Windows.Forms.TextBox()
        Me.txtSegundoNumero = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPrimerNumero
        '
        Me.txtPrimerNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerNumero.Location = New System.Drawing.Point(38, 28)
        Me.txtPrimerNumero.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrimerNumero.Name = "txtPrimerNumero"
        Me.txtPrimerNumero.Size = New System.Drawing.Size(89, 68)
        Me.txtPrimerNumero.TabIndex = 0
        '
        'txtSegundoNumero
        '
        Me.txtSegundoNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoNumero.Location = New System.Drawing.Point(38, 132)
        Me.txtSegundoNumero.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSegundoNumero.Name = "txtSegundoNumero"
        Me.txtSegundoNumero.Size = New System.Drawing.Size(89, 68)
        Me.txtSegundoNumero.TabIndex = 1
        '
        'txtResultado
        '
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.Location = New System.Drawing.Point(38, 245)
        Me.txtResultado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(89, 67)
        Me.txtResultado.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "+"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 200)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "_______"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 326)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 55)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "COMPROBAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Sumas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(159, 390)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtSegundoNumero)
        Me.Controls.Add(Me.txtPrimerNumero)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Sumas"
        Me.Text = "Sumas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPrimerNumero As TextBox
    Friend WithEvents txtSegundoNumero As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
