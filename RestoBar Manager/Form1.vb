'Cosas que faltan por hacer:
'   Poder eliminar productos ingresados por equivocacion de la base de datos y recargar la grilla pero con clave de autorizacion
'   


Imports System.Windows.Forms.DataGridView


Public Class Form1
    Inherits System.Windows.Forms.Form
    Friend WithEvents gbPagar As System.Windows.Forms.GroupBox
    Friend WithEvents btPagar As System.Windows.Forms.Button
    Friend WithEvents cbServicio As System.Windows.Forms.CheckBox
    Friend WithEvents cbIVA As System.Windows.Forms.CheckBox
    Friend WithEvents tbTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbServicio As System.Windows.Forms.TextBox
    Friend WithEvents tbIVA As System.Windows.Forms.TextBox
    Friend WithEvents tbSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btAnular As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents gbSelProds As System.Windows.Forms.GroupBox
    Friend WithEvents btAgregar As System.Windows.Forms.Button
    Friend WithEvents lbCantidad As System.Windows.Forms.ListBox
    Friend WithEvents dgvSubTipo As System.Windows.Forms.DataGridView
    Friend WithEvents dgvTipo As System.Windows.Forms.DataGridView
    Friend WithEvents dgvClase As System.Windows.Forms.DataGridView
    Friend WithEvents dgvGrupo As System.Windows.Forms.DataGridView
    Friend WithEvents gbConsumo As System.Windows.Forms.GroupBox
    Friend WithEvents CodtipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodsubtipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescsubtipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents btCancelarRestaurant As System.Windows.Forms.Button
    Friend WithEvents btCancelarBar As System.Windows.Forms.Button
    Friend WithEvents btNuevoBar As System.Windows.Forms.Button
    Friend WithEvents gbFormaPago As System.Windows.Forms.GroupBox
    Friend WithEvents tbSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CodformapagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents tbAbono As System.Windows.Forms.TextBox
    Friend WithEvents btTicket As System.Windows.Forms.Button
    Friend WithEvents CostoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btCerrarCuenta As System.Windows.Forms.Button
    Friend WithEvents CodmesaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsTarjetas As RestoBar_Manager.dsTarjetas
    Friend WithEvents TARJETABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dgvConsumo As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DsFormaPago As RestoBar_Manager.dsFormaPago
    Friend WithEvents FORMAPAGOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FORMA_PAGOTableAdapter As RestoBar_Manager.dsFormaPagoTableAdapters.FORMA_PAGOTableAdapter
    Friend WithEvents dgvDetallePago As System.Windows.Forms.DataGridView
    Friend WithEvents DsMesa As RestoBar_Manager.dsMesa
    Friend WithEvents MESABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MESATableAdapter As RestoBar_Manager.dsMesaTableAdapters.MESATableAdapter
    Friend WithEvents DsMesero As RestoBar_Manager.dsMesero
    Friend WithEvents MESEROBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MESEROTableAdapter As RestoBar_Manager.dsMeseroTableAdapters.MESEROTableAdapter
    Friend WithEvents btReportes As System.Windows.Forms.Button
    Friend WithEvents btEliminarConsumo As System.Windows.Forms.Button
    Friend WithEvents btCortesia As System.Windows.Forms.Button
    Friend WithEvents cbDescuento As System.Windows.Forms.CheckBox
    Friend WithEvents tbDescuento As System.Windows.Forms.TextBox
    Friend WithEvents tbDesc As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TARJETATableAdapter As RestoBar_Manager.dsTarjetasTableAdapters.TARJETATableAdapter





#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents OrdenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.gbPagar = New System.Windows.Forms.GroupBox
        Me.tbDesc = New System.Windows.Forms.TextBox
        Me.tbIVA = New System.Windows.Forms.TextBox
        Me.tbDescuento = New System.Windows.Forms.TextBox
        Me.cbDescuento = New System.Windows.Forms.CheckBox
        Me.btCerrarCuenta = New System.Windows.Forms.Button
        Me.btTicket = New System.Windows.Forms.Button
        Me.btAnular = New System.Windows.Forms.Button
        Me.btPagar = New System.Windows.Forms.Button
        Me.cbServicio = New System.Windows.Forms.CheckBox
        Me.cbIVA = New System.Windows.Forms.CheckBox
        Me.tbTotal = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbServicio = New System.Windows.Forms.TextBox
        Me.tbSubTotal = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btCancelarRestaurant = New System.Windows.Forms.Button
        Me.btCancelarBar = New System.Windows.Forms.Button
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.MESEROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMesero = New RestoBar_Manager.dsMesero
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.MESABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMesa = New RestoBar_Manager.dsMesa
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TARJETABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTarjetas = New RestoBar_Manager.dsTarjetas
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.gbSelProds = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btAgregar = New System.Windows.Forms.Button
        Me.lbCantidad = New System.Windows.Forms.ListBox
        Me.dgvSubTipo = New System.Windows.Forms.DataGridView
        Me.dgvTipo = New System.Windows.Forms.DataGridView
        Me.dgvClase = New System.Windows.Forms.DataGridView
        Me.dgvGrupo = New System.Windows.Forms.DataGridView
        Me.gbConsumo = New System.Windows.Forms.GroupBox
        Me.btCortesia = New System.Windows.Forms.Button
        Me.btEliminarConsumo = New System.Windows.Forms.Button
        Me.dgvConsumo = New System.Windows.Forms.DataGridView
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescsubtipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btSalir = New System.Windows.Forms.Button
        Me.btNuevoBar = New System.Windows.Forms.Button
        Me.gbFormaPago = New System.Windows.Forms.GroupBox
        Me.dgvDetallePago = New System.Windows.Forms.DataGridView
        Me.tbAbono = New System.Windows.Forms.TextBox
        Me.cbFormaPago = New System.Windows.Forms.ComboBox
        Me.FORMAPAGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsFormaPago = New RestoBar_Manager.dsFormaPago
        Me.tbSaldo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TARJETATableAdapter = New RestoBar_Manager.dsTarjetasTableAdapters.TARJETATableAdapter
        Me.FORMA_PAGOTableAdapter = New RestoBar_Manager.dsFormaPagoTableAdapters.FORMA_PAGOTableAdapter
        Me.MESATableAdapter = New RestoBar_Manager.dsMesaTableAdapters.MESATableAdapter
        Me.MESEROTableAdapter = New RestoBar_Manager.dsMeseroTableAdapters.MESEROTableAdapter
        Me.btReportes = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.gbPagar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MESEROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMesero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MESABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMesa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TARJETABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTarjetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSelProds.SuspendLayout()
        CType(Me.dgvSubTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvClase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbConsumo.SuspendLayout()
        CType(Me.dgvConsumo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFormaPago.SuspendLayout()
        CType(Me.dgvDetallePago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FORMAPAGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbPagar
        '
        Me.gbPagar.Controls.Add(Me.tbDesc)
        Me.gbPagar.Controls.Add(Me.tbIVA)
        Me.gbPagar.Controls.Add(Me.tbDescuento)
        Me.gbPagar.Controls.Add(Me.cbDescuento)
        Me.gbPagar.Controls.Add(Me.btCerrarCuenta)
        Me.gbPagar.Controls.Add(Me.btTicket)
        Me.gbPagar.Controls.Add(Me.btAnular)
        Me.gbPagar.Controls.Add(Me.btPagar)
        Me.gbPagar.Controls.Add(Me.cbServicio)
        Me.gbPagar.Controls.Add(Me.cbIVA)
        Me.gbPagar.Controls.Add(Me.tbTotal)
        Me.gbPagar.Controls.Add(Me.Label4)
        Me.gbPagar.Controls.Add(Me.tbServicio)
        Me.gbPagar.Controls.Add(Me.tbSubTotal)
        Me.gbPagar.Controls.Add(Me.Label1)
        Me.gbPagar.Enabled = False
        Me.gbPagar.Location = New System.Drawing.Point(600, 329)
        Me.gbPagar.Name = "gbPagar"
        Me.gbPagar.Size = New System.Drawing.Size(396, 213)
        Me.gbPagar.TabIndex = 8
        Me.gbPagar.TabStop = False
        Me.gbPagar.Text = "Total a Pagar"
        '
        'tbDesc
        '
        Me.tbDesc.BackColor = System.Drawing.Color.Black
        Me.tbDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDesc.ForeColor = System.Drawing.Color.White
        Me.tbDesc.Location = New System.Drawing.Point(192, 46)
        Me.tbDesc.Name = "tbDesc"
        Me.tbDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbDesc.Size = New System.Drawing.Size(63, 29)
        Me.tbDesc.TabIndex = 26
        Me.tbDesc.Text = "$ 0.00"
        Me.tbDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbIVA
        '
        Me.tbIVA.BackColor = System.Drawing.Color.Black
        Me.tbIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIVA.ForeColor = System.Drawing.Color.White
        Me.tbIVA.Location = New System.Drawing.Point(153, 73)
        Me.tbIVA.Name = "tbIVA"
        Me.tbIVA.ReadOnly = True
        Me.tbIVA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbIVA.Size = New System.Drawing.Size(102, 29)
        Me.tbIVA.TabIndex = 13
        Me.tbIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbDescuento
        '
        Me.tbDescuento.BackColor = System.Drawing.Color.Black
        Me.tbDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDescuento.ForeColor = System.Drawing.Color.White
        Me.tbDescuento.Location = New System.Drawing.Point(153, 46)
        Me.tbDescuento.Name = "tbDescuento"
        Me.tbDescuento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbDescuento.Size = New System.Drawing.Size(37, 29)
        Me.tbDescuento.TabIndex = 24
        Me.tbDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbDescuento
        '
        Me.cbDescuento.AutoSize = True
        Me.cbDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDescuento.Location = New System.Drawing.Point(9, 50)
        Me.cbDescuento.Name = "cbDescuento"
        Me.cbDescuento.Size = New System.Drawing.Size(152, 28)
        Me.cbDescuento.TabIndex = 25
        Me.cbDescuento.Text = "Descuento (%)"
        Me.cbDescuento.UseVisualStyleBackColor = True
        '
        'btCerrarCuenta
        '
        Me.btCerrarCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCerrarCuenta.Location = New System.Drawing.Point(271, 32)
        Me.btCerrarCuenta.Name = "btCerrarCuenta"
        Me.btCerrarCuenta.Size = New System.Drawing.Size(109, 81)
        Me.btCerrarCuenta.TabIndex = 23
        Me.btCerrarCuenta.Text = "CERRAR CUENTA"
        Me.btCerrarCuenta.UseVisualStyleBackColor = True
        Me.btCerrarCuenta.Visible = False
        '
        'btTicket
        '
        Me.btTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTicket.Location = New System.Drawing.Point(7, 170)
        Me.btTicket.Name = "btTicket"
        Me.btTicket.Size = New System.Drawing.Size(82, 26)
        Me.btTicket.TabIndex = 22
        Me.btTicket.Text = "TICKET"
        Me.btTicket.UseVisualStyleBackColor = True
        '
        'btAnular
        '
        Me.btAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAnular.Location = New System.Drawing.Point(228, 170)
        Me.btAnular.Name = "btAnular"
        Me.btAnular.Size = New System.Drawing.Size(60, 26)
        Me.btAnular.TabIndex = 21
        Me.btAnular.Text = "ANULAR"
        Me.btAnular.UseVisualStyleBackColor = True
        Me.btAnular.Visible = False
        '
        'btPagar
        '
        Me.btPagar.Enabled = False
        Me.btPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPagar.Location = New System.Drawing.Point(96, 157)
        Me.btPagar.Name = "btPagar"
        Me.btPagar.Size = New System.Drawing.Size(126, 53)
        Me.btPagar.TabIndex = 20
        Me.btPagar.Text = "DETALLE PAGO"
        Me.btPagar.UseVisualStyleBackColor = True
        '
        'cbServicio
        '
        Me.cbServicio.AutoSize = True
        Me.cbServicio.Checked = True
        Me.cbServicio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbServicio.Location = New System.Drawing.Point(9, 102)
        Me.cbServicio.Name = "cbServicio"
        Me.cbServicio.Size = New System.Drawing.Size(136, 28)
        Me.cbServicio.TabIndex = 19
        Me.cbServicio.Text = "Servicio 10%"
        Me.cbServicio.UseVisualStyleBackColor = True
        '
        'cbIVA
        '
        Me.cbIVA.AutoSize = True
        Me.cbIVA.Checked = True
        Me.cbIVA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIVA.Location = New System.Drawing.Point(9, 77)
        Me.cbIVA.Name = "cbIVA"
        Me.cbIVA.Size = New System.Drawing.Size(99, 28)
        Me.cbIVA.TabIndex = 18
        Me.cbIVA.Text = "IVA 12%"
        Me.cbIVA.UseVisualStyleBackColor = True
        '
        'tbTotal
        '
        Me.tbTotal.BackColor = System.Drawing.Color.Black
        Me.tbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotal.ForeColor = System.Drawing.Color.White
        Me.tbTotal.Location = New System.Drawing.Point(153, 125)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbTotal.Size = New System.Drawing.Size(102, 29)
        Me.tbTotal.TabIndex = 17
        Me.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Total"
        '
        'tbServicio
        '
        Me.tbServicio.BackColor = System.Drawing.Color.Black
        Me.tbServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbServicio.ForeColor = System.Drawing.Color.White
        Me.tbServicio.Location = New System.Drawing.Point(153, 99)
        Me.tbServicio.Name = "tbServicio"
        Me.tbServicio.ReadOnly = True
        Me.tbServicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbServicio.Size = New System.Drawing.Size(102, 29)
        Me.tbServicio.TabIndex = 15
        Me.tbServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbSubTotal
        '
        Me.tbSubTotal.BackColor = System.Drawing.Color.Black
        Me.tbSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSubTotal.ForeColor = System.Drawing.Color.White
        Me.tbSubTotal.Location = New System.Drawing.Point(153, 19)
        Me.tbSubTotal.Name = "tbSubTotal"
        Me.tbSubTotal.ReadOnly = True
        Me.tbSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbSubTotal.Size = New System.Drawing.Size(102, 29)
        Me.tbSubTotal.TabIndex = 11
        Me.tbSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "SubTotal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btCancelarRestaurant)
        Me.GroupBox2.Controls.Add(Me.btCancelarBar)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 60)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'btCancelarRestaurant
        '
        Me.btCancelarRestaurant.Enabled = False
        Me.btCancelarRestaurant.Location = New System.Drawing.Point(371, 34)
        Me.btCancelarRestaurant.Name = "btCancelarRestaurant"
        Me.btCancelarRestaurant.Size = New System.Drawing.Size(75, 20)
        Me.btCancelarRestaurant.TabIndex = 17
        Me.btCancelarRestaurant.Text = "Cancelar"
        Me.btCancelarRestaurant.UseVisualStyleBackColor = True
        '
        'btCancelarBar
        '
        Me.btCancelarBar.Enabled = False
        Me.btCancelarBar.Location = New System.Drawing.Point(371, 14)
        Me.btCancelarBar.Name = "btCancelarBar"
        Me.btCancelarBar.Size = New System.Drawing.Size(75, 20)
        Me.btCancelarBar.TabIndex = 16
        Me.btCancelarBar.Text = "Cancelar"
        Me.btCancelarBar.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Black
        Me.TextBox5.Enabled = False
        Me.TextBox5.ForeColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(191, 15)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(174, 20)
        Me.TextBox5.TabIndex = 15
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.Color.Black
        Me.ComboBox3.DataSource = Me.MESEROBindingSource
        Me.ComboBox3.DisplayMember = "nombre"
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.ForeColor = System.Drawing.Color.White
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(244, 35)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 14
        Me.ComboBox3.ValueMember = "codigo"
        '
        'MESEROBindingSource
        '
        Me.MESEROBindingSource.DataMember = "MESERO"
        Me.MESEROBindingSource.DataSource = Me.DsMesero
        '
        'DsMesero
        '
        Me.DsMesero.DataSetName = "dsMesero"
        Me.DsMesero.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.Black
        Me.ComboBox2.DataSource = Me.MESABindingSource
        Me.ComboBox2.DisplayMember = "descripcion"
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.ForeColor = System.Drawing.Color.White
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(117, 35)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 13
        Me.ComboBox2.ValueMember = "codigo"
        '
        'MESABindingSource
        '
        Me.MESABindingSource.DataMember = "MESA"
        Me.MESABindingSource.DataSource = Me.DsMesa
        '
        'DsMesa
        '
        Me.DsMesa.DataSetName = "dsMesa"
        Me.DsMesa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Black
        Me.ComboBox1.DataSource = Me.TARJETABindingSource
        Me.ComboBox1.DisplayMember = "codigo"
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(117, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(68, 21)
        Me.ComboBox1.TabIndex = 12
        Me.ComboBox1.ValueMember = "nombre"
        '
        'TARJETABindingSource
        '
        Me.TARJETABindingSource.DataMember = "TARJETA"
        Me.TARJETABindingSource.DataSource = Me.DsTarjetas
        '
        'DsTarjetas
        '
        Me.DsTarjetas.DataSetName = "dsTarjetas"
        Me.DsTarjetas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 36)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(99, 17)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RESTAURANT"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.Text = "BAR"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'gbSelProds
        '
        Me.gbSelProds.Controls.Add(Me.Button1)
        Me.gbSelProds.Controls.Add(Me.Label7)
        Me.gbSelProds.Controls.Add(Me.Label6)
        Me.gbSelProds.Controls.Add(Me.Label5)
        Me.gbSelProds.Controls.Add(Me.Label3)
        Me.gbSelProds.Controls.Add(Me.btAgregar)
        Me.gbSelProds.Controls.Add(Me.lbCantidad)
        Me.gbSelProds.Controls.Add(Me.dgvSubTipo)
        Me.gbSelProds.Controls.Add(Me.dgvTipo)
        Me.gbSelProds.Controls.Add(Me.dgvClase)
        Me.gbSelProds.Controls.Add(Me.dgvGrupo)
        Me.gbSelProds.Enabled = False
        Me.gbSelProds.Location = New System.Drawing.Point(12, 64)
        Me.gbSelProds.Name = "gbSelProds"
        Me.gbSelProds.Size = New System.Drawing.Size(984, 265)
        Me.gbSelProds.TabIndex = 11
        Me.gbSelProds.TabStop = False
        Me.gbSelProds.Text = "Seleccion de Producto"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(946, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 80)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "MOD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(731, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "SubTipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(455, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(179, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Clase"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Grupo"
        '
        'btAgregar
        '
        Me.btAgregar.Enabled = False
        Me.btAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregar.Location = New System.Drawing.Point(946, 15)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(33, 158)
        Me.btAgregar.TabIndex = 12
        Me.btAgregar.Text = "AGREGAR"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'lbCantidad
        '
        Me.lbCantidad.BackColor = System.Drawing.Color.Black
        Me.lbCantidad.Enabled = False
        Me.lbCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCantidad.ForeColor = System.Drawing.Color.White
        Me.lbCantidad.FormattingEnabled = True
        Me.lbCantidad.ItemHeight = 24
        Me.lbCantidad.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.lbCantidad.Location = New System.Drawing.Point(910, 15)
        Me.lbCantidad.Name = "lbCantidad"
        Me.lbCantidad.Size = New System.Drawing.Size(30, 244)
        Me.lbCantidad.TabIndex = 11
        '
        'dgvSubTipo
        '
        Me.dgvSubTipo.AllowUserToAddRows = False
        Me.dgvSubTipo.AllowUserToDeleteRows = False
        Me.dgvSubTipo.AllowUserToResizeColumns = False
        Me.dgvSubTipo.AllowUserToResizeRows = False
        Me.dgvSubTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubTipo.ColumnHeadersVisible = False
        Me.dgvSubTipo.Location = New System.Drawing.Point(734, 32)
        Me.dgvSubTipo.Name = "dgvSubTipo"
        Me.dgvSubTipo.ReadOnly = True
        Me.dgvSubTipo.RowHeadersVisible = False
        Me.dgvSubTipo.Size = New System.Drawing.Size(170, 227)
        Me.dgvSubTipo.TabIndex = 10
        '
        'dgvTipo
        '
        Me.dgvTipo.AllowUserToAddRows = False
        Me.dgvTipo.AllowUserToDeleteRows = False
        Me.dgvTipo.AllowUserToResizeColumns = False
        Me.dgvTipo.AllowUserToResizeRows = False
        Me.dgvTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTipo.ColumnHeadersVisible = False
        Me.dgvTipo.Location = New System.Drawing.Point(458, 32)
        Me.dgvTipo.Name = "dgvTipo"
        Me.dgvTipo.ReadOnly = True
        Me.dgvTipo.RowHeadersVisible = False
        Me.dgvTipo.Size = New System.Drawing.Size(270, 227)
        Me.dgvTipo.TabIndex = 9
        '
        'dgvClase
        '
        Me.dgvClase.AllowUserToAddRows = False
        Me.dgvClase.AllowUserToDeleteRows = False
        Me.dgvClase.AllowUserToResizeColumns = False
        Me.dgvClase.AllowUserToResizeRows = False
        Me.dgvClase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClase.ColumnHeadersVisible = False
        Me.dgvClase.Location = New System.Drawing.Point(182, 32)
        Me.dgvClase.Name = "dgvClase"
        Me.dgvClase.ReadOnly = True
        Me.dgvClase.RowHeadersVisible = False
        Me.dgvClase.Size = New System.Drawing.Size(270, 227)
        Me.dgvClase.TabIndex = 8
        '
        'dgvGrupo
        '
        Me.dgvGrupo.AllowUserToAddRows = False
        Me.dgvGrupo.AllowUserToDeleteRows = False
        Me.dgvGrupo.AllowUserToResizeColumns = False
        Me.dgvGrupo.AllowUserToResizeRows = False
        Me.dgvGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrupo.ColumnHeadersVisible = False
        Me.dgvGrupo.Location = New System.Drawing.Point(6, 32)
        Me.dgvGrupo.Name = "dgvGrupo"
        Me.dgvGrupo.ReadOnly = True
        Me.dgvGrupo.RowHeadersVisible = False
        Me.dgvGrupo.Size = New System.Drawing.Size(170, 227)
        Me.dgvGrupo.TabIndex = 7
        '
        'gbConsumo
        '
        Me.gbConsumo.Controls.Add(Me.btCortesia)
        Me.gbConsumo.Controls.Add(Me.btEliminarConsumo)
        Me.gbConsumo.Controls.Add(Me.dgvConsumo)
        Me.gbConsumo.Enabled = False
        Me.gbConsumo.Location = New System.Drawing.Point(12, 329)
        Me.gbConsumo.Name = "gbConsumo"
        Me.gbConsumo.Size = New System.Drawing.Size(582, 391)
        Me.gbConsumo.TabIndex = 12
        Me.gbConsumo.TabStop = False
        Me.gbConsumo.Text = "Consumo"
        '
        'btCortesia
        '
        Me.btCortesia.Enabled = False
        Me.btCortesia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCortesia.Location = New System.Drawing.Point(553, 204)
        Me.btCortesia.Name = "btCortesia"
        Me.btCortesia.Size = New System.Drawing.Size(23, 181)
        Me.btCortesia.TabIndex = 2
        Me.btCortesia.Text = "CORTESIA"
        Me.btCortesia.UseVisualStyleBackColor = True
        '
        'btEliminarConsumo
        '
        Me.btEliminarConsumo.Enabled = False
        Me.btEliminarConsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEliminarConsumo.Location = New System.Drawing.Point(553, 14)
        Me.btEliminarConsumo.Name = "btEliminarConsumo"
        Me.btEliminarConsumo.Size = New System.Drawing.Size(23, 181)
        Me.btEliminarConsumo.TabIndex = 1
        Me.btEliminarConsumo.Text = "E L I MI N A R"
        Me.btEliminarConsumo.UseVisualStyleBackColor = True
        '
        'dgvConsumo
        '
        Me.dgvConsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsumo.Location = New System.Drawing.Point(6, 14)
        Me.dgvConsumo.Name = "dgvConsumo"
        Me.dgvConsumo.RowHeadersVisible = False
        Me.dgvConsumo.Size = New System.Drawing.Size(541, 371)
        Me.dgvConsumo.TabIndex = 0
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn4
        '
        Me.DescripcionDataGridViewTextBoxColumn4.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn4.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn4.Name = "DescripcionDataGridViewTextBoxColumn4"
        '
        'DescsubtipoDataGridViewTextBoxColumn
        '
        Me.DescsubtipoDataGridViewTextBoxColumn.DataPropertyName = "descsubtipo"
        Me.DescsubtipoDataGridViewTextBoxColumn.HeaderText = "descsubtipo"
        Me.DescsubtipoDataGridViewTextBoxColumn.Name = "DescsubtipoDataGridViewTextBoxColumn"
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        '
        'btSalir
        '
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.Location = New System.Drawing.Point(871, 7)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(125, 51)
        Me.btSalir.TabIndex = 23
        Me.btSalir.Text = "SALIR"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'btNuevoBar
        '
        Me.btNuevoBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNuevoBar.Location = New System.Drawing.Point(479, 15)
        Me.btNuevoBar.Name = "btNuevoBar"
        Me.btNuevoBar.Size = New System.Drawing.Size(141, 23)
        Me.btNuevoBar.TabIndex = 24
        Me.btNuevoBar.Text = "Nueva Tarjeta"
        Me.btNuevoBar.UseVisualStyleBackColor = True
        '
        'gbFormaPago
        '
        Me.gbFormaPago.Controls.Add(Me.dgvDetallePago)
        Me.gbFormaPago.Controls.Add(Me.tbAbono)
        Me.gbFormaPago.Controls.Add(Me.cbFormaPago)
        Me.gbFormaPago.Controls.Add(Me.tbSaldo)
        Me.gbFormaPago.Controls.Add(Me.Label2)
        Me.gbFormaPago.Enabled = False
        Me.gbFormaPago.Location = New System.Drawing.Point(600, 548)
        Me.gbFormaPago.Name = "gbFormaPago"
        Me.gbFormaPago.Size = New System.Drawing.Size(396, 172)
        Me.gbFormaPago.TabIndex = 25
        Me.gbFormaPago.TabStop = False
        Me.gbFormaPago.Text = "Forma de Pago"
        Me.gbFormaPago.Visible = False
        '
        'dgvDetallePago
        '
        Me.dgvDetallePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetallePago.Location = New System.Drawing.Point(6, 49)
        Me.dgvDetallePago.Name = "dgvDetallePago"
        Me.dgvDetallePago.RowHeadersVisible = False
        Me.dgvDetallePago.Size = New System.Drawing.Size(384, 117)
        Me.dgvDetallePago.TabIndex = 22
        '
        'tbAbono
        '
        Me.tbAbono.BackColor = System.Drawing.Color.Black
        Me.tbAbono.Enabled = False
        Me.tbAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAbono.ForeColor = System.Drawing.Color.White
        Me.tbAbono.Location = New System.Drawing.Point(146, 14)
        Me.tbAbono.Name = "tbAbono"
        Me.tbAbono.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbAbono.Size = New System.Drawing.Size(76, 29)
        Me.tbAbono.TabIndex = 21
        Me.tbAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbFormaPago
        '
        Me.cbFormaPago.BackColor = System.Drawing.Color.Black
        Me.cbFormaPago.DataSource = Me.FORMAPAGOBindingSource
        Me.cbFormaPago.DisplayMember = "descripcion"
        Me.cbFormaPago.Enabled = False
        Me.cbFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormaPago.ForeColor = System.Drawing.Color.White
        Me.cbFormaPago.FormattingEnabled = True
        Me.cbFormaPago.Location = New System.Drawing.Point(9, 14)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Size = New System.Drawing.Size(136, 28)
        Me.cbFormaPago.TabIndex = 20
        Me.cbFormaPago.ValueMember = "codigo"
        '
        'FORMAPAGOBindingSource
        '
        Me.FORMAPAGOBindingSource.DataMember = "FORMA-PAGO"
        Me.FORMAPAGOBindingSource.DataSource = Me.DsFormaPago
        '
        'DsFormaPago
        '
        Me.DsFormaPago.DataSetName = "dsFormaPago"
        Me.DsFormaPago.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbSaldo
        '
        Me.tbSaldo.BackColor = System.Drawing.Color.Black
        Me.tbSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSaldo.ForeColor = System.Drawing.Color.White
        Me.tbSaldo.Location = New System.Drawing.Point(289, 14)
        Me.tbSaldo.Name = "tbSaldo"
        Me.tbSaldo.ReadOnly = True
        Me.tbSaldo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbSaldo.Size = New System.Drawing.Size(102, 29)
        Me.tbSaldo.TabIndex = 19
        Me.tbSaldo.Text = "0"
        Me.tbSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(231, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 24)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Saldo:"
        '
        'TARJETATableAdapter
        '
        Me.TARJETATableAdapter.ClearBeforeFill = True
        '
        'FORMA_PAGOTableAdapter
        '
        Me.FORMA_PAGOTableAdapter.ClearBeforeFill = True
        '
        'MESATableAdapter
        '
        Me.MESATableAdapter.ClearBeforeFill = True
        '
        'MESEROTableAdapter
        '
        Me.MESEROTableAdapter.ClearBeforeFill = True
        '
        'btReportes
        '
        Me.btReportes.Location = New System.Drawing.Point(646, 12)
        Me.btReportes.Name = "btReportes"
        Me.btReportes.Size = New System.Drawing.Size(94, 43)
        Me.btReportes.TabIndex = 26
        Me.btReportes.Text = "Reportes Administrativos"
        Me.btReportes.UseVisualStyleBackColor = True
        Me.btReportes.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(754, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 43)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Administracion de Productos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1018, 732)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btReportes)
        Me.Controls.Add(Me.gbFormaPago)
        Me.Controls.Add(Me.btNuevoBar)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.gbConsumo)
        Me.Controls.Add(Me.gbSelProds)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbPagar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.MinimumSize = New System.Drawing.Size(1024, 738)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GoTech - BarDisco"
        Me.gbPagar.ResumeLayout(False)
        Me.gbPagar.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.MESEROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMesero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MESABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMesa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TARJETABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTarjetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSelProds.ResumeLayout(False)
        Me.gbSelProds.PerformLayout()
        CType(Me.dgvSubTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvClase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbConsumo.ResumeLayout(False)
        CType(Me.dgvConsumo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFormaPago.ResumeLayout(False)
        Me.gbFormaPago.PerformLayout()
        CType(Me.dgvDetallePago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FORMAPAGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        If Me.RadioButton1.Checked = True Then
            Me.ComboBox1.Enabled = True
            Me.TextBox5.Enabled = True
            Me.ComboBox2.Enabled = False
            Me.ComboBox3.Enabled = False
            Me.TARJETATableAdapter.Fill(Me.DsTarjetas.TARJETA)
            Me.RadioButton1.Enabled = False
            Me.RadioButton2.Enabled = False
            Me.btCancelarBar.Enabled = True
            Me.ComboBox1.SelectedIndex = -1
            Me.ComboBox1.Focus()
        End If
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        If Me.RadioButton2.Checked = True Then
            Me.ComboBox2.Enabled = True
            Me.ComboBox3.Enabled = True
            Me.ComboBox1.Enabled = False
            Me.TextBox5.Enabled = False
            Me.RadioButton1.Enabled = False
            Me.RadioButton2.Enabled = False
            Me.btCancelarRestaurant.Enabled = True
            Me.MESEROTableAdapter.Fill(Me.DsMesero.MESERO)
            Me.MESATableAdapter.Fill(Me.DsMesa.MESA)
            Me.ComboBox2.SelectedIndex = -1
            Me.ComboBox3.SelectedIndex = -1
            Me.ComboBox2.Focus()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Me.ComboBox1.SelectedValue <> Nothing Then
            Me.TextBox5.Text = Me.ComboBox1.SelectedValue.ToString()
            codCliente = CType(Me.ComboBox1.Text.ToString, Integer)
            Me.gbConsumo.Enabled = True
            Me.gbPagar.Enabled = True
            Me.gbSelProds.Enabled = True
            'Me.CONSUMOTableAdapter.Fill(Me.BarDisco2DataSet6.CONSUMO)
            Dim cconsumo As New C_baradmin
            cconsumo.carga_consumo()

            dgvConsumo.DataSource = dsConsumo.Tables(0).DefaultView
            dgvConsumo.Columns(0).Visible = False
            dgvConsumo.Columns(1).Width = 50
            dgvConsumo.Columns(2).Width = 100
            dgvConsumo.Columns(3).Width = 250
            dgvConsumo.Columns(4).Width = 50
            dgvConsumo.Columns(5).Width = 50
            dgvConsumo.Columns(6).Visible = False

            For Each row As DataGridViewRow In Me.dgvConsumo.Rows
                If row.Cells(6).Value = "C" Then
                    row.Cells(4).Value = 0
                    row.Cells(5).Value = 0

                End If
            Next

            Dim Total As Double
            For Each row As DataGridViewRow In Me.dgvConsumo.Rows
                Total += Val(row.Cells(5).Value)
            Next
            Me.tbSubTotal.Text = Format(Total, "$ #,##0.00")

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

            Me.gbFormaPago.Visible = False
            dgvDetallePago.DataSource = ""

        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Me.btPagar.Enabled = False
        If Me.ComboBox2.SelectedValue <> Nothing Then
            codMesa = Me.ComboBox2.SelectedValue
            Dim cconsumo As New C_baradmin
            cconsumo.carga_consumomesa()

            dgvConsumo.DataSource = dsConsumo.Tables(0).DefaultView
            dgvConsumo.Columns(0).Visible = False
            dgvConsumo.Columns(1).Width = 50
            dgvConsumo.Columns(2).Width = 100
            dgvConsumo.Columns(3).Width = 250
            dgvConsumo.Columns(4).Width = 50
            dgvConsumo.Columns(5).Width = 50
            dgvConsumo.Columns(6).Visible = False

            For Each row As DataGridViewRow In Me.dgvConsumo.Rows
                If row.Cells(6).Value = "C" Then
                    row.Cells(4).Value = 0
                    row.Cells(5).Value = 0

                End If
            Next

            Dim Total As Double
            For Each row As DataGridViewRow In Me.dgvConsumo.Rows
                Total += Val(row.Cells(5).Value)
            Next
            Me.tbSubTotal.Text = Format(Total, "$ #,##0.00")
            Me.gbPagar.Enabled = True
            Me.gbConsumo.Enabled = True
            Me.ComboBox3.Focus()
            Me.gbFormaPago.Visible = False
            dgvDetallePago.DataSource = ""
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If Me.ComboBox3.SelectedValue <> Nothing Then
            codMesero = Me.ComboBox3.SelectedValue
            Me.gbSelProds.Enabled = True
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
            dgvGrupo.Columns(1).Width = 150

            Me.gbFormaPago.Visible = False
            dgvDetallePago.DataSource = ""
        End If
    End Sub

    Private Sub dgvgrupo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrupo.CellClick
        codGrupo = dgvGrupo.Rows(e.RowIndex).Cells(0).Value

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
        lbCantidad.Enabled = False


        Me.dgvClase.Focus()
    End Sub

    Private Sub dgvClase_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClase.CellClick
        codClase = dgvClase.Rows(e.RowIndex).Cells(0).Value

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
        lbCantidad.Enabled = False

        Me.dgvTipo.Focus()
    End Sub

    Private Sub dgvTipo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTipo.CellClick
        codTipo = dgvTipo.Rows(e.RowIndex).Cells(0).Value

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
        lbCantidad.Enabled = False

        Me.dgvSubTipo.Focus()
    End Sub

    Private Sub dgvSubTipo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSubTipo.CellClick
        codSubTipo = dgvSubTipo.Rows(e.RowIndex).Cells(0).Value
        lbCantidad.Enabled = True
        Me.lbCantidad.Focus()
        Button1.Enabled = True
    End Sub

    Private Sub lbCantidad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbCantidad.SelectedIndexChanged
        cantidadProd = CType(Me.lbCantidad.SelectedItem, Integer)
        Me.btAgregar.Enabled = True
    End Sub

    Private Sub btSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub btCancelarBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelarBar.Click
        Me.RadioButton1.Enabled = True
        Me.RadioButton2.Enabled = True
        Me.ComboBox1.Enabled = False
        Me.TextBox5.Enabled = False
        Me.TextBox5.Clear()
        Me.ComboBox1.Text = ""
        Me.btCancelarBar.Enabled = False

        dgvGrupo.DataSource = ""
        dgvClase.DataSource = ""
        dgvTipo.DataSource = ""
        dgvSubTipo.DataSource = ""
        dgvConsumo.DataSource = ""
        dgvDetallePago.DataSource = ""

        Me.gbConsumo.Enabled = False
        Me.gbSelProds.Enabled = False
        Me.gbPagar.Enabled = False
        Me.gbFormaPago.Visible = False

        codCliente = Nothing
        Me.tbSubTotal.Text = "$ 0,00"
        Me.lbCantidad.Enabled = False
        Me.btAgregar.Enabled = False

        Me.btPagar.Enabled = False
        Me.btEliminarConsumo.Enabled = False
        Me.btCerrarCuenta.Enabled = False
        Me.btCerrarCuenta.Visible = False

    End Sub

    Private Sub btCancelarRestaurant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelarRestaurant.Click
        Me.RadioButton1.Enabled = True
        Me.RadioButton2.Enabled = True
        Me.ComboBox2.Enabled = False
        Me.ComboBox3.Enabled = False
        Me.ComboBox2.Text = ""
        Me.ComboBox3.Text = ""
        Me.btCancelarRestaurant.Enabled = False
        dgvGrupo.DataSource = ""
        dgvClase.DataSource = ""
        dgvTipo.DataSource = ""
        dgvSubTipo.DataSource = ""
        dgvConsumo.DataSource = ""
        dgvDetallePago.DataSource = ""

        Me.gbConsumo.Enabled = False
        Me.gbSelProds.Enabled = False
        Me.gbPagar.Enabled = False
        Me.gbFormaPago.Visible = False

        Me.tbSubTotal.Text = "$ 0,00"
        Me.lbCantidad.Enabled = False
        Me.btAgregar.Enabled = False

        Me.btPagar.Enabled = False
        Me.btEliminarConsumo.Enabled = False
        Me.btCerrarCuenta.Enabled = False
        Me.btCerrarCuenta.Visible = False

        codMesa = Nothing
        codMesero = Nothing
    End Sub

    Private Sub tbSubTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSubTotal.TextChanged
        If Me.tbSubTotal.Text <> "$ 0,00" Then
            Me.btPagar.Enabled = True
            If Me.cbIVA.Checked = True Then
                Me.tbIVA.Text = Format(CType(Me.tbSubTotal.Text, Double) * 0.12, "$ #,##0.00")
            Else
                Me.tbIVA.Text = Format(0, "$ #,##0.00")
            End If
            If Me.cbServicio.Checked = True Then
                Me.tbServicio.Text = Format(CType(Me.tbSubTotal.Text, Double) * 0.1, "$ #,##0.00")
            Else
                Me.tbServicio.Text = Format(0, "$ #,##0.00")
            End If
            If Me.cbDescuento.Checked = True Then
                Me.tbDesc.Text = Format(CType(Me.tbSubTotal.Text, Double) * (CType(Me.tbDescuento.Text, Integer) / 100), "$ #,##0.00")
            Else
                Me.tbDesc.Text = Format(0, "$ #,##0.00")
            End If
            Me.tbTotal.Text = Format(CType(Me.tbSubTotal.Text, Double) + CType(Me.tbIVA.Text, Double) + CType(Me.tbServicio.Text, Double) - CType(Me.tbDesc.Text, Double), "$ #,##0.00")
            CalculaSaldo()
        Else
            Me.tbIVA.Text = ""
            Me.tbServicio.Text = ""
            Me.tbTotal.Text = ""
        End If
    End Sub

    Private Sub cbIVA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbIVA.CheckedChanged
        If Me.tbSubTotal.Text <> "" Then
            If Me.cbIVA.Checked = True Then
                Me.tbIVA.Text = Format(CType(Me.tbSubTotal.Text, Double) * 0.12, "$ #,##0.00")
                Me.tbTotal.Text = Format(CType(Me.tbSubTotal.Text, Double) + CType(Me.tbIVA.Text, Double) + CType(Me.tbServicio.Text, Double) - CType(Me.tbDesc.Text, Double), "$ #,##0.00")
                CalculaSaldo()
            Else
                Me.tbIVA.Text = Format(0, "$ #,##0.00")
                Me.tbTotal.Text = Format(CType(Me.tbSubTotal.Text, Double) + CType(Me.tbIVA.Text, Double) + CType(Me.tbServicio.Text, Double) - CType(Me.tbDesc.Text, Double), "$ #,##0.00")
                CalculaSaldo()
            End If
        End If
    End Sub

    Private Sub cbServicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbServicio.CheckedChanged
        If Me.tbSubTotal.Text <> "" Then
            If Me.cbServicio.Checked = True Then
                Me.tbServicio.Text = Format(CType(Me.tbSubTotal.Text, Double) * 0.1, "$ #,##0.00")
                Me.tbTotal.Text = Format(CType(Me.tbSubTotal.Text, Double) + CType(Me.tbIVA.Text, Double) + CType(Me.tbServicio.Text, Double) - CType(Me.tbDesc.Text, Double), "$ #,##0.00")
                CalculaSaldo()
            Else
                Me.tbServicio.Text = Format(0, "$ #,##0.00")
                Me.tbTotal.Text = Format(CType(Me.tbSubTotal.Text, Double) + CType(Me.tbIVA.Text, Double) + CType(Me.tbServicio.Text, Double) - CType(Me.tbDesc.Text, Double), "$ #,##0.00")
                CalculaSaldo()
            End If
        End If
    End Sub
    Private Sub cbDescuento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDescuento.CheckedChanged
        If Me.tbSubTotal.Text <> "" Then
            If Me.cbDescuento.Checked = True And Me.tbDescuento.Text <> Nothing Then
                Me.tbDesc.Text = Format(CType(Me.tbSubTotal.Text, Double) * (CType(Me.tbDescuento.Text, Integer) / 100), "$ #,##0.00")
                Me.tbTotal.Text = Format(CType(Me.tbSubTotal.Text, Double) + CType(Me.tbIVA.Text, Double) + CType(Me.tbServicio.Text, Double) - CType(Me.tbDesc.Text, Double), "$ #,##0.00")
                CalculaSaldo()
            Else
                Me.tbDesc.Text = Format(0, "$ #,##0.00")
                Me.tbTotal.Text = Format(CType(Me.tbSubTotal.Text, Double) + CType(Me.tbIVA.Text, Double) + CType(Me.tbServicio.Text, Double) - CType(Me.tbDesc.Text, Double), "$ #,##0.00")
                CalculaSaldo()
            End If
        End If
    End Sub

    Private Sub btNuevoBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNuevoBar.Click
        NuevoCliente.Show()
        Me.Close()
    End Sub

    Private Sub btPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPagar.Click
        Me.gbFormaPago.Enabled = True
        Me.gbFormaPago.Visible = True
        Me.FORMA_PAGOTableAdapter.Fill(Me.DsFormaPago._FORMA_PAGO)
        If codCliente <> Nothing Then
            Dim dpago As New C_baradmin
            dpago.detalle_pago()

            dgvDetallePago.DataSource = dsDetallePago.Tables(0).DefaultView
            dgvDetallePago.Columns(0).Visible = False
            Me.dgvDetallePago.Visible = True
        ElseIf codMesa <> Nothing Then
            Dim dpago As New C_baradmin
            dpago.detalle_pago2()

            dgvDetallePago.DataSource = dsDetallePago.Tables(0).DefaultView
            dgvDetallePago.Columns(0).Visible = False
            Me.dgvDetallePago.Visible = True
        End If

        CalculaSaldo()
        Me.cbFormaPago.Focus()
    End Sub

    Private Sub CalculaSaldo()
        abonado = Nothing
        For Each row As DataGridViewRow In Me.dgvDetallePago.Rows
            abonado += Val(row.Cells(2).Value)
        Next
        saldo = CType(Me.tbTotal.Text, Double) - abonado
        Me.tbSaldo.Text = Format(saldo, "$ #,##0.00")
        If CType(Me.tbSaldo.Text, Double) > 0 Then
            Me.cbFormaPago.Enabled = True
            Me.tbAbono.Enabled = True
        ElseIf CType(Me.tbSaldo.Text, Double) < 0 Then
            Me.cbFormaPago.Enabled = False
            Me.tbAbono.Enabled = False
            Dim zz As New C_baradmin
            MessageBox.Show("El vuelto es: " & Me.tbSaldo.Text)
            codFormaPago = 8
            abono = CType(Me.tbSaldo.Text, Double)
            zz.add_abono()
            Me.tbSaldo.Text = "$ 0.00"
        End If
        If CType(Me.tbSaldo.Text, Double) = 0 And Me.tbSubTotal.Text <> "$ 0.00" Then
            Me.cbFormaPago.Enabled = False
            Me.tbAbono.Enabled = False
            MessageBox.Show("Cuenta al dia")
            Me.btCerrarCuenta.Visible = True
            Me.btCerrarCuenta.Enabled = True

        End If
    End Sub

    Private Sub btTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTicket.Click
        'Dim dtr As New C_baradmin
        'dtr.elimina_temprep()
        Dim con0 As New SqlClient.SqlConnection("Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev")
        Dim cmEliminaTempRep As New SqlClient.SqlCommand("delete [TEMP-REPORTES]", con0)
        con0.Open()
        cmEliminaTempRep.ExecuteReader()
        con0.Close()

        Dim cmAgregaTempRep As New SqlClient.SqlCommand("insert into [TEMP-REPORTES] (subtotal, iva, servicio, descuento, total, status) values ('" & tbSubTotal.Text & "','" & tbIVA.Text & "','" & tbServicio.Text & "','" & tbDesc.Text & "','" & tbTotal.Text & "','A')", con0)
        con0.Open()
        cmAgregaTempRep.ExecuteReader()
        con0.Close()

        Me.btTicket.Enabled = False

        Reportes.ShowDialog()

        Me.btTicket.Enabled = True

    End Sub

    Private Sub btAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAgregar.Click
        Dim cc As New C_baradmin
        If Me.RadioButton1.Checked = True Then
            cc.add_consumo()
            Dim cconsumo As New C_baradmin
            cconsumo.carga_consumo()
            dgvConsumo.DataSource = dsConsumo.Tables(0).DefaultView
            dgvConsumo.Columns(0).Visible = False
            dgvConsumo.Columns(1).Width = 50
            dgvConsumo.Columns(2).Width = 100
            dgvConsumo.Columns(3).Width = 250
            dgvConsumo.Columns(4).Width = 50
            dgvConsumo.Columns(5).Width = 50
            dgvConsumo.Columns(6).Visible = False

            For Each row As DataGridViewRow In Me.dgvConsumo.Rows
                If row.Cells(6).Value = "C" Then
                    row.Cells(4).Value = 0
                    row.Cells(5).Value = 0

                End If
            Next


            Dim Total As Double
            For Each row As DataGridViewRow In Me.dgvConsumo.Rows
                Total += Val(row.Cells(5).Value)
            Next
            Me.tbSubTotal.Text = Format(Total, "$ #,##0.00")
        ElseIf Me.RadioButton2.Checked = True Then
            cc.add_mesa()
            Dim cconsumo As New C_baradmin
            cconsumo.carga_consumomesa()

            dgvConsumo.DataSource = dsConsumo.Tables(0).DefaultView
            dgvConsumo.Columns(0).Visible = False
            dgvConsumo.Columns(1).Width = 50
            dgvConsumo.Columns(2).Width = 100
            dgvConsumo.Columns(3).Width = 250
            dgvConsumo.Columns(4).Width = 50
            dgvConsumo.Columns(5).Width = 50
            dgvConsumo.Columns(6).Visible = False

            For Each row As DataGridViewRow In Me.dgvConsumo.Rows
                If row.Cells(6).Value = "C" Then
                    row.Cells(4).Value = 0
                    row.Cells(5).Value = 0

                End If
            Next


            Dim Total As Double
            For Each row As DataGridViewRow In Me.dgvConsumo.Rows
                Total += Val(row.Cells(5).Value)
            Next
            Me.tbSubTotal.Text = Format(Total, "$ #,##0.00")
        End If

    End Sub

    Private Sub tbAbono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbAbono.KeyPress
        Dim xx As New C_baradmin
        Dim dpago As New C_baradmin

        abono = Nothing
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If e.KeyChar = Convert.ToChar(Keys.Return) And Me.cbFormaPago.SelectedValue <> Nothing Then
                abono = CType(Me.tbAbono.Text, Double)
                codFormaPago = Me.cbFormaPago.SelectedValue
                xx.add_abono()
                If codCliente <> Nothing Then
                    dpago.detalle_pago()
                    dgvDetallePago.DataSource = dsDetallePago.Tables(0).DefaultView
                    dgvDetallePago.Columns(0).Visible = False
                ElseIf codMesa <> Nothing Then
                    dpago.detalle_pago2()
                    dgvDetallePago.DataSource = dsDetallePago.Tables(0).DefaultView
                    dgvDetallePago.Columns(0).Visible = False
                End If

                Me.tbAbono.Text = ""
                Me.cbFormaPago.Focus()

                CalculaSaldo()
            End If
        End If

    End Sub

    Private Sub tbTotal_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbTotal.TextChanged
        If tbTotal.Text <> Nothing Or tbTotal.Text <> "$ 0.00" Then
            Me.btCerrarCuenta.Enabled = True
            Me.btCerrarCuenta.Visible = True
        End If
    End Sub


    Private Sub btCerrarCuenta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btCerrarCuenta.Click
        Dim cc As New C_baradmin
        cc.cerrar_cuenta()

        If codMesa <> Nothing Then
            Dim cc2 As New C_baradmin
            cc2.cerrar_cuenta2()
        End If

        Me.RadioButton1.Enabled = True
        Me.RadioButton2.Enabled = True
        Me.ComboBox1.Enabled = False
        Me.TextBox5.Enabled = False
        Me.TextBox5.Clear()
        Me.ComboBox1.Text = ""
        Me.btCancelarBar.Enabled = False

        dgvGrupo.DataSource = ""
        dgvClase.DataSource = ""
        dgvTipo.DataSource = ""
        dgvSubTipo.DataSource = ""
        dgvConsumo.DataSource = ""
        dgvDetallePago.DataSource = ""

        Me.gbConsumo.Enabled = False
        Me.gbSelProds.Enabled = False
        Me.gbPagar.Enabled = False
        Me.gbFormaPago.Visible = False

        Me.tbSubTotal.Text = "$ 0,00"
        Me.lbCantidad.Enabled = False
        Me.btAgregar.Enabled = False

        Me.btPagar.Enabled = False
        Me.btEliminarConsumo.Enabled = False
        Me.btCerrarCuenta.Enabled = False
        Me.btCerrarCuenta.Visible = False

        codCliente = Nothing
        codMesa = Nothing
        codMesero = Nothing

    End Sub

    Private Sub btReportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReportes.Click
        ReportesAdmin.Show()
    End Sub
    Private Sub dgvConsumo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvConsumo.CellClick
        codConsumo = dgvConsumo.Rows(e.RowIndex).Cells(0).Value
        btEliminarConsumo.Enabled = True
        btCortesia.Enabled = True
    End Sub

    Private Sub btEliminarConsumo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEliminarConsumo.Click
        temp = 1
        AdminCortesia.ShowDialog()
        Me.btEliminarConsumo.Enabled = False
        Me.btCortesia.Enabled = False
        Dim cconsumo As New C_baradmin

        If codCliente <> 0 Then
            cconsumo.carga_consumo()
        ElseIf codMesa <> 0 Then
            cconsumo.carga_consumomesa()
        End If

        dgvConsumo.DataSource = dsConsumo.Tables(0).DefaultView
        dgvConsumo.Columns(0).Visible = False
        dgvConsumo.Columns(1).Width = 50
        dgvConsumo.Columns(2).Width = 100
        dgvConsumo.Columns(3).Width = 250
        dgvConsumo.Columns(4).Width = 50
        dgvConsumo.Columns(5).Width = 50
        dgvConsumo.Columns(6).Visible = False

        For Each row As DataGridViewRow In Me.dgvConsumo.Rows
            If row.Cells(6).Value = "C" Then
                row.Cells(4).Value = 0
                row.Cells(5).Value = 0

            End If
        Next


        Dim Total As Double
        For Each row As DataGridViewRow In Me.dgvConsumo.Rows
            Total += Val(row.Cells(5).Value)
        Next
        Me.tbSubTotal.Text = Format(Total, "$ #,##0.00")
    End Sub

    Private Sub btCortesia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCortesia.Click
        temp = 2
        AdminCortesia.ShowDialog()
        Me.btEliminarConsumo.Enabled = False
        Me.btCortesia.Enabled = False
        Dim cconsumo As New C_baradmin

        If codCliente <> 0 Then
            cconsumo.carga_consumo()
        ElseIf codMesa <> 0 Then
            cconsumo.carga_consumomesa()
        End If

        dgvConsumo.DataSource = dsConsumo.Tables(0).DefaultView
        dgvConsumo.Columns(0).Visible = False
        dgvConsumo.Columns(1).Width = 50
        dgvConsumo.Columns(2).Width = 100
        dgvConsumo.Columns(3).Width = 250
        dgvConsumo.Columns(4).Width = 50
        dgvConsumo.Columns(5).Width = 50
        dgvConsumo.Columns(6).Visible = False

        For Each row As DataGridViewRow In Me.dgvConsumo.Rows
            If row.Cells(6).Value = "C" Then
                row.Cells(4).Value = 0
                row.Cells(5).Value = 0

            End If
        Next


        Dim Total As Double
        For Each row As DataGridViewRow In Me.dgvConsumo.Rows
            Total += Val(row.Cells(5).Value)
        Next
        Me.tbSubTotal.Text = Format(Total, "$ #,##0.00")
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Modificar.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AdminClave2.ShowDialog()
    End Sub
End Class

