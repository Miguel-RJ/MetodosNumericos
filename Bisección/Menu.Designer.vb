<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.CBSelect = New System.Windows.Forms.ComboBox()
        Me.Ir = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CBSelect
        '
        Me.CBSelect.FormattingEnabled = True
        Me.CBSelect.Items.AddRange(New Object() {"Primer Parcial", "Segundo Parcial"})
        Me.CBSelect.Location = New System.Drawing.Point(40, 12)
        Me.CBSelect.Name = "CBSelect"
        Me.CBSelect.Size = New System.Drawing.Size(215, 21)
        Me.CBSelect.TabIndex = 0
        '
        'Ir
        '
        Me.Ir.Location = New System.Drawing.Point(214, 120)
        Me.Ir.Name = "Ir"
        Me.Ir.Size = New System.Drawing.Size(75, 23)
        Me.Ir.TabIndex = 1
        Me.Ir.Text = "Ir"
        Me.Ir.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(12, 120)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 2
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 155)
        Me.Controls.Add(Me.CBSelect)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Ir)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CBSelect As ComboBox
    Friend WithEvents Ir As Button
    Friend WithEvents Salir As Button
End Class
