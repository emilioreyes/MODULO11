<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClaveInvertida = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDigitoVerificador = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtClaveSri = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtClaveSri)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDigitoVerificador)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtClaveInvertida)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtClave)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 262)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MODULO 11"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(312, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 61)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "GENERAR DIGITO VERIFICADOR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(19, 48)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(503, 22)
        Me.txtClave.TabIndex = 1
        Me.txtClave.Text = "031220140117223322590011000000000000000000000352"
        Me.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CLAVE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CLAVE INVERTIDA:"
        '
        'txtClaveInvertida
        '
        Me.txtClaveInvertida.Location = New System.Drawing.Point(19, 102)
        Me.txtClaveInvertida.Name = "txtClaveInvertida"
        Me.txtClaveInvertida.Size = New System.Drawing.Size(503, 22)
        Me.txtClaveInvertida.TabIndex = 3
        Me.txtClaveInvertida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "DIGITO VERIFICADOR:"
        '
        'txtDigitoVerificador
        '
        Me.txtDigitoVerificador.Location = New System.Drawing.Point(19, 171)
        Me.txtDigitoVerificador.Name = "txtDigitoVerificador"
        Me.txtDigitoVerificador.Size = New System.Drawing.Size(147, 22)
        Me.txtDigitoVerificador.TabIndex = 5
        Me.txtDigitoVerificador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CLAVE SRI:"
        '
        'txtClaveSri
        '
        Me.txtClaveSri.Location = New System.Drawing.Point(19, 216)
        Me.txtClaveSri.Name = "txtClaveSri"
        Me.txtClaveSri.Size = New System.Drawing.Size(503, 22)
        Me.txtClaveSri.TabIndex = 7
        Me.txtClaveSri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 305)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "SRI - ECUADOR - MODULO 11"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtClave As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtClaveSri As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDigitoVerificador As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtClaveInvertida As TextBox
End Class
