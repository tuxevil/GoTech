Public Class Reservas
    Public Sub carga_reserva()
        Dim db As New SqlClient.SqlConnection()
        Dim da As New SqlClient.SqlDataAdapter
        Dim cm As New SqlClient.SqlCommand
        db.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=ReservaCanchas;Persist Security Info=True;User ID=sa;Password=gotechdev"
        cm.Connection = db
        cm.Connection.Open()
        cm.CommandText = "SELECT codigo, nombre as Cliente, hora as Hora FROM reservas WHERE (status = 'A') ORDER BY hora"
        cm.ExecuteReader()
        db.Close()
        'MessageBox.Show("Cliente creado con exito")
    End Sub
End Class
