<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrador
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
        Me.Panelcabecera = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.Panelmenu = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnFacturas = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnAreas = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnConsultas = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPaciente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panelcontenedor = New System.Windows.Forms.Panel()
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panelcabecera.SuspendLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelmenu.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelcontenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panelcabecera
        '
        Me.Panelcabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panelcabecera.Controls.Add(Me.btnRestaurar)
        Me.Panelcabecera.Controls.Add(Me.btnMinimizar)
        Me.Panelcabecera.Controls.Add(Me.btnMaximizar)
        Me.Panelcabecera.Controls.Add(Me.btnCerrar)
        Me.Panelcabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panelcabecera.Location = New System.Drawing.Point(0, 0)
        Me.Panelcabecera.Name = "Panelcabecera"
        Me.Panelcabecera.Size = New System.Drawing.Size(1112, 40)
        Me.Panelcabecera.TabIndex = 0
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.Image = Global.PF_TECNOLOGÍA.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.Location = New System.Drawing.Point(1048, 3)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(30, 26)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRestaurar.TabIndex = 6
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = Global.PF_TECNOLOGÍA.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(1017, 3)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(30, 26)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 5
        Me.btnMinimizar.TabStop = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.Image = Global.PF_TECNOLOGÍA.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximizar.Location = New System.Drawing.Point(1048, 3)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(30, 26)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMaximizar.TabIndex = 4
        Me.btnMaximizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = Global.PF_TECNOLOGÍA.My.Resources.Resources.Icono_cerrar_FN1
        Me.btnCerrar.Location = New System.Drawing.Point(1079, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(30, 26)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.TabStop = False
        '
        'Panelmenu
        '
        Me.Panelmenu.BackColor = System.Drawing.Color.Cyan
        Me.Panelmenu.Controls.Add(Me.Panel6)
        Me.Panelmenu.Controls.Add(Me.btnRegresar)
        Me.Panelmenu.Controls.Add(Me.Panel5)
        Me.Panelmenu.Controls.Add(Me.btnFacturas)
        Me.Panelmenu.Controls.Add(Me.Panel4)
        Me.Panelmenu.Controls.Add(Me.btnAreas)
        Me.Panelmenu.Controls.Add(Me.Panel3)
        Me.Panelmenu.Controls.Add(Me.btnEmpleados)
        Me.Panelmenu.Controls.Add(Me.Panel2)
        Me.Panelmenu.Controls.Add(Me.btnConsultas)
        Me.Panelmenu.Controls.Add(Me.Panel1)
        Me.Panelmenu.Controls.Add(Me.btnPaciente)
        Me.Panelmenu.Controls.Add(Me.Label1)
        Me.Panelmenu.Controls.Add(Me.PictureBox2)
        Me.Panelmenu.Controls.Add(Me.PictureBox1)
        Me.Panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panelmenu.Location = New System.Drawing.Point(0, 40)
        Me.Panelmenu.Name = "Panelmenu"
        Me.Panelmenu.Size = New System.Drawing.Size(220, 463)
        Me.Panelmenu.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(0, 401)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 50)
        Me.Panel6.TabIndex = 66
        '
        'btnRegresar
        '
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.FlatAppearance.BorderSize = 0
        Me.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.ForeColor = System.Drawing.Color.Black
        Me.btnRegresar.Image = Global.PF_TECNOLOGÍA.My.Resources.Resources.Icono_cerrar_FN2
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresar.Location = New System.Drawing.Point(0, 401)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(220, 50)
        Me.btnRegresar.TabIndex = 67
        Me.btnRegresar.Text = "        Regresar al Login"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(0, 347)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 50)
        Me.Panel5.TabIndex = 64
        '
        'btnFacturas
        '
        Me.btnFacturas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFacturas.FlatAppearance.BorderSize = 0
        Me.btnFacturas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturas.ForeColor = System.Drawing.Color.Black
        Me.btnFacturas.Image = Global.PF_TECNOLOGÍA.My.Resources.Resources.reportes
        Me.btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFacturas.Location = New System.Drawing.Point(0, 347)
        Me.btnFacturas.Name = "btnFacturas"
        Me.btnFacturas.Size = New System.Drawing.Size(220, 50)
        Me.btnFacturas.TabIndex = 65
        Me.btnFacturas.Text = "        Registrar Facturas"
        Me.btnFacturas.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 291)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 62
        '
        'btnAreas
        '
        Me.btnAreas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAreas.FlatAppearance.BorderSize = 0
        Me.btnAreas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnAreas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.btnAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAreas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAreas.ForeColor = System.Drawing.Color.Black
        Me.btnAreas.Image = Global.PF_TECNOLOGÍA.My.Resources.Resources.producto
        Me.btnAreas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAreas.Location = New System.Drawing.Point(0, 291)
        Me.btnAreas.Name = "btnAreas"
        Me.btnAreas.Size = New System.Drawing.Size(220, 50)
        Me.btnAreas.TabIndex = 63
        Me.btnAreas.Text = "   Registrar Areas"
        Me.btnAreas.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 235)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 50)
        Me.Panel3.TabIndex = 60
        '
        'btnEmpleados
        '
        Me.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpleados.FlatAppearance.BorderSize = 0
        Me.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleados.ForeColor = System.Drawing.Color.Black
        Me.btnEmpleados.Image = Global.PF_TECNOLOGÍA.My.Resources.Resources.clientes
        Me.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpleados.Location = New System.Drawing.Point(0, 235)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(220, 50)
        Me.btnEmpleados.TabIndex = 61
        Me.btnEmpleados.Text = "            Registrar Empleados"
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 179)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 50)
        Me.Panel2.TabIndex = 58
        '
        'btnConsultas
        '
        Me.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultas.FlatAppearance.BorderSize = 0
        Me.btnConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultas.ForeColor = System.Drawing.Color.Black
        Me.btnConsultas.Image = Global.PF_TECNOLOGÍA.My.Resources.Resources.empleados
        Me.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultas.Location = New System.Drawing.Point(0, 179)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(220, 50)
        Me.btnConsultas.TabIndex = 59
        Me.btnConsultas.Text = "          Registrar Consultas"
        Me.btnConsultas.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 50)
        Me.Panel1.TabIndex = 0
        '
        'btnPaciente
        '
        Me.btnPaciente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPaciente.FlatAppearance.BorderSize = 0
        Me.btnPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaciente.ForeColor = System.Drawing.Color.Black
        Me.btnPaciente.Image = Global.PF_TECNOLOGÍA.My.Resources.Resources.clientes
        Me.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPaciente.Location = New System.Drawing.Point(0, 123)
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Size = New System.Drawing.Size(220, 50)
        Me.btnPaciente.TabIndex = 0
        Me.btnPaciente.Text = "          Registrar Pacientes"
        Me.btnPaciente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(81, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 42)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Seattle Grace " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hospital" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.PF_TECNOLOGÍA.My.Resources.Resources.hospital
        Me.PictureBox2.Location = New System.Drawing.Point(3, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.PF_TECNOLOGÍA.My.Resources.Resources.Mobile_Menu_Icon
        Me.PictureBox1.Location = New System.Drawing.Point(182, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panelcontenedor
        '
        Me.Panelcontenedor.BackColor = System.Drawing.Color.Yellow
        Me.Panelcontenedor.Controls.Add(Me.Label2)
        Me.Panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelcontenedor.Location = New System.Drawing.Point(220, 40)
        Me.Panelcontenedor.Name = "Panelcontenedor"
        Me.Panelcontenedor.Size = New System.Drawing.Size(892, 463)
        Me.Panelcontenedor.TabIndex = 2
        '
        'tmOcultarMenu
        '
        '
        'tmMostrarMenu
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(156, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(602, 42)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Entraste como Administrador al sistema del Hospital Seattle Grace " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 503)
        Me.Controls.Add(Me.Panelcontenedor)
        Me.Controls.Add(Me.Panelmenu)
        Me.Controls.Add(Me.Panelcabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Administrador"
        Me.Text = "Administrador"
        Me.Panelcabecera.ResumeLayout(False)
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelmenu.ResumeLayout(False)
        Me.Panelmenu.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelcontenedor.ResumeLayout(False)
        Me.Panelcontenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panelcabecera As Panel
    Friend WithEvents Panelmenu As Panel
    Friend WithEvents Panelcontenedor As Panel
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPaciente As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnRegresar As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnFacturas As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnAreas As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnConsultas As Button
    Friend WithEvents Label2 As Label
End Class
