Module Module1
    Public codMesero As Integer
    Public codCliente As Integer
    Public codMesa As Integer
    Public codGrupo As Integer
    Public codClase As Integer
    Public codTipo As Integer
    Public codSubTipo As Integer
    Public cantidadProd As Integer
    Public codFormaPago As Integer
    Public abono As Double
    Public saldo As Double
    Public abonado As Double
    Public nombreCliente As String
    Public fechaCliente As String
    Public hombresCliente As Integer
    Public mujeresCliente As Integer
    Public formaPagoCliente As Integer
    Public valorCliente As Double
    Public numtarjeta As Integer
    Public codConsumo As Integer
    Public temp As Integer
    Public descuento As Double

    Public cnBarDisco2 As New SqlClient.SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev")

    Public daTarjeta As New SqlClient.SqlDataAdapter
    Public cmSelectTarjeta As New SqlClient.SqlCommand("SELECT codigo FROM TARJETA WHERE (status = 'A') ORDER BY codigo")
    Public dsTarjetas As New DataSet
    Public daConsumo As New SqlClient.SqlDataAdapter
    Public cmSelectConsumo As New SqlClient.SqlCommand("SELECT consumo.codigo as Codigo, CONSUMO.cantidad as Cantidad, [SUB-TIPO].descripcion as SubTipo, TIPO.descripcion as Producto, [SUB-TIPO].pvp as Precio, (CONSUMO.cantidad * [SUB-TIPO].pvp) as Total FROM  CONSUMO INNER JOIN TIPO ON CONSUMO.cod_tipo = TIPO.codigo INNER JOIN [SUB-TIPO] ON CONSUMO.cod_subtipo = [SUB-TIPO].codigo AND TIPO.codigo = [SUB-TIPO].cod_tipo where (CONSUMO.cod_tarjeta = @codtarjeta and (consumo.status = 'A' or consumo.status = 'C'))")
    Public cmSelectConsumoMesa As New SqlClient.SqlCommand("SELECT consumo2.codigo as Codigo, CONSUMO2.cantidad as Cantidad, [SUB-TIPO].descripcion as SubTipo, TIPO.descripcion as Producto, [SUB-TIPO].pvp as Precio, (CONSUMO2.cantidad * [SUB-TIPO].pvp) as Total, consumo2.status as estado FROM  CONSUMO2 INNER JOIN TIPO ON CONSUMO2.cod_tipo = TIPO.codigo INNER JOIN [SUB-TIPO] ON CONSUMO2.cod_subtipo = [SUB-TIPO].codigo AND TIPO.codigo = [SUB-TIPO].cod_tipo where (CONSUMO2.cod_mesa = @codmesa and (consumo2.status = 'A' or consumo2.status = 'C'))")
    Public dsConsumo As New DataSet
    Public daGrupo As New SqlClient.SqlDataAdapter
    Public cmSelectGrupo As New SqlClient.SqlCommand("SELECT codigo, descripcion FROM GRUPOS WHERE (status = 'A') ORDER BY orden")
    Public dsGrupo As New DataSet
    Public daClase As New SqlClient.SqlDataAdapter
    Public cmSelectClase As New SqlClient.SqlCommand("SELECT codigo, descripcion FROM CLASE WHERE (cod_grupo= @codigo and (status = 'A')) ORDER BY codigo")
    Public dsClase As New DataSet
    Public daTipo As New SqlClient.SqlDataAdapter
    Public cmSelectTipo As New SqlClient.SqlCommand("SELECT codigo, descripcion FROM TIPO WHERE (cod_clase= @codigo and (status = 'A')) ORDER BY codigo")
    Public dsTipo As New DataSet
    Public daSubTipo As New SqlClient.SqlDataAdapter
    Public cmSelectSubTipo As New SqlClient.SqlCommand("SELECT codigo, descripcion FROM [SUB-TIPO] WHERE (cod_tipo= @codigo and (status = 'A')) ORDER BY codigo")
    Public dsSubTipo As New DataSet
    Public daDetallePago As New SqlClient.SqlDataAdapter
    Public cmSelectDetallePago As New SqlClient.SqlCommand("SELECT [DETALLE-PAGO].codigo as Codigo, [FORMA-PAGO].descripcion as Descripcion, [DETALLE-PAGO].valor as Valor FROM [DETALLE-PAGO] INNER JOIN [FORMA-PAGO] ON [DETALLE-PAGO].cod_formapago = [FORMA-PAGO].codigo where [DETALLE-PAGO].cod_tarjeta = @codigo ")
    Public cmSelectDetallePago2 As New SqlClient.SqlCommand("SELECT [DETALLE-PAGO2].codigo as Codigo, [FORMA-PAGO].descripcion as Descripcion, [DETALLE-PAGO2].valor as Valor FROM [DETALLE-PAGO2] INNER JOIN [FORMA-PAGO] ON [DETALLE-PAGO2].cod_formapago = [FORMA-PAGO].codigo where ([DETALLE-PAGO2].cod_mesa = @codigo and [DETALLE-PAGO2].status= 'A')")
    Public dsDetallePago As New DataSet
    Public daDeleteTempRep As New SqlClient.SqlDataAdapter
    Public cmDeleteTempRep As New SqlClient.SqlCommand("DELETE * FROM [TEMP-REPORTES] where status = 'A'")


    'Seccion de Canchas
    Public cnReservaCanchas As New SqlClient.SqlConnection("Data Source=.\sqlexpress;Initial Catalog=ReservaCanchas;Persist Security Info=True;User ID=sa;Password=gotechdev")

    Public daReservas As New SqlClient.SqlDataAdapter
    Public cmSelectReservas As New SqlClient.SqlCommand("SELECT codigo FROM TARJETA WHERE (status = 'A') ORDER BY codigo")
    Public dsReservas As New DataSet


End Module
