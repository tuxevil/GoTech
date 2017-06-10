<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mod_Productos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Grupos = New System.Windows.Forms.TabPage
        Me.btElimGrupo = New System.Windows.Forms.Button
        Me.btModGrupo = New System.Windows.Forms.Button
        Me.btNuevoGrupo = New System.Windows.Forms.Button
        Me.dgvGrupo = New System.Windows.Forms.DataGridView
        Me.Clase = New System.Windows.Forms.TabPage
        Me.dgvClase = New System.Windows.Forms.DataGridView
        Me.btElimClase = New System.Windows.Forms.Button
        Me.btModClase = New System.Windows.Forms.Button
        Me.btNuevoClase = New System.Windows.Forms.Button
        Me.Producto = New System.Windows.Forms.TabPage
        Me.dgvTipo = New System.Windows.Forms.DataGridView
        Me.btElimProducto = New System.Windows.Forms.Button
        Me.btModProducto = New System.Windows.Forms.Button
        Me.btNuevoProducto = New System.Windows.Forms.Button
        Me.SubTipo = New System.Windows.Forms.TabPage
        Me.dgvSubTipo = New System.Windows.Forms.DataGridView
        Me.btElimSubTipo = New System.Windows.Forms.Button
        Me.btModSubTipo = New System.Windows.Forms.Button
        Me.btNuevoSubTipo = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbGrupo = New System.Windows.Forms.Label
        Me.lbClase = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbProducto = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbSubtipo = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbDescripcion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbCosto = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbPVP = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.Grupos.SuspendLayout()
        CType(Me.dgvGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Clase.SuspendLayout()
        CType(Me.dgvClase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Producto.SuspendLayout()
        CType(Me.dgvTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SubTipo.SuspendLayout()
        CType(Me.dgvSubTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Grupos)
        Me.TabControl1.Controls.Add(Me.Clase)
        Me.TabControl1.Controls.Add(Me.Producto)
        Me.TabControl1.Controls.Add(Me.SubTipo)
        Me.TabControl1.Location = New System.Drawing.Point(12, 46)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(378, 260)
        Me.TabControl1.TabIndex = 0
        '
        'Grupos
        '
        Me.Grupos.Controls.Add(Me.btElimGrupo)
        Me.Grupos.Controls.Add(Me.btModGrupo)
        Me.Grupos.Controls.Add(Me.btNuevoGrupo)
        Me.Grupos.Controls.Add(Me.dgvGrupo)
        Me.Grupos.Location = New System.Drawing.Point(4, 22)
        Me.Grupos.Name = "Grupos"
        Me.Grupos.Padding = New System.Windows.Forms.Padding(3)
        Me.Grupos.Size = New System.Drawing.Size(370, 234)
        Me.Grupos.TabIndex = 0
        Me.Grupos.Text = "Grupos"
        Me.Grupos.UseVisualStyleBackColor = True
        '
        'btElimGrupo
        '
        Me.btElimGrupo.Location = New System.Drawing.Point(279, 204)
        Me.btElimGrupo.Name = "btElimGrupo"
        Me.btElimGrupo.Size = New System.Drawing.Size(88, 23)
        Me.btElimGrupo.TabIndex = 11
        Me.btElimGrupo.Text = "Eliminar"
        Me.btElimGrupo.UseVisualStyleBackColor = True
        '
        'btModGrupo
        '
        Me.btModGrupo.Location = New System.Drawing.Point(279, 32)
        Me.btModGrupo.Name = "btModGrupo"
        Me.btModGrupo.Size = New System.Drawing.Size(88, 23)
        Me.btModGrupo.TabIndex = 10
        Me.btModGrupo.Text = "Modificar"
        Me.btModGrupo.UseVisualStyleBackColor = True
        '
        'btNuevoGrupo
        '
        Me.btNuevoGrupo.Location = New System.Drawing.Point(279, 3)
        Me.btNuevoGrupo.Name = "btNuevoGrupo"
        Me.btNuevoGrupo.Size = New System.Drawing.Size(88, 23)
        Me.btNuevoGrupo.TabIndex = 9
        Me.btNuevoGrupo.Text = "Grabar Nuevo"
        Me.btNuevoGrupo.UseVisualStyleBackColor = True
        '
        'dgvGrupo
        '
        Me.dgvGrupo.AllowUserToAddRows = False
        Me.dgvGrupo.AllowUserToDeleteRows = False
        Me.dgvGrupo.AllowUserToResizeColumns = False
        Me.dgvGrupo.AllowUserToResizeRows = False
        Me.dgvGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrupo.ColumnHeadersVisible = False
        Me.dgvGrupo.Location = New System.Drawing.Point(3, 3)
        Me.dgvGrupo.Name = "dgvGrupo"
        Me.dgvGrupo.ReadOnly = True
        Me.dgvGrupo.RowHeadersVisible = False
        Me.dgvGrupo.Size = New System.Drawing.Size(170, 227)
        Me.dgvGrupo.TabIndex = 8
        '
        'Clase
        '
        Me.Clase.Controls.Add(Me.dgvClase)
        Me.Clase.Controls.Add(Me.btElimClase)
        Me.Clase.Controls.Add(Me.btModClase)
        Me.Clase.Controls.Add(Me.btNuevoClase)
        Me.Clase.Location = New System.Drawing.Point(4, 22)
        Me.Clase.Name = "Clase"
        Me.Clase.Padding = New System.Windows.Forms.Padding(3)
        Me.Clase.Size = New System.Drawing.Size(370, 234)
        Me.Clase.TabIndex = 1
        Me.Clase.Text = "Clase"
        Me.Clase.UseVisualStyleBackColor = True
        '
        'dgvClase
        '
        Me.dgvClase.AllowUserToAddRows = False
        Me.dgvClase.AllowUserToDeleteRows = False
        Me.dgvClase.AllowUserToResizeColumns = False
        Me.dgvClase.AllowUserToResizeRows = False
        Me.dgvClase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClase.ColumnHeadersVisible = False
        Me.dgvClase.Location = New System.Drawing.Point(3, 3)
        Me.dgvClase.Name = "dgvClase"
        Me.dgvClase.ReadOnly = True
        Me.dgvClase.RowHeadersVisible = False
        Me.dgvClase.Size = New System.Drawing.Size(270, 227)
        Me.dgvClase.TabIndex = 15
        '
        'btElimClase
        '
        Me.btElimClase.Location = New System.Drawing.Point(279, 204)
        Me.btElimClase.Name = "btElimClase"
        Me.btElimClase.Size = New System.Drawing.Size(88, 23)
        Me.btElimClase.TabIndex = 14
        Me.btElimClase.Text = "Eliminar"
        Me.btElimClase.UseVisualStyleBackColor = True
        '
        'btModClase
        '
        Me.btModClase.Location = New System.Drawing.Point(279, 32)
        Me.btModClase.Name = "btModClase"
        Me.btModClase.Size = New System.Drawing.Size(88, 23)
        Me.btModClase.TabIndex = 13
        Me.btModClase.Text = "Modificar"
        Me.btModClase.UseVisualStyleBackColor = True
        '
        'btNuevoClase
        '
        Me.btNuevoClase.Location = New System.Drawing.Point(279, 3)
        Me.btNuevoClase.Name = "btNuevoClase"
        Me.btNuevoClase.Size = New System.Drawing.Size(88, 23)
        Me.btNuevoClase.TabIndex = 12
        Me.btNuevoClase.Text = "Grabar Nuevo"
        Me.btNuevoClase.UseVisualStyleBackColor = True
        '
        'Producto
        '
        Me.Producto.Controls.Add(Me.dgvTipo)
        Me.Producto.Controls.Add(Me.btElimProducto)
        Me.Producto.Controls.Add(Me.btModProducto)
        Me.Producto.Controls.Add(Me.btNuevoProducto)
        Me.Producto.Location = New System.Drawing.Point(4, 22)
        Me.Producto.Name = "Producto"
        Me.Producto.Size = New System.Drawing.Size(370, 234)
        Me.Producto.TabIndex = 2
        Me.Producto.Text = "Producto"
        Me.Producto.UseVisualStyleBackColor = True
        '
        'dgvTipo
        '
        Me.dgvTipo.AllowUserToAddRows = False
        Me.dgvTipo.AllowUserToDeleteRows = False
        Me.dgvTipo.AllowUserToResizeColumns = False
        Me.dgvTipo.AllowUserToResizeRows = False
        Me.dgvTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTipo.ColumnHeadersVisible = False
        Me.dgvTipo.Location = New System.Drawing.Point(3, 3)
        Me.dgvTipo.Name = "dgvTipo"
        Me.dgvTipo.ReadOnly = True
        Me.dgvTipo.RowHeadersVisible = False
        Me.dgvTipo.Size = New System.Drawing.Size(270, 227)
        Me.dgvTipo.TabIndex = 15
        '
        'btElimProducto
        '
        Me.btElimProducto.Location = New System.Drawing.Point(279, 204)
        Me.btElimProducto.Name = "btElimProducto"
        Me.btElimProducto.Size = New System.Drawing.Size(88, 23)
        Me.btElimProducto.TabIndex = 14
        Me.btElimProducto.Text = "Eliminar"
        Me.btElimProducto.UseVisualStyleBackColor = True
        '
        'btModProducto
        '
        Me.btModProducto.Location = New System.Drawing.Point(279, 32)
        Me.btModProducto.Name = "btModProducto"
        Me.btModProducto.Size = New System.Drawing.Size(88, 23)
        Me.btModProducto.TabIndex = 13
        Me.btModProducto.Text = "Modificar"
        Me.btModProducto.UseVisualStyleBackColor = True
        '
        'btNuevoProducto
        '
        Me.btNuevoProducto.Location = New System.Drawing.Point(279, 3)
        Me.btNuevoProducto.Name = "btNuevoProducto"
        Me.btNuevoProducto.Size = New System.Drawing.Size(88, 23)
        Me.btNuevoProducto.TabIndex = 12
        Me.btNuevoProducto.Text = "Grabar Nuevo"
        Me.btNuevoProducto.UseVisualStyleBackColor = True
        '
        'SubTipo
        '
        Me.SubTipo.Controls.Add(Me.dgvSubTipo)
        Me.SubTipo.Controls.Add(Me.btElimSubTipo)
        Me.SubTipo.Controls.Add(Me.btModSubTipo)
        Me.SubTipo.Controls.Add(Me.btNuevoSubTipo)
        Me.SubTipo.Location = New System.Drawing.Point(4, 22)
        Me.SubTipo.Name = "SubTipo"
        Me.SubTipo.Size = New System.Drawing.Size(370, 234)
        Me.SubTipo.TabIndex = 3
        Me.SubTipo.Text = "SubTipo"
        Me.SubTipo.UseVisualStyleBackColor = True
        '
        'dgvSubTipo
        '
        Me.dgvSubTipo.AllowUserToAddRows = False
        Me.dgvSubTipo.AllowUserToDeleteRows = False
        Me.dgvSubTipo.AllowUserToResizeColumns = False
        Me.dgvSubTipo.AllowUserToResizeRows = False
        Me.dgvSubTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubTipo.ColumnHeadersVisible = False
        Me.dgvSubTipo.Location = New System.Drawing.Point(3, 3)
        Me.dgvSubTipo.Name = "dgvSubTipo"
        Me.dgvSubTipo.ReadOnly = True
        Me.dgvSubTipo.RowHeadersVisible = False
        Me.dgvSubTipo.Size = New System.Drawing.Size(170, 227)
        Me.dgvSubTipo.TabIndex = 15
        '
        'btElimSubTipo
        '
        Me.btElimSubTipo.Location = New System.Drawing.Point(279, 204)
        Me.btElimSubTipo.Name = "btElimSubTipo"
        Me.btElimSubTipo.Size = New System.Drawing.Size(88, 23)
        Me.btElimSubTipo.TabIndex = 14
        Me.btElimSubTipo.Text = "Eliminar"
        Me.btElimSubTipo.UseVisualStyleBackColor = True
        '
        'btModSubTipo
        '
        Me.btModSubTipo.Location = New System.Drawing.Point(279, 32)
        Me.btModSubTipo.Name = "btModSubTipo"
        Me.btModSubTipo.Size = New System.Drawing.Size(88, 23)
        Me.btModSubTipo.TabIndex = 13
        Me.btModSubTipo.Text = "Modificar"
        Me.btModSubTipo.UseVisualStyleBackColor = True
        '
        'btNuevoSubTipo
        '
        Me.btNuevoSubTipo.Location = New System.Drawing.Point(279, 3)
        Me.btNuevoSubTipo.Name = "btNuevoSubTipo"
        Me.btNuevoSubTipo.Size = New System.Drawing.Size(88, 23)
        Me.btNuevoSubTipo.TabIndex = 12
        Me.btNuevoSubTipo.Text = "Grabar Nuevo"
        Me.btNuevoSubTipo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Grupo"
        '
        'lbGrupo
        '
        Me.lbGrupo.AutoSize = True
        Me.lbGrupo.Location = New System.Drawing.Point(9, 22)
        Me.lbGrupo.Name = "lbGrupo"
        Me.lbGrupo.Size = New System.Drawing.Size(0, 13)
        Me.lbGrupo.TabIndex = 2
        '
        'lbClase
        '
        Me.lbClase.AutoSize = True
        Me.lbClase.Location = New System.Drawing.Point(89, 22)
        Me.lbClase.Name = "lbClase"
        Me.lbClase.Size = New System.Drawing.Size(0, 13)
        Me.lbClase.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Clase"
        '
        'lbProducto
        '
        Me.lbProducto.AutoSize = True
        Me.lbProducto.Location = New System.Drawing.Point(173, 22)
        Me.lbProducto.Name = "lbProducto"
        Me.lbProducto.Size = New System.Drawing.Size(0, 13)
        Me.lbProducto.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(173, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Producto"
        '
        'lbSubtipo
        '
        Me.lbSubtipo.AutoSize = True
        Me.lbSubtipo.Location = New System.Drawing.Point(255, 22)
        Me.lbSubtipo.Name = "lbSubtipo"
        Me.lbSubtipo.Size = New System.Drawing.Size(0, 13)
        Me.lbSubtipo.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(255, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Subtipo"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDescripcion.Location = New System.Drawing.Point(396, 83)
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.tbDescripcion.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(393, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(393, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Costo"
        '
        'tbCosto
        '
        Me.tbCosto.Location = New System.Drawing.Point(396, 122)
        Me.tbCosto.Name = "tbCosto"
        Me.tbCosto.Size = New System.Drawing.Size(100, 20)
        Me.tbCosto.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(393, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Precio Venta Publico"
        '
        'tbPVP
        '
        Me.tbPVP.Location = New System.Drawing.Point(396, 161)
        Me.tbPVP.Name = "tbPVP"
        Me.tbPVP.Size = New System.Drawing.Size(100, 20)
        Me.tbPVP.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(502, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Solo SubTipo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(502, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Solo SubTipo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(393, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 15)
        Me.Label10.TabIndex = 17
        '
        'Mod_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 307)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbPVP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbCosto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbDescripcion)
        Me.Controls.Add(Me.lbSubtipo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbProducto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbClase)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbGrupo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Mod_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificacion de Productos"
        Me.TabControl1.ResumeLayout(False)
        Me.Grupos.ResumeLayout(False)
        CType(Me.dgvGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Clase.ResumeLayout(False)
        CType(Me.dgvClase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Producto.ResumeLayout(False)
        CType(Me.dgvTipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SubTipo.ResumeLayout(False)
        CType(Me.dgvSubTipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Grupos As System.Windows.Forms.TabPage
    Friend WithEvents Clase As System.Windows.Forms.TabPage
    Friend WithEvents Producto As System.Windows.Forms.TabPage
    Friend WithEvents SubTipo As System.Windows.Forms.TabPage
    Friend WithEvents dgvGrupo As System.Windows.Forms.DataGridView
    Friend WithEvents btElimGrupo As System.Windows.Forms.Button
    Friend WithEvents btModGrupo As System.Windows.Forms.Button
    Friend WithEvents btNuevoGrupo As System.Windows.Forms.Button
    Friend WithEvents btElimClase As System.Windows.Forms.Button
    Friend WithEvents btModClase As System.Windows.Forms.Button
    Friend WithEvents btNuevoClase As System.Windows.Forms.Button
    Friend WithEvents btElimProducto As System.Windows.Forms.Button
    Friend WithEvents btModProducto As System.Windows.Forms.Button
    Friend WithEvents btNuevoProducto As System.Windows.Forms.Button
    Friend WithEvents btElimSubTipo As System.Windows.Forms.Button
    Friend WithEvents btModSubTipo As System.Windows.Forms.Button
    Friend WithEvents btNuevoSubTipo As System.Windows.Forms.Button
    Friend WithEvents dgvClase As System.Windows.Forms.DataGridView
    Friend WithEvents dgvTipo As System.Windows.Forms.DataGridView
    Friend WithEvents dgvSubTipo As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbGrupo As System.Windows.Forms.Label
    Friend WithEvents lbClase As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbProducto As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbSubtipo As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbPVP As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
