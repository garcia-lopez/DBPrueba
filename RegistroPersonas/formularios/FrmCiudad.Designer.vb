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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RDBtnActivo = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.GbRegistros = New System.Windows.Forms.GroupBox()
        Me.DvGRegistros = New System.Windows.Forms.DataGridView()
        Me.btn_nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_guardar = New System.Windows.Forms.ToolStripButton()
        Me.btn_editar = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Eliminar = New System.Windows.Forms.ToolStripButton()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(649, 31)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GbRegistros)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 497)
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
        Me.GroupBox1.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(643, 218)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Ciudad"
        '
        'RDBtnActivo
        '
        Me.RDBtnActivo.AutoSize = True
        Me.RDBtnActivo.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDBtnActivo.Location = New System.Drawing.Point(356, 57)
        Me.RDBtnActivo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RDBtnActivo.Name = "RDBtnActivo"
        Me.RDBtnActivo.Size = New System.Drawing.Size(83, 27)
        Me.RDBtnActivo.TabIndex = 4
        Me.RDBtnActivo.TabStop = True
        Me.RDBtnActivo.Text = "Activo"
        Me.RDBtnActivo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Identificador:"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(164, 107)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(267, 31)
        Me.txtNombre.TabIndex = 1
        '
        'txt_id
        '
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_id.Location = New System.Drawing.Point(164, 59)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(186, 31)
        Me.txt_id.TabIndex = 0
        '
        'GbRegistros
        '
        Me.GbRegistros.AccessibleName = ""
        Me.GbRegistros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbRegistros.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GbRegistros.Controls.Add(Me.DvGRegistros)
        Me.GbRegistros.Font = New System.Drawing.Font("Microsoft YaHei Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbRegistros.Location = New System.Drawing.Point(3, 224)
        Me.GbRegistros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GbRegistros.Name = "GbRegistros"
        Me.GbRegistros.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GbRegistros.Size = New System.Drawing.Size(643, 283)
        Me.GbRegistros.TabIndex = 5
        Me.GbRegistros.TabStop = False
        Me.GbRegistros.Text = "Registros Guardados "
        '
        'DvGRegistros
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.DvGRegistros.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DvGRegistros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DvGRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DvGRegistros.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DvGRegistros.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei Light", 10.8!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DvGRegistros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DvGRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DvGRegistros.EnableHeadersVisualStyles = False
        Me.DvGRegistros.GridColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.DvGRegistros.Location = New System.Drawing.Point(9, 36)
        Me.DvGRegistros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DvGRegistros.Name = "DvGRegistros"
        Me.DvGRegistros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft YaHei Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DvGRegistros.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DvGRegistros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Empty
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(120, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DvGRegistros.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DvGRegistros.RowTemplate.Height = 24
        Me.DvGRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DvGRegistros.Size = New System.Drawing.Size(625, 228)
        Me.DvGRegistros.TabIndex = 2
        '
        'btn_nuevo
        '
        Me.btn_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_nuevo.Image = Global.RegistroPersonas.My.Resources.Resources.btn_nuevo
        Me.btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(29, 28)
        Me.btn_nuevo.Text = "Nuevo"
        '
        'btn_guardar
        '
        Me.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_guardar.Image = Global.RegistroPersonas.My.Resources.Resources.BtnGuardar
        Me.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(29, 28)
        Me.btn_guardar.Text = "ToolStripButton2"
        Me.btn_guardar.ToolTipText = "Guardar"
        '
        'btn_editar
        '
        Me.btn_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_editar.Image = Global.RegistroPersonas.My.Resources.Resources.BtnEditar
        Me.btn_editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(29, 28)
        Me.btn_editar.Text = "Editar"
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Eliminar.Image = Global.RegistroPersonas.My.Resources.Resources.BtnBorrar
        Me.Btn_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(29, 28)
        Me.Btn_Eliminar.Text = "Eliminar"
        '
        'FrmCiudad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(649, 528)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmCiudad"
        Me.Text = "Gestion de Ciudades"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbRegistros.ResumeLayout(False)
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
End Class
