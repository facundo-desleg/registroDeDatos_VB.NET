<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Texmail = New System.Windows.Forms.TextBox()
        Me.TexNombre = New System.Windows.Forms.TextBox()
        Me.TexApellido = New System.Windows.Forms.TextBox()
        Me.Butcancelar = New System.Windows.Forms.Button()
        Me.Butaceptar = New System.Windows.Forms.Button()
        Me.Texedad = New System.Windows.Forms.TextBox()
        Me.DateFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TexCliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Texdireccion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Cursor = System.Windows.Forms.Cursors.No
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(254, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edad"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Cursor = System.Windows.Forms.Cursors.No
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(215, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 43)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Cursor = System.Windows.Forms.Cursors.No
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(210, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 43)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Cursor = System.Windows.Forms.Cursors.No
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(27, 399)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(298, 43)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha de Nacimiento"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Cursor = System.Windows.Forms.Cursors.No
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(265, 448)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 43)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Mail"
        Me.Label6.UseCompatibleTextRendering = True
        '
        'Texmail
        '
        Me.Texmail.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texmail.Location = New System.Drawing.Point(357, 448)
        Me.Texmail.Multiline = True
        Me.Texmail.Name = "Texmail"
        Me.Texmail.Size = New System.Drawing.Size(292, 33)
        Me.Texmail.TabIndex = 6
        '
        'TexNombre
        '
        Me.TexNombre.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexNombre.Location = New System.Drawing.Point(357, 208)
        Me.TexNombre.Multiline = True
        Me.TexNombre.Name = "TexNombre"
        Me.TexNombre.Size = New System.Drawing.Size(292, 33)
        Me.TexNombre.TabIndex = 8
        '
        'TexApellido
        '
        Me.TexApellido.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexApellido.Location = New System.Drawing.Point(357, 256)
        Me.TexApellido.Multiline = True
        Me.TexApellido.Name = "TexApellido"
        Me.TexApellido.Size = New System.Drawing.Size(292, 33)
        Me.TexApellido.TabIndex = 10
        '
        'Butcancelar
        '
        Me.Butcancelar.AutoSize = True
        Me.Butcancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Butcancelar.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butcancelar.ForeColor = System.Drawing.Color.White
        Me.Butcancelar.Location = New System.Drawing.Point(518, 513)
        Me.Butcancelar.Name = "Butcancelar"
        Me.Butcancelar.Size = New System.Drawing.Size(131, 39)
        Me.Butcancelar.TabIndex = 13
        Me.Butcancelar.Text = "Cancelar"
        Me.Butcancelar.UseVisualStyleBackColor = False
        '
        'Butaceptar
        '
        Me.Butaceptar.AutoSize = True
        Me.Butaceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Butaceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Butaceptar.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butaceptar.ForeColor = System.Drawing.Color.White
        Me.Butaceptar.Location = New System.Drawing.Point(229, 513)
        Me.Butaceptar.Name = "Butaceptar"
        Me.Butaceptar.Size = New System.Drawing.Size(131, 39)
        Me.Butaceptar.TabIndex = 14
        Me.Butaceptar.Text = "Aceptar"
        Me.Butaceptar.UseVisualStyleBackColor = False
        '
        'Texedad
        '
        Me.Texedad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texedad.Location = New System.Drawing.Point(357, 353)
        Me.Texedad.Multiline = True
        Me.Texedad.Name = "Texedad"
        Me.Texedad.Size = New System.Drawing.Size(292, 33)
        Me.Texedad.TabIndex = 16
        '
        'DateFecha
        '
        Me.DateFecha.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFecha.Location = New System.Drawing.Point(357, 404)
        Me.DateFecha.Name = "DateFecha"
        Me.DateFecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateFecha.Size = New System.Drawing.Size(292, 32)
        Me.DateFecha.TabIndex = 17
        Me.DateFecha.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(221, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(332, 45)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Registro de Datos"
        '
        'TexCliente
        '
        Me.TexCliente.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexCliente.Location = New System.Drawing.Point(357, 158)
        Me.TexCliente.Multiline = True
        Me.TexCliente.Name = "TexCliente"
        Me.TexCliente.Size = New System.Drawing.Size(292, 33)
        Me.TexCliente.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Cursor = System.Windows.Forms.Cursors.No
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(64, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(262, 43)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Numero de Cliente"
        Me.Label7.UseCompatibleTextRendering = True
        '
        'Texdireccion
        '
        Me.Texdireccion.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texdireccion.Location = New System.Drawing.Point(357, 304)
        Me.Texdireccion.Multiline = True
        Me.Texdireccion.Name = "Texdireccion"
        Me.Texdireccion.Size = New System.Drawing.Size(292, 33)
        Me.Texdireccion.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Cursor = System.Windows.Forms.Cursors.No
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(190, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 43)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Dirección"
        Me.Label8.UseCompatibleTextRendering = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(710, 622)
        Me.Controls.Add(Me.Texdireccion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TexCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateFecha)
        Me.Controls.Add(Me.Texedad)
        Me.Controls.Add(Me.Butaceptar)
        Me.Controls.Add(Me.Butcancelar)
        Me.Controls.Add(Me.TexApellido)
        Me.Controls.Add(Me.TexNombre)
        Me.Controls.Add(Me.Texmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar de datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Texmail As TextBox
    Friend WithEvents TexNombre As TextBox
    Friend WithEvents TexApellido As TextBox
    Friend WithEvents Texedad As TextBox
    Public WithEvents DateFecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TexCliente As TextBox
    Friend WithEvents Texdireccion As TextBox
    Public WithEvents Label1 As Label
    Public WithEvents Label3 As Label
    Public WithEvents Label4 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Label6 As Label
    Public WithEvents Butcancelar As Button
    Public WithEvents Butaceptar As Button
    Public WithEvents Label7 As Label
    Public WithEvents Label8 As Label
End Class
