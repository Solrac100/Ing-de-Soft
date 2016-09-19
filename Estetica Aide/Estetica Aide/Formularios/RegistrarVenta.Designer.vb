<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarVenta))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(23, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(190, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "SERVICIO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DESCRIPCION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MONTO      $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DESCRIPCION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(363, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "CANTIDAD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "TOTAL        $"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(239, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "RECIBIDO         $"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(106, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(431, 81)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(64, 20)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(33, 149)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(249, 20)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(358, 149)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(67, 20)
        Me.TextBox4.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(445, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 24)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "AÑADIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(288, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 24)
        Me.Button2.TabIndex = 12
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DESCRIPCION, Me.CANTIDAD, Me.MONTO})
        Me.DataGridView1.Location = New System.Drawing.Point(33, 193)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(343, 47)
        Me.DataGridView1.TabIndex = 13
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        '
        'CANTIDAD
        '
        Me.CANTIDAD.HeaderText = "CANTIDAD"
        Me.CANTIDAD.Name = "CANTIDAD"
        '
        'MONTO
        '
        Me.MONTO.HeaderText = "MONTO"
        Me.MONTO.Name = "MONTO"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(106, 274)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(69, 20)
        Me.TextBox5.TabIndex = 14
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(336, 274)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(70, 20)
        Me.TextBox6.TabIndex = 15
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(445, 270)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 24)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "ACEPTAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RegistrarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 317)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "RegistrarVenta"
        Me.Text = "REGISTRAR VENTA"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DESCRIPCION As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents MONTO As DataGridViewTextBoxColumn
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button3 As Button
End Class
