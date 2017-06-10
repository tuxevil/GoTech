Public Class C_baradmin

    Public Sub add_consumo()
        Dim db As New SqlClient.SqlConnection()
        Dim cm As New SqlClient.SqlCommand
        db.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev"
        cm.Connection = db
        cm.Connection.Open()
        cm.CommandText = "insert into dbo.CONSUMO (cod_tarjeta, cod_clase, cod_tipo, cod_subtipo, cantidad, status) values (" & codCliente & "," & codClase & "," & codTipo & "," & codSubTipo & "," & cantidadProd & ",'A')"
        cm.ExecuteReader()
        db.Close()
        'MessageBox.Show("Producto agregado con exito")
    End Sub
    Public Sub add_mesa()
        Dim db As New SqlClient.SqlConnection()
        Dim cm As New SqlClient.SqlCommand
        db.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev"
        cm.Connection = db
        cm.Connection.Open()
        cm.CommandText = "insert into dbo.CONSUMO2 (cod_mesa, cod_mesero, cod_clase, cod_tipo, cod_subtipo, cantidad, status) values (" & codMesa & "," & codMesero & "," & codClase & "," & codTipo & "," & codSubTipo & "," & cantidadProd & ",'A')"
        cm.ExecuteReader()
        db.Close()
        'MessageBox.Show("Producto agregado con exito")
    End Sub
    Public Sub add_abono()
        Dim db As New SqlClient.SqlConnection()
        Dim cm As New SqlClient.SqlCommand
        db.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev"
        cm.Connection = db
        cm.Connection.Open()
        If codCliente <> Nothing Then
            cm.CommandText = "insert into dbo.[DETALLE-PAGO] (cod_tarjeta, cod_formapago, valor) values (" & codCliente & "," & codFormaPago & "," & abono & ")"
        ElseIf codMesa <> Nothing Then
            cm.CommandText = "insert into dbo.[DETALLE-PAGO2] (cod_mesa, cod_formapago, valor, status) values (" & codMesa & "," & codFormaPago & ",(" & abono & "), 'A')"
        End If
        cm.ExecuteReader()
        db.Close()
    End Sub
    Public Sub cerrar_cuenta()
        Dim db As New SqlClient.SqlConnection()
        Dim cm As New SqlClient.SqlCommand
        db.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev"
        cm.Connection = db
        cm.Connection.Open()
        If codCliente <> Nothing Then
            cm.CommandText = "update dbo.tarjeta set status= 'X' where codigo = " & codCliente
            cm.ExecuteReader()
            db.Close()
            MessageBox.Show("Cuenta cerrada con exito")
        ElseIf codMesa <> Nothing Then
            cm.CommandText = "update dbo.consumo2 set status= 'X' where cod_mesa = " & codMesa
            cm.ExecuteReader()
            db.Close()
        End If
    End Sub
    Public Sub cerrar_cuenta2()
        Dim db As New SqlClient.SqlConnection()
        Dim cm As New SqlClient.SqlCommand
        db.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev"
        cm.Connection = db
        cm.Connection.Open()
        cm.CommandText = "update dbo.[DETALLE-PAGO2] set status= 'X' where cod_mesa = " & codMesa
        cm.ExecuteReader()
        db.Close()
        MessageBox.Show("Cuenta cerrada con exito")
    End Sub
    Public Sub add_tarjeta()
        Dim db As New SqlClient.SqlConnection()
        Dim cm As New SqlClient.SqlCommand
        db.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev"
        cm.Connection = db
        cm.Connection.Open()
        cm.CommandText = "insert into dbo.TARJETA (codigo, nombre, fecha, hombres, mujeres, status) values (" & numtarjeta & ",'" & nombreCliente & "','" & fechaCliente & "'," & hombresCliente & "," & mujeresCliente & ",'A')"
        cm.ExecuteReader()
        db.Close()
        MessageBox.Show("Cliente creado con exito")
    End Sub
    Public Sub carga_Grupo()
        Dim db As New SqlClient.SqlConnection()
        Dim da As New SqlClient.SqlDataAdapter
        Dim cm As New SqlClient.SqlCommand
        db.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev"
        cm.Connection = db
        cm.Connection.Open()
        cm.CommandText = "SELECT codigo, descripcion FROM GRUPOS WHERE (status = 'A') ORDER BY orden"
        cm.ExecuteReader()
        db.Close()
        'MessageBox.Show("Cliente creado con exito")
    End Sub
    Public Sub carga_consumo()
        cmSelectConsumo.Connection = cnBarDisco2
        cmSelectConsumo.Connection.Open()
        cmSelectConsumo.Parameters.Add(New SqlClient.SqlParameter("@codtarjeta", SqlDbType.Int))
        cmSelectConsumo.Parameters("@codtarjeta").Value = codCliente
        daConsumo.SelectCommand = cmSelectConsumo
        cmSelectConsumo.Connection.Close()
        dsConsumo.Tables.Clear()
        dsConsumo.Tables.Add(New DataTable("Consumo"))
        dsConsumo.Tables(0).BeginLoadData()
        daConsumo.Fill(dsConsumo, "Consumo")
        dsConsumo.Tables(0).EndLoadData()
        cmSelectConsumo.Parameters.Clear()
    End Sub
    Public Sub carga_consumomesa()
        cmSelectConsumoMesa.Connection = cnBarDisco2
        cmSelectConsumoMesa.Connection.Open()
        cmSelectConsumoMesa.Parameters.Add(New SqlClient.SqlParameter("@codmesa", SqlDbType.Int))
        cmSelectConsumoMesa.Parameters("@codmesa").Value = codMesa
        daConsumo.SelectCommand = cmSelectConsumoMesa
        cmSelectConsumoMesa.Connection.Close()
        dsConsumo.Tables.Clear()
        dsConsumo.Tables.Add(New DataTable("Consumo"))
        dsConsumo.Tables(0).BeginLoadData()
        daConsumo.Fill(dsConsumo, "Consumo")
        dsConsumo.Tables(0).EndLoadData()
        cmSelectConsumoMesa.Parameters.Clear()
    End Sub
    Public Sub detalle_pago()
        cmSelectDetallePago.Connection = cnBarDisco2
        cmSelectDetallePago.Connection.Open()
        cmSelectDetallePago.Parameters.Add(New SqlClient.SqlParameter("@codigo", SqlDbType.Int))
        cmSelectDetallePago.Parameters("@codigo").Value = codCliente
        daDetallePago.SelectCommand = cmSelectDetallePago
        cmSelectDetallePago.Connection.Close()
        dsDetallePago.Tables.Clear()
        dsDetallePago.Tables.Add(New DataTable("DetallePagos"))
        dsDetallePago.Tables(0).BeginLoadData()
        daDetallePago.Fill(dsDetallePago, "DetallePagos")
        dsDetallePago.Tables(0).EndLoadData()
        cmSelectDetallePago.Parameters.Clear()
    End Sub
    Public Sub detalle_pago2()
        cmSelectDetallePago2.Connection = cnBarDisco2
        cmSelectDetallePago2.Connection.Open()
        cmSelectDetallePago2.Parameters.Add(New SqlClient.SqlParameter("@codigo", SqlDbType.Int))
        cmSelectDetallePago2.Parameters("@codigo").Value = codMesa
        daDetallePago.SelectCommand = cmSelectDetallePago2
        cmSelectDetallePago2.Connection.Close()
        dsDetallePago.Tables.Clear()
        dsDetallePago.Tables.Add(New DataTable("DetallePagos"))
        dsDetallePago.Tables(0).BeginLoadData()
        daDetallePago.Fill(dsDetallePago, "DetallePagos")
        dsDetallePago.Tables(0).EndLoadData()
        cmSelectDetallePago2.Parameters.Clear()
    End Sub
    'Public Sub elimina_temprep()
    '    cmDeleteTempRep.Connection = cnBarDisco2
    '    cmDeleteTempRep.Connection.Open()
    '    daDetallePago.SelectCommand = cmDeleteTempRep
    '    cmDeleteTempRep.Connection.Close()
    'End Sub
    Public Sub elimina_consumo()
        Dim db As New SqlClient.SqlConnection()
        Dim cm As New SqlClient.SqlCommand
        db.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev"
        cm.Connection = db
        cm.Connection.Open()
        If codCliente <> Nothing Then
            cm.CommandText = "update dbo.consumo set status= 'E' where codigo = " & codConsumo
            cm.ExecuteReader()
            db.Close()
            MessageBox.Show("Consumo eliminado con exito")
        ElseIf codMesa <> Nothing Then
            cm.CommandText = "update dbo.consumo2 set status= 'E' where codigo = " & codConsumo
            cm.ExecuteReader()
            db.Close()
            MessageBox.Show("Consumo eliminado con exito")
        End If

    End Sub
    Public Sub cortesia()
        Dim db As New SqlClient.SqlConnection()
        Dim cm As New SqlClient.SqlCommand
        db.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev"
        cm.Connection = db
        cm.Connection.Open()
        If codCliente <> Nothing Then
            cm.CommandText = "update dbo.consumo set status= 'C' where codigo = " & codConsumo
            cm.ExecuteReader()
            db.Close()
            MessageBox.Show("Se establecio producto como cortesia")
        ElseIf codMesa <> Nothing Then
            cm.CommandText = "update dbo.consumo2 set status= 'C' where codigo = " & codConsumo
            cm.ExecuteReader()
            db.Close()
            MessageBox.Show("Se establecio producto como cortesia")
        End If

    End Sub
End Class


