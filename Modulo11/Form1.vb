Public Class Form1
    'Este algoritmo lo puedes aplicar a una cadena de n caracteres para generar el digito verificador de dicha cedena
    'Acorde a Ficha técnica, Manual de usuario, catálogo y especificaciones técnicas, Método de automatización off-line.
    'ACTUALIZADO ENERO 2022. Versión 2.21

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'lineaS para comprobar la funcion
        'VALOR DE EJEMPLO = 031220140117223322590011000000000000000000000352 -> el resultado debe ser = 9
        'VELOR DE EJMPLO MANUAL SRI: 41261533 ->  el resultado debe ser = 6
        txtDigitoVerificador.Text = getDigitoComprobador(txtClave.Text.Trim)
    End Sub
    Public Function getDigitoComprobador(clave)
        Try
            'ALMACENA EL DIGITO VERIFICADOR
            Dim digito_verificador As String
            'CONTROLA EL MAXIMO MULTIPLICADOR
            Dim MAX As Int64 = 7
            'CONTROLA EL MINIMO MULTIPLICADOR -> LUEGO SE INCREMENTARA HASTA IGUALAR A MAX
            Dim MIN As Int64 = 2
            'PARA FACILITAR EL RECORRIDO INVIERTO LA CLAVE
            Dim claveInvertida As String = Microsoft.VisualBasic.StrReverse(clave)
            txtClaveInvertida.Text = claveInvertida

            Dim resultado As Int64 = 0
            Dim resultado_acumulado As Int64 = 0
            For n = 0 To Len(claveInvertida) - 1
                'OBTENGO EL VALOR (n) DE LA CLAVE INVERTIDA
                Dim valor As String = claveInvertida.Chars(n)
                'RESULTADO ALMACENA EL VALOR OBTENIDO POR EL MINIMO MULTIPLICADOR
                resultado = Convert.ToInt64(valor) * MIN
                'SE ACUMULA EL RESULTADO 
                resultado_acumulado = resultado_acumulado + resultado
                'CONTROLA EL MULTIPLICADOR
                If (MIN >= MAX) Then
                    'REINICIAMOS EL MINIMO MULTIPLICADOR SI YA SE ALCANZO EL MAXIMO
                    MIN = 2
                Else
                    'INCREMENTAMOS EL MINIMO MULTIPLICADOR
                    MIN = MIN + 1
                End If
                'REPETIMOS EL PROCESO
            Next n
            ' MsgBox("resultado: " + Convert.ToString(resultado_acumulado))
            digito_verificador = 11 - (resultado_acumulado Mod 11)
            If digito_verificador = 10 Then
                digito_verificador = 1
            ElseIf digito_verificador = 11 Then
                digito_verificador = 0
            End If
            txtClaveSri.Text = clave + digito_verificador
            Return digito_verificador
        Catch ex As Exception
            MsgBox("error al generar digito comprobador " + ex.Message, MsgBoxStyle.Information)
        End Try
    End Function
End Class
