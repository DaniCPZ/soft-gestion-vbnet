Public Class SystemSupportEmail
    Inherits MasterEmialServer
    Public Sub New()
        remitente = "prmsistemasoporte@gmail.com"
        password = "321..mnb.support"
        host = "smtp.gmail.com"
        port = 587
        ssl = True
        inicializar()
    End Sub
End Class
