Public Class Modificar

    Private Sub Modificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim db As New SqlClient.SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev")
        Dim cm As New SqlClient.SqlCommand("SELECT [SUB-TIPO].descripcion, TIPO.descripcion AS Expr1, [SUB-TIPO].pvp FROM [SUB-TIPO] INNER JOIN TIPO ON [SUB-TIPO].cod_tipo = TIPO.codigo where [SUB-TIPO].codigo=" & codSubTipo, db)
        db.Open()
        Dim dr As SqlClient.SqlDataReader
        dr = cm.ExecuteReader()

        dr.Read()
        Label1.Text = dr.GetString(0) & " - " & dr.GetString(1)
        Label2.Text = "Precio actual: $ " & dr.GetDouble(2)

        dr.Close()
        db.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim db As New SqlClient.SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev")
        Dim cm As New SqlClient.SqlCommand("UPDATE [SUB-TIPO] set [SUB-TIPO].pvp= " & TextBox1.Text & " where [SUB-TIPO].codigo=" & codSubTipo, db)
        db.Open()
        Dim dr As SqlClient.SqlDataReader
        dr = cm.ExecuteReader()

        dr.Read()
        MessageBox.Show("Precio cambiado con exito")

        dr.Close()
        db.Close()
        Me.Close()

    End Sub
End Class