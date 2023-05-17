<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCiudad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_guardar = New System.Windows.Forms.ToolStripButton()
        Me.btn_editar = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RDBtnActivo = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.GbRegistros = New System.Windows.Forms.GroupBox()
        Me.DvGRegistros = New System.Windows.Forms.DataGridView()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GbRegistros.SuspendLayout()
        CType(Me.DvGRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_nuevo, Me.btn_guardar, Me.btn_editar, Me.Btn_Eliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(487, 27)
        Me.ToolStrip1.TabIndex = 0
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GbRegistros)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 402)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.RDBtnActivo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei Light", 10.8!)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(482, 177)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Ciudad"
        '
        'RDBtnActivo
        '
        Me.RDBtnActivo.AutoSize = True
        Me.RDBtnActivo.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDBtnActivo.Location = New System.Drawing.Point(267, 46)
        Me.RDBtnActivo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RDBtnActivo.Name = "RDBtnActivo"
        Me.RDBtnActivo.Size = New System.Drawing.Size(69, 24)
        Me.RDBtnActivo.TabIndex = 4
        Me.RDBtnActivo.TabStop = True
        Me.RDBtnActivo.Text = "Activo"
        Me.RDBtnActivo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 87)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Identificador:"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(123, 87)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(201, 27)
        Me.txtNombre.TabIndex = 1
        '
        'txt_id
        '
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_id.Location = New System.Drawing.Point(123, 48)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(140, 27)
        Me.txt_id.TabIndex = 0
        '
        'GbRegistros
        '
        Me.GbRegistros.AccessibleName = ""
        Me.GbRegistros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbRegistros.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GbRegistros.Controls.Add(Me.BtnBuscar)
        Me.GbRegistros.Controls.Add(Me.TxtValor)
        Me.GbRegistros.Controls.Add(Me.DvGRegistros)
        Me.GbRegistros.Font = New System.Drawing.Font("Microsoft YaHei Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbRegistros.Location = New System.Drawing.Point(2, 182)
        Me.GbRegistros.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GbRegistros.Name = "GbRegistros"
        Me.GbRegistros.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GbRegistros.Size = New System.Drawing.Size(482, 228)
        Me.GbRegistros.TabIndex = 5
        Me.GbRegistros.TabStop = False
        Me.GbRegistros.Text = "Registros Guardados "
        '
        'DvGRegistros
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.DvGRegistros.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DvGRegistros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DvGRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DvGRegistros.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DvGRegistros.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft YaHei Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DvGRegistros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DvGRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DvGRegistros.EnableHeadersVisualStyles = False
        Me.DvGRegistros.GridColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.DvGRegistros.Location = New System.Drawing.Point(14, 65)
        Me.DvGRegistros.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DvGRegistros.Name = "DvGRegistros"
        Me.DvGRegistros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft YaHei Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DvGRegistros.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.DvGRegistros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(120, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DvGRegistros.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DvGRegistros.RowTemplate.Height = 24
        Me.DvGRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DvGRegistros.Size = New System.Drawing.Size(453, 144)
        Me.DvGRegistros.TabIndex = 2
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(14, 25)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(372, 27)
        Me.TxtValor.TabIndex = 3
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BtnBuscar.Location = New System.Drawing.Point(392, 25)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 27)
        Me.BtnBuscar.TabIndex = 4
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'FrmCiudad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(487, 429)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmCiudad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion de Ciudades"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbRegistros.ResumeLayout(False)
        Me.GbRegistros.PerformLayout()
        CType(Me.DvGRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_nuevo As ToolStripButton
    Friend WithEvents btn_guardar As ToolStripButton
    Friend WithEvents btn_editar As ToolStripButton
    Friend WithEvents Btn_Eliminar As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GbRegistros As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RDBtnActivo As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents DvGRegistros As DataGridView
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtValor As TextBox
End Class
