Public Class NuevoCliente

    Private Sub NuevoCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FORMA_PAGOTableAdapter.Fill(Me.DsFormaConsumo._FORMA_PAGO)
    End Sub


    Private Sub btSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalir.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGrabar.Click
        numtarjeta = CType(tbNumTarjeta.Text, Integer)
        nombreCliente = tbNombre.Text
        fechaCliente = CType(dtpFecha.Value, String)
        hombresCliente = CType(tbHombres.Text, Integer)
        mujeresCliente = CType(tbMujeres.Text, Integer)
        Dim cc As New C_baradmin
        cc.add_tarjeta()
    End Sub
End Class