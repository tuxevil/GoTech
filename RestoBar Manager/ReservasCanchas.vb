Public Class ReservasCanchas

    Private Sub ReservasCanchas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cc As New Reservas
        cc.carga_reserva()

    End Sub
End Class