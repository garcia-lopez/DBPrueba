<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleado
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim PrimerNombreLabel As System.Windows.Forms.Label
        Dim PrimerApellidoLabel As System.Windows.Forms.Label
        Dim FechaNacLabel As System.Windows.Forms.Label
        Dim SegundoNombreLabel As System.Windows.Forms.Label
        Dim SegundoApellidoLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim IdCiudadLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Me.DSDBPrueba26 = New RegistroPersonas.DSDBPrueba26()
        Me.PersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonaTableAdapter = New RegistroPersonas.DSDBPrueba26TableAdapters.PersonaTableAdapter()
        Me.TableAdapterManager = New RegistroPersonas.DSDBPrueba26TableAdapters.TableAdapterManager()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.PrimerNombreTextBox = New System.Windows.Forms.TextBox()
        Me.PrimerApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaNacDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SegundoNombreTextBox = New System.Windows.Forms.TextBox()
        Me.SegundoApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.Activo = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_guardar = New System.Windows.Forms.ToolStripButton()
        Me.btn_editar = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.CmBSexo = New System.Windows.Forms.ComboBox()
        Me.CmBCiudad = New System.Windows.Forms.ComboBox()
        IdLabel = New System.Windows.Forms.Label()
        PrimerNombreLabel = New System.Windows.Forms.Label()
        PrimerApellidoLabel = New System.Windows.Forms.Label()
        FechaNacLabel = New System.Windows.Forms.Label()
        SegundoNombreLabel = New System.Windows.Forms.Label()
        SegundoApellidoLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        IdCiudadLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        CType(Me.DSDBPrueba26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!)
        IdLabel.Location = New System.Drawing.Point(112, 66)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(25, 20)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'PrimerNombreLabel
        '
        PrimerNombreLabel.AutoSize = True
        PrimerNombreLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!)
        PrimerNombreLabel.Location = New System.Drawing.Point(257, 66)
        PrimerNombreLabel.Name = "PrimerNombreLabel"
        PrimerNombreLabel.Size = New System.Drawing.Size(115, 20)
        PrimerNombreLabel.TabIndex = 3
        PrimerNombreLabel.Text = "primer Nombre:"
        '
        'PrimerApellidoLabel
        '
        PrimerApellidoLabel.AutoSize = True
        PrimerApellidoLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!)
        PrimerApellidoLabel.Location = New System.Drawing.Point(20, 111)
        PrimerApellidoLabel.Name = "PrimerApellidoLabel"
        PrimerApellidoLabel.Size = New System.Drawing.Size(117, 20)
        PrimerApellidoLabel.TabIndex = 5
        PrimerApellidoLabel.Text = "primer Apellido:"
        '
        'FechaNacLabel
        '
        FechaNacLabel.AutoSize = True
        FechaNacLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!)
        FechaNacLabel.Location = New System.Drawing.Point(571, 111)
        FechaNacLabel.Name = "FechaNacLabel"
        FechaNacLabel.Size = New System.Drawing.Size(79, 20)
        FechaNacLabel.TabIndex = 7
        FechaNacLabel.Text = "fecha Nac:"
        '
        'SegundoNombreLabel
        '
        SegundoNombreLabel.AutoSize = True
        SegundoNombreLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!)
        SegundoNombreLabel.Location = New System.Drawing.Point(520, 68)
        SegundoNombreLabel.Name = "SegundoNombreLabel"
        SegundoNombreLabel.Size = New System.Drawing.Size(130, 20)
        SegundoNombreLabel.TabIndex = 9
        SegundoNombreLabel.Text = "segundo Nombre:"
        '
        'SegundoApellidoLabel
        '
        SegundoApellidoLabel.AutoSize = True
        SegundoApellidoLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!)
        SegundoApellidoLabel.Location = New System.Drawing.Point(249, 113)
        SegundoApellidoLabel.Name = "SegundoApellidoLabel"
        SegundoApellidoLabel.Size = New System.Drawing.Size(132, 20)
        SegundoApellidoLabel.TabIndex = 11
        SegundoApellidoLabel.Text = "segundo Apellido:"
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!)
        SexoLabel.Location = New System.Drawing.Point(92, 161)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(42, 20)
        SexoLabel.TabIndex = 13
        SexoLabel.Text = "sexo:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!)
        TelefonoLabel.Location = New System.Drawing.Point(303, 158)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(69, 20)
        TelefonoLabel.TabIndex = 15
        TelefonoLabel.Text = "telefono:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!)
        EmailLabel.Location = New System.Drawing.Point(595, 158)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(55, 20)
        EmailLabel.TabIndex = 17
        EmailLabel.Text = "correo:"
        '
        'IdCiudadLabel
        '
        IdCiudadLabel.AutoSize = True
        IdCiudadLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!)
        IdCiudadLabel.Location = New System.Drawing.Point(57, 211)
        IdCiudadLabel.Name = "IdCiudadLabel"
        IdCiudadLabel.Size = New System.Drawing.Size(77, 20)
        IdCiudadLabel.TabIndex = 19
        IdCiudadLabel.Text = "id Ciudad:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!)
        DireccionLabel.Location = New System.Drawing.Point(298, 208)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(74, 20)
        DireccionLabel.TabIndex = 21
        DireccionLabel.Text = "direccion:"
        '
        'DSDBPrueba26
        '
        Me.DSDBPrueba26.DataSetName = "DSDBPrueba26"
        Me.DSDBPrueba26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonaBindingSource
        '
        Me.PersonaBindingSource.DataMember = "Persona"
        Me.PersonaBindingSource.DataSource = Me.DSDBPrueba26
        '
        'PersonaTableAdapter
        '
        Me.PersonaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CiudadTableAdapter = Nothing
        Me.TableAdapterManager.PersonaTableAdapter = Me.PersonaTableAdapter
        Me.TableAdapterManager.UpdateOrder = RegistroPersonas.DSDBPrueba26TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(143, 68)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'PrimerNombreTextBox
        '
        Me.PrimerNombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "primerNombre", True))
        Me.PrimerNombreTextBox.Location = New System.Drawing.Point(387, 68)
        Me.PrimerNombreTextBox.Name = "PrimerNombreTextBox"
        Me.PrimerNombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrimerNombreTextBox.TabIndex = 4
        '
        'PrimerApellidoTextBox
        '
        Me.PrimerApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "primerApellido", True))
        Me.PrimerApellidoTextBox.Location = New System.Drawing.Point(143, 113)
        Me.PrimerApellidoTextBox.Name = "PrimerApellidoTextBox"
        Me.PrimerApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrimerApellidoTextBox.TabIndex = 6
        '
        'FechaNacDateTimePicker
        '
        Me.FechaNacDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PersonaBindingSource, "fechaNac", True))
        Me.FechaNacDateTimePicker.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!)
        Me.FechaNacDateTimePicker.Location = New System.Drawing.Point(675, 111)
        Me.FechaNacDateTimePicker.Name = "FechaNacDateTimePicker"
        Me.FechaNacDateTimePicker.Size = New System.Drawing.Size(200, 25)
        Me.FechaNacDateTimePicker.TabIndex = 8
        '
        'SegundoNombreTextBox
        '
        Me.SegundoNombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "segundoNombre", True))
        Me.SegundoNombreTextBox.Location = New System.Drawing.Point(675, 70)
        Me.SegundoNombreTextBox.Name = "SegundoNombreTextBox"
        Me.SegundoNombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SegundoNombreTextBox.TabIndex = 10
        '
        'SegundoApellidoTextBox
        '
        Me.SegundoApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "segundoApellido", True))
        Me.SegundoApellidoTextBox.Location = New System.Drawing.Point(387, 113)
        Me.SegundoApellidoTextBox.Name = "SegundoApellidoTextBox"
        Me.SegundoApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SegundoApellidoTextBox.TabIndex = 12
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(387, 158)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 16
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(675, 158)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 18
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(387, 210)
        Me.DireccionTextBox.Multiline = True
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DireccionTextBox.Size = New System.Drawing.Size(226, 72)
        Me.DireccionTextBox.TabIndex = 22
        '
        'Activo
        '
        Me.Activo.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PersonaBindingSource, "estado", True))
        Me.Activo.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!)
        Me.Activo.Location = New System.Drawing.Point(675, 207)
        Me.Activo.Name = "Activo"
        Me.Activo.Size = New System.Drawing.Size(104, 24)
        Me.Activo.TabIndex = 24
        Me.Activo.Text = "Activo"
        Me.Activo.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_nuevo, Me.btn_guardar, Me.btn_editar, Me.Btn_Eliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(948, 27)
        Me.ToolStrip1.TabIndex = 25
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_nuevo.Image = Global.RegistroPersonas.My.Resources.Resources.btn_nuevo
        Me.btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(24, 24)
        Me.btn_nuevo.Text = "Nuevo"
        '
        'btn_guardar
        '
        Me.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_guardar.Image = Global.RegistroPersonas.My.Resources.Resources.BtnGuardar
        Me.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(24, 24)
        Me.btn_guardar.Text = "ToolStripButton2"
        Me.btn_guardar.ToolTipText = "Guardar"
        '
        'btn_editar
        '
        Me.btn_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_editar.Image = Global.RegistroPersonas.My.Resources.Resources.BtnEditar
        Me.btn_editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(24, 24)
        Me.btn_editar.Text = "Editar"
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Eliminar.Image = Global.RegistroPersonas.My.Resources.Resources.BtnBorrar
        Me.Btn_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(24, 24)
        Me.Btn_Eliminar.Text = "Eliminar"
        '
        'CmBSexo
        '
        Me.CmBSexo.FormattingEnabled = True
        Me.CmBSexo.Items.AddRange(New Object() {"Mujer", "Hombre"})
        Me.CmBSexo.Location = New System.Drawing.Point(143, 160)
        Me.CmBSexo.Name = "CmBSexo"
        Me.CmBSexo.Size = New System.Drawing.Size(100, 21)
        Me.CmBSexo.TabIndex = 26
        '
        'CmBCiudad
        '
        Me.CmBCiudad.FormattingEnabled = True
        Me.CmBCiudad.Location = New System.Drawing.Point(143, 210)
        Me.CmBCiudad.Name = "CmBCiudad"
        Me.CmBCiudad.Size = New System.Drawing.Size(100, 21)
        Me.CmBCiudad.TabIndex = 27
        '
        'FrmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(948, 450)
        Me.Controls.Add(Me.CmBCiudad)
        Me.Controls.Add(Me.CmBSexo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Activo)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(IdCiudadLabel)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(SexoLabel)
        Me.Controls.Add(SegundoApellidoLabel)
        Me.Controls.Add(Me.SegundoApellidoTextBox)
        Me.Controls.Add(SegundoNombreLabel)
        Me.Controls.Add(Me.SegundoNombreTextBox)
        Me.Controls.Add(FechaNacLabel)
        Me.Controls.Add(Me.FechaNacDateTimePicker)
        Me.Controls.Add(PrimerApellidoLabel)
        Me.Controls.Add(Me.PrimerApellidoTextBox)
        Me.Controls.Add(PrimerNombreLabel)
        Me.Controls.Add(Me.PrimerNombreTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Name = "FrmEmpleado"
        Me.Text = "FrmEmpleado"
        CType(Me.DSDBPrueba26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DSDBPrueba26 As DSDBPrueba26
    Friend WithEvents PersonaBindingSource As BindingSource
    Friend WithEvents PersonaTableAdapter As DSDBPrueba26TableAdapters.PersonaTableAdapter
    Friend WithEvents TableAdapterManager As DSDBPrueba26TableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents PrimerNombreTextBox As TextBox
    Friend WithEvents PrimerApellidoTextBox As TextBox
    Friend WithEvents FechaNacDateTimePicker As DateTimePicker
    Friend WithEvents SegundoNombreTextBox As TextBox
    Friend WithEvents SegundoApellidoTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents Activo As CheckBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_nuevo As ToolStripButton
    Friend WithEvents btn_guardar As ToolStripButton
    Friend WithEvents btn_editar As ToolStripButton
    Friend WithEvents Btn_Eliminar As ToolStripButton
    Friend WithEvents CmBSexo As ComboBox
    Friend WithEvents CmBCiudad As ComboBox
End Class
