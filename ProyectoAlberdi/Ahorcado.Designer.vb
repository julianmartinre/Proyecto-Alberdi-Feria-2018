<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ahorcado
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtLetra1 = New System.Windows.Forms.TextBox()
        Me.txtLetra2 = New System.Windows.Forms.TextBox()
        Me.txtLetra4 = New System.Windows.Forms.TextBox()
        Me.txtLetra3 = New System.Windows.Forms.TextBox()
        Me.txtLetra6 = New System.Windows.Forms.TextBox()
        Me.txtLetra5 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(9, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(310, 267)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtLetra1
        '
        Me.txtLetra1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLetra1.Location = New System.Drawing.Point(16, 292)
        Me.txtLetra1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLetra1.Name = "txtLetra1"
        Me.txtLetra1.Size = New System.Drawing.Size(47, 37)
        Me.txtLetra1.TabIndex = 1
        '
        'txtLetra2
        '
        Me.txtLetra2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLetra2.Location = New System.Drawing.Point(67, 292)
        Me.txtLetra2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLetra2.Name = "txtLetra2"
        Me.txtLetra2.Size = New System.Drawing.Size(47, 37)
        Me.txtLetra2.TabIndex = 2
        '
        'txtLetra4
        '
        Me.txtLetra4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLetra4.Location = New System.Drawing.Point(167, 292)
        Me.txtLetra4.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLetra4.Name = "txtLetra4"
        Me.txtLetra4.Size = New System.Drawing.Size(47, 37)
        Me.txtLetra4.TabIndex = 4
        '
        'txtLetra3
        '
        Me.txtLetra3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLetra3.Location = New System.Drawing.Point(117, 292)
        Me.txtLetra3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLetra3.Name = "txtLetra3"
        Me.txtLetra3.Size = New System.Drawing.Size(47, 37)
        Me.txtLetra3.TabIndex = 3
        '
        'txtLetra6
        '
        Me.txtLetra6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLetra6.Location = New System.Drawing.Point(268, 292)
        Me.txtLetra6.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLetra6.Name = "txtLetra6"
        Me.txtLetra6.Size = New System.Drawing.Size(47, 37)
        Me.txtLetra6.TabIndex = 6
        '
        'txtLetra5
        '
        Me.txtLetra5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLetra5.Location = New System.Drawing.Point(218, 292)
        Me.txtLetra5.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLetra5.Name = "txtLetra5"
        Me.txtLetra5.Size = New System.Drawing.Size(47, 37)
        Me.txtLetra5.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Ahorcado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(328, 349)
        Me.Controls.Add(Me.txtLetra6)
        Me.Controls.Add(Me.txtLetra5)
        Me.Controls.Add(Me.txtLetra4)
        Me.Controls.Add(Me.txtLetra3)
        Me.Controls.Add(Me.txtLetra2)
        Me.Controls.Add(Me.txtLetra1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Ahorcado"
        Me.Text = "Ahorcado"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtLetra1 As TextBox
    Friend WithEvents txtLetra2 As TextBox
    Friend WithEvents txtLetra4 As TextBox
    Friend WithEvents txtLetra3 As TextBox
    Friend WithEvents txtLetra6 As TextBox
    Friend WithEvents txtLetra5 As TextBox
    Friend WithEvents Timer1 As Timer
End Class
