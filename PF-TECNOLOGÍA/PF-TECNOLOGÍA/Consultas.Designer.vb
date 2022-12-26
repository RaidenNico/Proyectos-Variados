<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ID_CONSULTALabel As System.Windows.Forms.Label
        Dim DPI_PACIENTELabel As System.Windows.Forms.Label
        Dim ID_EMPLEADOLabel As System.Windows.Forms.Label
        Dim ID_AREALabel As System.Windows.Forms.Label
        Dim Fecha_ConsultaLabel As System.Windows.Forms.Label
        Dim PadecimientoLabel As System.Windows.Forms.Label
        Dim Estado_ConsultaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HOSPITALDataSet = New PF_TECNOLOGÍA.HOSPITALDataSet()
        Me.ConsultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultaTableAdapter = New PF_TECNOLOGÍA.HOSPITALDataSetTableAdapters.ConsultaTableAdapter()
        Me.TableAdapterManager = New PF_TECNOLOGÍA.HOSPITALDataSetTableAdapters.TableAdapterManager()
        Me.ConsultaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConsultaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ConsultaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_CONSULTATextBox = New System.Windows.Forms.TextBox()
        Me.DPI_PACIENTETextBox = New System.Windows.Forms.TextBox()
        Me.ID_EMPLEADOTextBox = New System.Windows.Forms.TextBox()
        Me.ID_AREATextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_ConsultaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PadecimientoTextBox = New System.Windows.Forms.TextBox()
        Me.Estado_ConsultaTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        ID_CONSULTALabel = New System.Windows.Forms.Label()
        DPI_PACIENTELabel = New System.Windows.Forms.Label()
        ID_EMPLEADOLabel = New System.Windows.Forms.Label()
        ID_AREALabel = New System.Windows.Forms.Label()
        Fecha_ConsultaLabel = New System.Windows.Forms.Label()
        PadecimientoLabel = New System.Windows.Forms.Label()
        Estado_ConsultaLabel = New System.Windows.Forms.Label()
        CType(Me.HOSPITALDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConsultaBindingNavigator.SuspendLayout()
        CType(Me.ConsultaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_CONSULTALabel
        '
        ID_CONSULTALabel.AutoSize = True
        ID_CONSULTALabel.Location = New System.Drawing.Point(13, 136)
        ID_CONSULTALabel.Name = "ID_CONSULTALabel"
        ID_CONSULTALabel.Size = New System.Drawing.Size(82, 13)
        ID_CONSULTALabel.TabIndex = 61
        ID_CONSULTALabel.Text = "ID CONSULTA:"
        '
        'DPI_PACIENTELabel
        '
        DPI_PACIENTELabel.AutoSize = True
        DPI_PACIENTELabel.Location = New System.Drawing.Point(13, 162)
        DPI_PACIENTELabel.Name = "DPI_PACIENTELabel"
        DPI_PACIENTELabel.Size = New System.Drawing.Size(84, 13)
        DPI_PACIENTELabel.TabIndex = 63
        DPI_PACIENTELabel.Text = "DPI PACIENTE:"
        '
        'ID_EMPLEADOLabel
        '
        ID_EMPLEADOLabel.AutoSize = True
        ID_EMPLEADOLabel.Location = New System.Drawing.Point(13, 188)
        ID_EMPLEADOLabel.Name = "ID_EMPLEADOLabel"
        ID_EMPLEADOLabel.Size = New System.Drawing.Size(83, 13)
        ID_EMPLEADOLabel.TabIndex = 65
        ID_EMPLEADOLabel.Text = "ID EMPLEADO:"
        '
        'ID_AREALabel
        '
        ID_AREALabel.AutoSize = True
        ID_AREALabel.Location = New System.Drawing.Point(13, 214)
        ID_AREALabel.Name = "ID_AREALabel"
        ID_AREALabel.Size = New System.Drawing.Size(53, 13)
        ID_AREALabel.TabIndex = 67
        ID_AREALabel.Text = "ID AREA:"
        '
        'Fecha_ConsultaLabel
        '
        Fecha_ConsultaLabel.AutoSize = True
        Fecha_ConsultaLabel.Location = New System.Drawing.Point(13, 241)
        Fecha_ConsultaLabel.Name = "Fecha_ConsultaLabel"
        Fecha_ConsultaLabel.Size = New System.Drawing.Size(84, 13)
        Fecha_ConsultaLabel.TabIndex = 69
        Fecha_ConsultaLabel.Text = "Fecha Consulta:"
        '
        'PadecimientoLabel
        '
        PadecimientoLabel.AutoSize = True
        PadecimientoLabel.Location = New System.Drawing.Point(13, 266)
        PadecimientoLabel.Name = "PadecimientoLabel"
        PadecimientoLabel.Size = New System.Drawing.Size(74, 13)
        PadecimientoLabel.TabIndex = 71
        PadecimientoLabel.Text = "Padecimiento:"
        '
        'Estado_ConsultaLabel
        '
        Estado_ConsultaLabel.AutoSize = True
        Estado_ConsultaLabel.Location = New System.Drawing.Point(13, 292)
        Estado_ConsultaLabel.Name = "Estado_ConsultaLabel"
        Estado_ConsultaLabel.Size = New System.Drawing.Size(87, 13)
        Estado_ConsultaLabel.TabIndex = 73
        Estado_ConsultaLabel.Text = "Estado Consulta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(477, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 23)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Bienvenido a la sección de Consultas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 21)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "X" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'HOSPITALDataSet
        '
        Me.HOSPITALDataSet.DataSetName = "HOSPITALDataSet"
        Me.HOSPITALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConsultaBindingSource
        '
        Me.ConsultaBindingSource.DataMember = "Consulta"
        Me.ConsultaBindingSource.DataSource = Me.HOSPITALDataSet
        '
        'ConsultaTableAdapter
        '
        Me.ConsultaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AreaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ConsultaTableAdapter = Me.ConsultaTableAdapter
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.FacturaTableAdapter = Nothing
        Me.TableAdapterManager.PacienteTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PF_TECNOLOGÍA.HOSPITALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ConsultaBindingNavigator
        '
        Me.ConsultaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ConsultaBindingNavigator.BindingSource = Me.ConsultaBindingSource
        Me.ConsultaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ConsultaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ConsultaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ConsultaBindingNavigatorSaveItem})
        Me.ConsultaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ConsultaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ConsultaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ConsultaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ConsultaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ConsultaBindingNavigator.Name = "ConsultaBindingNavigator"
        Me.ConsultaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ConsultaBindingNavigator.Size = New System.Drawing.Size(892, 25)
        Me.ConsultaBindingNavigator.TabIndex = 61
        Me.ConsultaBindingNavigator.Text = "BindingNavigator1"
        Me.ConsultaBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ConsultaBindingNavigatorSaveItem
        '
        Me.ConsultaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConsultaBindingNavigatorSaveItem.Image = CType(resources.GetObject("ConsultaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ConsultaBindingNavigatorSaveItem.Name = "ConsultaBindingNavigatorSaveItem"
        Me.ConsultaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ConsultaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ConsultaDataGridView
        '
        Me.ConsultaDataGridView.AutoGenerateColumns = False
        Me.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConsultaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ConsultaDataGridView.DataSource = Me.ConsultaBindingSource
        Me.ConsultaDataGridView.Location = New System.Drawing.Point(324, 211)
        Me.ConsultaDataGridView.Name = "ConsultaDataGridView"
        Me.ConsultaDataGridView.Size = New System.Drawing.Size(544, 220)
        Me.ConsultaDataGridView.TabIndex = 61
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_CONSULTA"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_CONSULTA"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DPI_PACIENTE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DPI_PACIENTE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID_EMPLEADO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID_EMPLEADO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID_AREA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID_AREA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Fecha_Consulta"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha_Consulta"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Padecimiento"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Padecimiento"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Estado_Consulta"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Estado_Consulta"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'ID_CONSULTATextBox
        '
        Me.ID_CONSULTATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsultaBindingSource, "ID_CONSULTA", True))
        Me.ID_CONSULTATextBox.Location = New System.Drawing.Point(106, 133)
        Me.ID_CONSULTATextBox.Name = "ID_CONSULTATextBox"
        Me.ID_CONSULTATextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_CONSULTATextBox.TabIndex = 62
        '
        'DPI_PACIENTETextBox
        '
        Me.DPI_PACIENTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsultaBindingSource, "DPI_PACIENTE", True))
        Me.DPI_PACIENTETextBox.Location = New System.Drawing.Point(106, 159)
        Me.DPI_PACIENTETextBox.Name = "DPI_PACIENTETextBox"
        Me.DPI_PACIENTETextBox.Size = New System.Drawing.Size(200, 20)
        Me.DPI_PACIENTETextBox.TabIndex = 64
        '
        'ID_EMPLEADOTextBox
        '
        Me.ID_EMPLEADOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsultaBindingSource, "ID_EMPLEADO", True))
        Me.ID_EMPLEADOTextBox.Location = New System.Drawing.Point(106, 185)
        Me.ID_EMPLEADOTextBox.Name = "ID_EMPLEADOTextBox"
        Me.ID_EMPLEADOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_EMPLEADOTextBox.TabIndex = 66
        '
        'ID_AREATextBox
        '
        Me.ID_AREATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsultaBindingSource, "ID_AREA", True))
        Me.ID_AREATextBox.Location = New System.Drawing.Point(106, 211)
        Me.ID_AREATextBox.Name = "ID_AREATextBox"
        Me.ID_AREATextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_AREATextBox.TabIndex = 68
        '
        'Fecha_ConsultaDateTimePicker
        '
        Me.Fecha_ConsultaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ConsultaBindingSource, "Fecha_Consulta", True))
        Me.Fecha_ConsultaDateTimePicker.Location = New System.Drawing.Point(106, 237)
        Me.Fecha_ConsultaDateTimePicker.Name = "Fecha_ConsultaDateTimePicker"
        Me.Fecha_ConsultaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_ConsultaDateTimePicker.TabIndex = 70
        '
        'PadecimientoTextBox
        '
        Me.PadecimientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsultaBindingSource, "Padecimiento", True))
        Me.PadecimientoTextBox.Location = New System.Drawing.Point(106, 263)
        Me.PadecimientoTextBox.Name = "PadecimientoTextBox"
        Me.PadecimientoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PadecimientoTextBox.TabIndex = 72
        '
        'Estado_ConsultaTextBox
        '
        Me.Estado_ConsultaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConsultaBindingSource, "Estado_Consulta", True))
        Me.Estado_ConsultaTextBox.Location = New System.Drawing.Point(106, 289)
        Me.Estado_ConsultaTextBox.Name = "Estado_ConsultaTextBox"
        Me.Estado_ConsultaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Estado_ConsultaTextBox.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(137, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 42)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Seattle Grace " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hospital" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.Color.Yellow
        Me.btnReporte.FlatAppearance.BorderSize = 0
        Me.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.ForeColor = System.Drawing.Color.Black
        Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporte.Location = New System.Drawing.Point(141, 418)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(114, 29)
        Me.btnReporte.TabIndex = 87
        Me.btnReporte.Text = "Ver Reporte"
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'btnMostrar
        '
        Me.btnMostrar.BackColor = System.Drawing.Color.Yellow
        Me.btnMostrar.FlatAppearance.BorderSize = 0
        Me.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.ForeColor = System.Drawing.Color.Black
        Me.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMostrar.Location = New System.Drawing.Point(16, 418)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(89, 29)
        Me.btnMostrar.TabIndex = 86
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Yellow
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(141, 360)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(89, 29)
        Me.btnBuscar.TabIndex = 85
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Yellow
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(16, 360)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(89, 29)
        Me.btnEliminar.TabIndex = 84
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Yellow
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(141, 315)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(89, 29)
        Me.btnModificar.TabIndex = 83
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Yellow
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(16, 315)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(89, 29)
        Me.btnAgregar.TabIndex = 82
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(334, 136)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 49)
        Me.Panel1.TabIndex = 88
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(14, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(390, 30)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Area de Registro de Consultas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.PF_TECNOLOGÍA.My.Resources.Resources.Consulta
        Me.PictureBox1.Location = New System.Drawing.Point(367, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 89
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.PF_TECNOLOGÍA.My.Resources.Resources.hospital
        Me.PictureBox2.Location = New System.Drawing.Point(57, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 80
        Me.PictureBox2.TabStop = False
        '
        'Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(892, 463)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(ID_CONSULTALabel)
        Me.Controls.Add(Me.ID_CONSULTATextBox)
        Me.Controls.Add(DPI_PACIENTELabel)
        Me.Controls.Add(Me.DPI_PACIENTETextBox)
        Me.Controls.Add(ID_EMPLEADOLabel)
        Me.Controls.Add(Me.ID_EMPLEADOTextBox)
        Me.Controls.Add(ID_AREALabel)
        Me.Controls.Add(Me.ID_AREATextBox)
        Me.Controls.Add(Fecha_ConsultaLabel)
        Me.Controls.Add(Me.Fecha_ConsultaDateTimePicker)
        Me.Controls.Add(PadecimientoLabel)
        Me.Controls.Add(Me.PadecimientoTextBox)
        Me.Controls.Add(Estado_ConsultaLabel)
        Me.Controls.Add(Me.Estado_ConsultaTextBox)
        Me.Controls.Add(Me.ConsultaDataGridView)
        Me.Controls.Add(Me.ConsultaBindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Consultas"
        Me.Text = "Consultas"
        CType(Me.HOSPITALDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConsultaBindingNavigator.ResumeLayout(False)
        Me.ConsultaBindingNavigator.PerformLayout()
        CType(Me.ConsultaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents HOSPITALDataSet As HOSPITALDataSet
    Friend WithEvents ConsultaBindingSource As BindingSource
    Friend WithEvents ConsultaTableAdapter As HOSPITALDataSetTableAdapters.ConsultaTableAdapter
    Friend WithEvents TableAdapterManager As HOSPITALDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ConsultaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ConsultaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ConsultaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents ID_CONSULTATextBox As TextBox
    Friend WithEvents DPI_PACIENTETextBox As TextBox
    Friend WithEvents ID_EMPLEADOTextBox As TextBox
    Friend WithEvents ID_AREATextBox As TextBox
    Friend WithEvents Fecha_ConsultaDateTimePicker As DateTimePicker
    Friend WithEvents PadecimientoTextBox As TextBox
    Friend WithEvents Estado_ConsultaTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Private WithEvents btnReporte As Button
    Private WithEvents btnMostrar As Button
    Private WithEvents btnBuscar As Button
    Private WithEvents btnEliminar As Button
    Private WithEvents btnModificar As Button
    Private WithEvents btnAgregar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
