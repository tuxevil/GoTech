<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoCliente
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbNombre = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbHombres = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbMujeres = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.FORMAPAGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsFormaConsumo = New RestoBar_Manager.dsFormaConsumo
        Me.btGrabar = New System.Windows.Forms.Button
        Me.btSalir = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.tbNumTarjeta = New System.Windows.Forms.TextBox
        Me.FORMA_PAGOTableAdapter = New RestoBar_Manager.dsFormaConsumoTableAdapters.FORMA_PAGOTableAdapter
        CType(Me.FORMAPAGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFormaConsumo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero de Tarjeta"
        '
        'tbNombre
        '
        Me.tbNombre.BackColor = System.Drawing.Color.Black
        Me.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.ForeColor = System.Drawing.Color.White
        Me.tbNombre.Location = New System.Drawing.Point(152, 68)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(220, 26)
        Me.tbNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha:"
        '
        'tbHombres
        '
        Me.tbHombres.BackColor = System.Drawing.Color.Black
        Me.tbHombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHombres.ForeColor = System.Drawing.Color.White
        Me.tbHombres.Location = New System.Drawing.Point(152, 132)
        Me.tbHombres.Name = "tbHombres"
        Me.tbHombres.Size = New System.Drawing.Size(83, 26)
        Me.tbHombres.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hombres:"
        '
        'tbMujeres
        '
        Me.tbMujeres.BackColor = System.Drawing.Color.Black
        Me.tbMujeres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMujeres.ForeColor = System.Drawing.Color.White
        Me.tbMujeres.Location = New System.Drawing.Point(152, 164)
        Me.tbMujeres.Name = "tbMujeres"
        Me.tbMujeres.Size = New System.Drawing.Size(83, 26)
        Me.tbMujeres.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Mujeres:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.CalendarForeColor = System.Drawing.Color.White
        Me.dtpFecha.CalendarMonthBackground = System.Drawing.Color.Black
        Me.dtpFecha.CalendarTitleBackColor = System.Drawing.Color.Gray
        Me.dtpFecha.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(152, 102)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 15
        '
        'FORMAPAGOBindingSource
        '
        Me.FORMAPAGOBindingSource.DataMember = "FORMA-PAGO"
        Me.FORMAPAGOBindingSource.DataSource = Me.DsFormaConsumo
        '
        'DsFormaConsumo
        '
        Me.DsFormaConsumo.DataSetName = "dsFormaConsumo"
        Me.DsFormaConsumo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btGrabar
        '
        Me.btGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGrabar.Location = New System.Drawing.Point(60, 212)
        Me.btGrabar.Name = "btGrabar"
        Me.btGrabar.Size = New System.Drawing.Size(92, 28)
        Me.btGrabar.TabIndex = 17
        Me.btGrabar.Text = "GRABAR"
        Me.btGrabar.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.Location = New System.Drawing.Point(220, 212)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(92, 28)
        Me.btSalir.TabIndex = 18
        Me.btSalir.Text = "VOLVER"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(367, 33)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Ingreso de Nuevo Cliente"
        '
        'tbNumTarjeta
        '
        Me.tbNumTarjeta.BackColor = System.Drawing.Color.Black
        Me.tbNumTarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNumTarjeta.ForeColor = System.Drawing.Color.White
        Me.tbNumTarjeta.Location = New System.Drawing.Point(152, 36)
        Me.tbNumTarjeta.Name = "tbNumTarjeta"
        Me.tbNumTarjeta.Size = New System.Drawing.Size(83, 26)
        Me.tbNumTarjeta.TabIndex = 1
        '
        'FORMA_PAGOTableAdapter
        '
        Me.FORMA_PAGOTableAdapter.ClearBeforeFill = True
        '
        'NuevoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 256)
        Me.Controls.Add(Me.tbNumTarjeta)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.btGrabar)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.tbMujeres)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbHombres)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "NuevoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Cliente"
        CType(Me.FORMAPAGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFormaConsumo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbHombres As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbMujeres As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btGrabar As System.Windows.Forms.Button
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbNumTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents DsFormaConsumo As RestoBar_Manager.dsFormaConsumo
    Friend WithEvents FORMAPAGOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FORMA_PAGOTableAdapter As RestoBar_Manager.dsFormaConsumoTableAdapters.FORMA_PAGOTableAdapter
End Class
