<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.AllowDrop = True
        Me.Button1.AutoEllipsis = True
        Me.Button1.Location = New System.Drawing.Point(23, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Clientes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AllowDrop = True
        Me.Button2.AutoEllipsis = True
        Me.Button2.Location = New System.Drawing.Point(508, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Inventario"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AllowDrop = True
        Me.Button3.AutoEllipsis = True
        Me.Button3.Location = New System.Drawing.Point(23, 162)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Agenda"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.AllowDrop = True
        Me.Button4.AutoEllipsis = True
        Me.Button4.Location = New System.Drawing.Point(23, 68)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(148, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Venta"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.AllowDrop = True
        Me.Button5.AutoEllipsis = True
        Me.Button5.Location = New System.Drawing.Point(23, 116)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(148, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Gastos"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.AllowDrop = True
        Me.Button6.AutoEllipsis = True
        Me.Button6.Location = New System.Drawing.Point(508, 68)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(148, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Reportes "
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.AllowDrop = True
        Me.Button7.AutoEllipsis = True
        Me.Button7.Location = New System.Drawing.Point(508, 116)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(148, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Corte de Caja"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.AllowDrop = True
        Me.Button8.AutoEllipsis = True
        Me.Button8.Location = New System.Drawing.Point(508, 162)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(148, 23)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Responsivas"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 213)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
