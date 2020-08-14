Public Class ValidacionesExtras
    Private valido As Boolean
    Private cadenaDeTexto As String
    Public Sub New(s As String)
        cadenaDeTexto = s
    End Sub
    Public Function ToDecimal(ByRef msg As String, ByRef resultado As Decimal) As Boolean
        If Not cadenaDeTexto = "" Then
            If Decimal.TryParse(cadenaDeTexto, resultado) Then
                valido = True
            Else
                valido = False
                msg = "El campo " + msg + " no es un numero decimal valido"
            End If
        Else
            valido = False
            msg = "El campo " + msg + " es requerido"
        End If
        Return valido
    End Function
    Public Function ToInteger(ByRef msg As String, ByRef resultado As Integer) As Boolean
        If Not cadenaDeTexto = "" Then
            If Integer.TryParse(cadenaDeTexto, resultado) Then
                valido = True
            Else
                valido = False
                msg = "El campo " + msg + " no es un numero entero valido."
            End If
        Else
            valido = False
            msg = "El campo " + msg + " es requerido."
        End If
        Return valido
    End Function
End Class
