Public Class Mod_Productos

    Private Sub Mod_Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmSelectGrupo.Connection = cnBarDisco2
        cmSelectGrupo.Connection.Open()
        daGrupo.SelectCommand = cmSelectGrupo
        cmSelectGrupo.Connection.Close()
        dsGrupo.Tables.Clear()
        dsGrupo.Tables.Add(New DataTable("Grupos"))
        dsGrupo.Tables(0).BeginLoadData()
        daGrupo.Fill(dsGrupo, "Grupos")
        dsGrupo.Tables(0).EndLoadData() '

        dgvGrupo.DataSource = dsGrupo.Tables(0).DefaultView
        dgvGrupo.Columns(0).Visible = False
    End Sub

    Private Sub dgvgrupo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrupo.CellClick
        codGrupo = dgvGrupo.Rows(e.RowIndex).Cells(0).Value
        lbGrupo.Text = dgvGrupo.Rows(e.RowIndex).Cells(1).Value
        tbDescripcion.Text = dgvGrupo.Rows(e.RowIndex).Cells(1).Value
        cmSelectClase.Connection = cnBarDisco2
        cmSelectClase.Connection.Open()
        cmSelectClase.Parameters.Add(New SqlClient.SqlParameter("@codigo", SqlDbType.Int))
        cmSelectClase.Parameters("@codigo").Value = codGrupo
        daClase.SelectCommand = cmSelectClase
        cmSelectClase.Connection.Close()
        dsClase.Tables.Clear()
        dsClase.Tables.Add(New DataTable("Clases"))
        dsClase.Tables(0).BeginLoadData()
        daClase.Fill(dsClase, "Clases")
        dsClase.Tables(0).EndLoadData()
        cmSelectClase.Parameters.Clear()
        dgvClase.DataSource = dsClase.Tables(0).DefaultView
        dgvClase.Columns(0).Visible = False
        dgvClase.Columns(1).Width = 250

        dgvTipo.DataSource = ""
        dgvSubTipo.DataSource = ""
        codClase = Nothing
        codTipo = Nothing
        codSubTipo = Nothing
        lbClase.Text = Nothing
        lbProducto.Text = Nothing
        lbSubtipo.Text = Nothing
        tbCosto.Text = Nothing
        tbPVP.Text = Nothing
    End Sub
    Private Sub dgvClase_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClase.CellClick
        codClase = dgvClase.Rows(e.RowIndex).Cells(0).Value
        lbClase.Text = dgvClase.Rows(e.RowIndex).Cells(1).Value
        tbDescripcion.Text = dgvClase.Rows(e.RowIndex).Cells(1).Value
        cmSelectTipo.Connection = cnBarDisco2
        cmSelectTipo.Connection.Open()
        cmSelectTipo.Parameters.Add(New SqlClient.SqlParameter("@codigo", SqlDbType.Int))
        cmSelectTipo.Parameters("@codigo").Value = codClase
        daTipo.SelectCommand = cmSelectTipo
        cmSelectTipo.Connection.Close()
        dsTipo.Tables.Clear()
        dsTipo.Tables.Add(New DataTable("Tipos"))
        dsTipo.Tables(0).BeginLoadData()
        daTipo.Fill(dsTipo, "Tipos")
        dsTipo.Tables(0).EndLoadData()
        cmSelectTipo.Parameters.Clear()
        dgvTipo.DataSource = dsTipo.Tables(0).DefaultView
        dgvTipo.Columns(0).Visible = False
        dgvTipo.Columns(1).Width = 250

        dgvSubTipo.DataSource = ""
        codTipo = Nothing
        codSubTipo = Nothing
        lbProducto.Text = Nothing
        lbSubtipo.Text = Nothing
        tbCosto.Text = Nothing
        tbPVP.Text = Nothing
    End Sub
    Private Sub dgvTipo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTipo.CellClick
        codTipo = dgvTipo.Rows(e.RowIndex).Cells(0).Value
        lbProducto.Text = dgvTipo.Rows(e.RowIndex).Cells(1).Value
        tbDescripcion.Text = dgvTipo.Rows(e.RowIndex).Cells(1).Value
        cmSelectSubTipo.Connection = cnBarDisco2
        cmSelectSubTipo.Connection.Open()
        cmSelectSubTipo.Parameters.Add(New SqlClient.SqlParameter("@codigo", SqlDbType.Int))
        cmSelectSubTipo.Parameters("@codigo").Value = codTipo
        daSubTipo.SelectCommand = cmSelectSubTipo
        cmSelectSubTipo.Connection.Close()
        dsSubTipo.Tables.Clear()
        dsSubTipo.Tables.Add(New DataTable("Subtipos"))
        dsSubTipo.Tables(0).BeginLoadData()
        daSubTipo.Fill(dsSubTipo, "Subtipos")
        dsSubTipo.Tables(0).EndLoadData()
        cmSelectSubTipo.Parameters.Clear()
        dgvSubTipo.DataSource = dsSubTipo.Tables(0).DefaultView
        dgvSubTipo.Columns(0).Visible = False
        dgvSubTipo.Columns(1).Width = 150

        codSubTipo = Nothing
        lbSubtipo.Text = Nothing
        tbCosto.Text = Nothing
        tbPVP.Text = Nothing
    End Sub
    Private Sub dgvSubTipo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSubTipo.CellClick
        codSubTipo = dgvSubTipo.Rows(e.RowIndex).Cells(0).Value
        lbSubtipo.Text = dgvSubTipo.Rows(e.RowIndex).Cells(1).Value
        tbDescripcion.Text = dgvSubTipo.Rows(e.RowIndex).Cells(1).Value
        Dim con0 As New SqlClient.SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev")
        Dim cmObtenerCostoPVP As New SqlClient.SqlCommand("select costo, pvp from [sub-tipo] where codigo=" & codSubTipo, con0)
        Dim drCostoPVP As SqlClient.SqlDataReader
        con0.Open()
        drCostoPVP = cmObtenerCostoPVP.ExecuteReader()
        drCostoPVP.Read()
        tbCosto.Text = drCostoPVP.Item(0)
        tbPVP.Text = drCostoPVP.Item(1)
    End Sub

    Private Sub btNuevoGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNuevoGrupo.Click
        Dim codnuevo As String
        Dim con0 As New SqlClient.SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev")
        Dim cmObtenerOrden As New SqlClient.SqlCommand("select orden from grupos order by orden desc", con0)
        Dim drOrden As SqlClient.SqlDataReader
        con0.Open()
        drOrden = cmObtenerOrden.ExecuteReader()
        drOrden.Read()

        codnuevo = drOrden.Item(0) + 1
        con0.Close()

        Dim cmNuevoGrupo As New SqlClient.SqlCommand("insert into grupos (descripcion, orden, status) values ('" & tbDescripcion.Text & "'," & codnuevo & ",'A')", con0)
        con0.Open()
        cmNuevoGrupo.ExecuteReader()
        con0.Close()

        cmSelectGrupo.Connection = cnBarDisco2
        cmSelectGrupo.Connection.Open()
        daGrupo.SelectCommand = cmSelectGrupo
        cmSelectGrupo.Connection.Close()
        dsGrupo.Tables.Clear()
        dsGrupo.Tables.Add(New DataTable("Grupos"))
        dsGrupo.Tables(0).BeginLoadData()
        daGrupo.Fill(dsGrupo, "Grupos")
        dsGrupo.Tables(0).EndLoadData() '

        dgvGrupo.DataSource = dsGrupo.Tables(0).DefaultView
        dgvGrupo.Columns(0).Visible = False
        tbDescripcion.Text = Nothing
        Label10.Text = "Grupo agregado con exito!"
        tbDescripcion.Focus()
    End Sub

    Private Sub btNuevoClase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNuevoClase.Click
        Dim con0 As New SqlClient.SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev")
        Dim cmNuevoClase As New SqlClient.SqlCommand("insert into clase (descripcion, status, cod_grupo) values ('" & tbDescripcion.Text & "','A'," & codGrupo & ")", con0)
        con0.Open()
        cmNuevoClase.ExecuteReader()
        con0.Close()

        cmSelectClase.Connection = cnBarDisco2
        cmSelectClase.Connection.Open()
        cmSelectClase.Parameters.Add(New SqlClient.SqlParameter("@codigo", SqlDbType.Int))
        cmSelectClase.Parameters("@codigo").Value = codGrupo
        daClase.SelectCommand = cmSelectClase
        cmSelectClase.Connection.Close()
        dsClase.Tables.Clear()
        dsClase.Tables.Add(New DataTable("Clases"))
        dsClase.Tables(0).BeginLoadData()
        daClase.Fill(dsClase, "Clases")
        dsClase.Tables(0).EndLoadData()
        cmSelectClase.Parameters.Clear()
        dgvClase.DataSource = dsClase.Tables(0).DefaultView
        dgvClase.Columns(0).Visible = False
        dgvClase.Columns(1).Width = 250

        dgvTipo.DataSource = ""
        dgvSubTipo.DataSource = ""
        codClase = Nothing
        codTipo = Nothing
        codSubTipo = Nothing
        lbClase.Text = Nothing
        lbProducto.Text = Nothing
        lbSubtipo.Text = Nothing
        tbDescripcion.Text = Nothing
        Label10.Text = "Clase agregado con exito!"
        tbDescripcion.Focus()
    End Sub

    Private Sub btNuevoProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNuevoProducto.Click
        Dim con0 As New SqlClient.SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev")
        Dim cmNuevoTipo As New SqlClient.SqlCommand("insert into tipo (descripcion, status, cod_clase) values ('" & tbDescripcion.Text & "','A'," & codClase & ")", con0)
        con0.Open()
        cmNuevoTipo.ExecuteReader()
        con0.Close()

        cmSelectTipo.Connection = cnBarDisco2
        cmSelectTipo.Connection.Open()
        cmSelectTipo.Parameters.Add(New SqlClient.SqlParameter("@codigo", SqlDbType.Int))
        cmSelectTipo.Parameters("@codigo").Value = codClase
        daTipo.SelectCommand = cmSelectTipo
        cmSelectTipo.Connection.Close()
        dsTipo.Tables.Clear()
        dsTipo.Tables.Add(New DataTable("Tipos"))
        dsTipo.Tables(0).BeginLoadData()
        daTipo.Fill(dsTipo, "Tipos")
        dsTipo.Tables(0).EndLoadData()
        cmSelectTipo.Parameters.Clear()
        dgvTipo.DataSource = dsTipo.Tables(0).DefaultView
        dgvTipo.Columns(0).Visible = False
        dgvTipo.Columns(1).Width = 250

        dgvSubTipo.DataSource = ""
        codTipo = Nothing
        codSubTipo = Nothing
        lbProducto.Text = Nothing
        lbSubtipo.Text = Nothing
        tbDescripcion.Text = Nothing
        Label10.Text = "Producto agregado con exito!"
        tbDescripcion.Focus()
    End Sub

    Private Sub btNuevoSubTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNuevoSubTipo.Click
        Dim con0 As New SqlClient.SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev")
        Dim cmNuevoSubTipo As New SqlClient.SqlCommand("insert into [sub-tipo] (descripcion, status, cod_tipo, costo, pvp) values ('" & tbDescripcion.Text & "','A'," & codTipo & ",'" & tbCosto.Text & "','" & tbPVP.Text & "')", con0)
        con0.Open()
        cmNuevoSubTipo.ExecuteReader()
        con0.Close()

        cmSelectSubTipo.Connection = cnBarDisco2
        cmSelectSubTipo.Connection.Open()
        cmSelectSubTipo.Parameters.Add(New SqlClient.SqlParameter("@codigo", SqlDbType.Int))
        cmSelectSubTipo.Parameters("@codigo").Value = codTipo
        daSubTipo.SelectCommand = cmSelectSubTipo
        cmSelectSubTipo.Connection.Close()
        dsSubTipo.Tables.Clear()
        dsSubTipo.Tables.Add(New DataTable("Subtipos"))
        dsSubTipo.Tables(0).BeginLoadData()
        daSubTipo.Fill(dsSubTipo, "Subtipos")
        dsSubTipo.Tables(0).EndLoadData()
        cmSelectSubTipo.Parameters.Clear()
        dgvSubTipo.DataSource = dsSubTipo.Tables(0).DefaultView
        dgvSubTipo.Columns(0).Visible = False
        dgvSubTipo.Columns(1).Width = 150

        codSubTipo = Nothing
        lbSubtipo.Text = Nothing
        tbDescripcion.Text = Nothing
        tbCosto.Text = Nothing
        tbPVP.Text = Nothing
        Label10.Text = "SubTipo agregado con exito!"
        tbDescripcion.Focus()
    End Sub

    Private Sub btModGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btModGrupo.Click
        Dim con0 As New SqlClient.SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev")
        Dim cmModGrupo As New SqlClient.SqlCommand("update grupos set descripcion='" & tbDescripcion.Text & "' where codigo=" & codGrupo, con0)
        con0.Open()
        cmModGrupo.ExecuteReader()
        con0.Close()

        cmSelectGrupo.Connection = cnBarDisco2
        cmSelectGrupo.Connection.Open()
        daGrupo.SelectCommand = cmSelectGrupo
        cmSelectGrupo.Connection.Close()
        dsGrupo.Tables.Clear()
        dsGrupo.Tables.Add(New DataTable("Grupos"))
        dsGrupo.Tables(0).BeginLoadData()
        daGrupo.Fill(dsGrupo, "Grupos")
        dsGrupo.Tables(0).EndLoadData() '

        dgvGrupo.DataSource = dsGrupo.Tables(0).DefaultView
        dgvGrupo.Columns(0).Visible = False
        tbDescripcion.Text = Nothing
        Label10.Text = "Grupo modificado con exito!"
        tbDescripcion.Focus()
    End Sub

    Private Sub btModClase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btModClase.Click
        Dim con0 As New SqlClient.SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev")
        Dim cmModClase As New SqlClient.SqlCommand("update clase set descripcion='" & tbDescripcion.Text & "' where codigo=" & codClase, con0)
        con0.Open()
        cmModClase.ExecuteReader()
        con0.Close()

        cmSelectClase.Connection = cnBarDisco2
        cmSelectClase.Connection.Open()
        cmSelectClase.Parameters.Add(New SqlClient.SqlParameter("@codigo", SqlDbType.Int))
        cmSelectClase.Parameters("@codigo").Value = codGrupo
        daClase.SelectCommand = cmSelectClase
        cmSelectClase.Connection.Close()
        dsClase.Tables.Clear()
        dsClase.Tables.Add(New DataTable("Clases"))
        dsClase.Tables(0).BeginLoadData()
        daClase.Fill(dsClase, "Clases")
        dsClase.Tables(0).EndLoadData()
        cmSelectClase.Parameters.Clear()
        dgvClase.DataSource = dsClase.Tables(0).DefaultView
        dgvClase.Columns(0).Visible = False
        dgvClase.Columns(1).Width = 250

        dgvTipo.DataSource = ""
        dgvSubTipo.DataSource = ""
        codClase = Nothing
        codTipo = Nothing
        codSubTipo = Nothing
        lbClase.Text = Nothing
        lbProducto.Text = Nothing
        lbSubtipo.Text = Nothing
        tbDescripcion.Text = Nothing
        Label10.Text = "Clase modificado con exito!"
        tbDescripcion.Focus()
    End Sub

    Private Sub btModProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btModProducto.Click
        Dim con0 As New SqlClient.SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev")
        Dim cmModTipo As New SqlClient.SqlCommand("update tipo set descripcion='" & tbDescripcion.Text & "' where codigo=" & codTipo, con0)
        con0.Open()
        cmModTipo.ExecuteReader()
        con0.Close()

        cmSelectTipo.Connection = cnBarDisco2
        cmSelectTipo.Connection.Open()
        cmSelectTipo.Parameters.Add(New SqlClient.SqlParameter("@codigo", SqlDbType.Int))
        cmSelectTipo.Parameters("@codigo").Value = codClase
        daTipo.SelectCommand = cmSelectTipo
        cmSelectTipo.Connection.Close()
        dsTipo.Tables.Clear()
        dsTipo.Tables.Add(New DataTable("Tipos"))
        dsTipo.Tables(0).BeginLoadData()
        daTipo.Fill(dsTipo, "Tipos")
        dsTipo.Tables(0).EndLoadData()
        cmSelectTipo.Parameters.Clear()
        dgvTipo.DataSource = dsTipo.Tables(0).DefaultView
        dgvTipo.Columns(0).Visible = False
        dgvTipo.Columns(1).Width = 250

        dgvSubTipo.DataSource = ""
        codTipo = Nothing
        codSubTipo = Nothing
        lbProducto.Text = Nothing
        lbSubtipo.Text = Nothing
        tbDescripcion.Text = Nothing
        Label10.Text = "Producto modificado con exito!"
        tbDescripcion.Focus()
    End Sub

    Private Sub btModSubTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btModSubTipo.Click
        Dim con0 As New SqlClient.SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev")
        Dim cmModSubTipo As New SqlClient.SqlCommand("update [sub-tipo] set descripcion='" & tbDescripcion.Text & "', costo='" & tbCosto.Text & "', pvp='" & tbPVP.Text & "' where codigo=" & codSubTipo, con0)
        con0.Open()
        cmModSubTipo.ExecuteReader()
        con0.Close()

        cmSelectSubTipo.Connection = cnBarDisco2
        cmSelectSubTipo.Connection.Open()
        cmSelectSubTipo.Parameters.Add(New SqlClient.SqlParameter("@codigo", SqlDbType.Int))
        cmSelectSubTipo.Parameters("@codigo").Value = codTipo
        daSubTipo.SelectCommand = cmSelectSubTipo
        cmSelectSubTipo.Connection.Close()
        dsSubTipo.Tables.Clear()
        dsSubTipo.Tables.Add(New DataTable("Subtipos"))
        dsSubTipo.Tables(0).BeginLoadData()
        daSubTipo.Fill(dsSubTipo, "Subtipos")
        dsSubTipo.Tables(0).EndLoadData()
        cmSelectSubTipo.Parameters.Clear()
        dgvSubTipo.DataSource = dsSubTipo.Tables(0).DefaultView
        dgvSubTipo.Columns(0).Visible = False
        dgvSubTipo.Columns(1).Width = 150

        codSubTipo = Nothing
        lbSubtipo.Text = Nothing
        tbDescripcion.Text = Nothing
        tbCosto.Text = Nothing
        tbPVP.Text = Nothing
        Label10.Text = "SubTipo modificado con exito!"
        tbDescripcion.Focus()
    End Sub

    Private Sub btElimGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btElimGrupo.Click
        Dim con0 As New SqlClient.SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev")
        Dim cmElimGrupo As New SqlClient.SqlCommand("update grupos set status='X' where codigo=" & codGrupo, con0)
        con0.Open()
        cmElimGrupo.ExecuteReader()
        con0.Close()

        cmSelectGrupo.Connection = cnBarDisco2
        cmSelectGrupo.Connection.Open()
        daGrupo.SelectCommand = cmSelectGrupo
        cmSelectGrupo.Connection.Close()
        dsGrupo.Tables.Clear()
        dsGrupo.Tables.Add(New DataTable("Grupos"))
        dsGrupo.Tables(0).BeginLoadData()
        daGrupo.Fill(dsGrupo, "Grupos")
        dsGrupo.Tables(0).EndLoadData() '

        dgvGrupo.DataSource = dsGrupo.Tables(0).DefaultView
        dgvGrupo.Columns(0).Visible = False
        tbDescripcion.Text = Nothing
        Label10.Text = "Grupo eliminado con exito!"
        tbDescripcion.Focus()
    End Sub

    Private Sub btElimClase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btElimClase.Click
        Dim con0 As New SqlClient.SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev")
        Dim cmElimClase As New SqlClient.SqlCommand("update clase set status='X' where codigo=" & codClase, con0)
        con0.Open()
        cmElimClase.ExecuteReader()
        con0.Close()

        cmSelectClase.Connection = cnBarDisco2
        cmSelectClase.Connection.Open()
        cmSelectClase.Parameters.Add(New SqlClient.SqlParameter("@codigo", SqlDbType.Int))
        cmSelectClase.Parameters("@codigo").Value = codGrupo
        daClase.SelectCommand = cmSelectClase
        cmSelectClase.Connection.Close()
        dsClase.Tables.Clear()
        dsClase.Tables.Add(New DataTable("Clases"))
        dsClase.Tables(0).BeginLoadData()
        daClase.Fill(dsClase, "Clases")
        dsClase.Tables(0).EndLoadData()
        cmSelectClase.Parameters.Clear()
        dgvClase.DataSource = dsClase.Tables(0).DefaultView
        dgvClase.Columns(0).Visible = False
        dgvClase.Columns(1).Width = 250

        dgvTipo.DataSource = ""
        dgvSubTipo.DataSource = ""
        codClase = Nothing
        codTipo = Nothing
        codSubTipo = Nothing
        lbClase.Text = Nothing
        lbProducto.Text = Nothing
        lbSubtipo.Text = Nothing
        tbDescripcion.Text = Nothing
        Label10.Text = "Clase eliminada con exito!"
        tbDescripcion.Focus()
    End Sub

    Private Sub btElimProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btElimProducto.Click
        Dim con0 As New SqlClient.SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev")
        Dim cmElimTipo As New SqlClient.SqlCommand("update tipo set status='X' where codigo=" & codTipo, con0)
        con0.Open()
        cmElimTipo.ExecuteReader()
        con0.Close()

        cmSelectTipo.Connection = cnBarDisco2
        cmSelectTipo.Connection.Open()
        cmSelectTipo.Parameters.Add(New SqlClient.SqlParameter("@codigo", SqlDbType.Int))
        cmSelectTipo.Parameters("@codigo").Value = codClase
        daTipo.SelectCommand = cmSelectTipo
        cmSelectTipo.Connection.Close()
        dsTipo.Tables.Clear()
        dsTipo.Tables.Add(New DataTable("Tipos"))
        dsTipo.Tables(0).BeginLoadData()
        daTipo.Fill(dsTipo, "Tipos")
        dsTipo.Tables(0).EndLoadData()
        cmSelectTipo.Parameters.Clear()
        dgvTipo.DataSource = dsTipo.Tables(0).DefaultView
        dgvTipo.Columns(0).Visible = False
        dgvTipo.Columns(1).Width = 250

        dgvSubTipo.DataSource = ""
        codTipo = Nothing
        codSubTipo = Nothing
        lbProducto.Text = Nothing
        lbSubtipo.Text = Nothing
        tbDescripcion.Text = Nothing
        Label10.Text = "Producto eliminado con exito!"
        tbDescripcion.Focus()
    End Sub

    Private Sub btElimSubTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btElimSubTipo.Click
        Dim con0 As New SqlClient.SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev")
        Dim cmElimSubTipo As New SqlClient.SqlCommand("update [sub-tipo] set status='X', costo='" & tbCosto.Text & "', pvp='" & tbPVP.Text & "' where codigo=" & codSubTipo, con0)
        con0.Open()
        cmElimSubTipo.ExecuteReader()
        con0.Close()

        cmSelectSubTipo.Connection = cnBarDisco2
        cmSelectSubTipo.Connection.Open()
        cmSelectSubTipo.Parameters.Add(New SqlClient.SqlParameter("@codigo", SqlDbType.Int))
        cmSelectSubTipo.Parameters("@codigo").Value = codTipo
        daSubTipo.SelectCommand = cmSelectSubTipo
        cmSelectSubTipo.Connection.Close()
        dsSubTipo.Tables.Clear()
        dsSubTipo.Tables.Add(New DataTable("Subtipos"))
        dsSubTipo.Tables(0).BeginLoadData()
        daSubTipo.Fill(dsSubTipo, "Subtipos")
        dsSubTipo.Tables(0).EndLoadData()
        cmSelectSubTipo.Parameters.Clear()
        dgvSubTipo.DataSource = dsSubTipo.Tables(0).DefaultView
        dgvSubTipo.Columns(0).Visible = False
        dgvSubTipo.Columns(1).Width = 150

        codSubTipo = Nothing
        lbSubtipo.Text = Nothing
        tbDescripcion.Text = Nothing
        tbCosto.Text = Nothing
        tbPVP.Text = Nothing
        Label10.Text = "SubTipo eliminado con exito!"
        tbDescripcion.Focus()
    End Sub
End Class