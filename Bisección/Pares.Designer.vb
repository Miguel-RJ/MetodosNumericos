﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pares
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtLimite = New System.Windows.Forms.TextBox()
        Me.LBLIngrese = New System.Windows.Forms.Label()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnCalculat = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txn = New System.Windows.Forms.TextBox()
        Me.listSalidas = New System.Windows.Forms.ListBox()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLimite
        '
        Me.txtLimite.Location = New System.Drawing.Point(165, 27)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Size = New System.Drawing.Size(100, 20)
        Me.txtLimite.TabIndex = 0
        '
        'LBLIngrese
        '
        Me.LBLIngrese.AutoSize = True
        Me.LBLIngrese.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLIngrese.Location = New System.Drawing.Point(17, 26)
        Me.LBLIngrese.Name = "LBLIngrese"
        Me.LBLIngrese.Size = New System.Drawing.Size(142, 18)
        Me.LBLIngrese.TabIndex = 1
        Me.LBLIngrese.Text = "Ingrese cuantas filas"
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Salida.Location = New System.Drawing.Point(20, 147)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(343, 149)
        Me.Salida.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "i"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "X"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Y"
        Me.Column3.Name = "Column3"
        '
        'BtnCalculat
        '
        Me.BtnCalculat.Location = New System.Drawing.Point(303, 7)
        Me.BtnCalculat.Name = "BtnCalculat"
        Me.BtnCalculat.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalculat.TabIndex = 3
        Me.BtnCalculat.Text = "Llenar"
        Me.BtnCalculat.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(303, 36)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(303, 65)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Limpiar.TabIndex = 5
        Me.Limpiar.Text = "BtnLimpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(303, 94)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 6
        Me.btnbuscar.Text = "Buscar X"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ingrese X a buscar"
        '
        'Txn
        '
        Me.Txn.Location = New System.Drawing.Point(165, 95)
        Me.Txn.Name = "Txn"
        Me.Txn.Size = New System.Drawing.Size(100, 20)
        Me.Txn.TabIndex = 7
        '
        'listSalidas
        '
        Me.listSalidas.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listSalidas.FormattingEnabled = True
        Me.listSalidas.ItemHeight = 23
        Me.listSalidas.Location = New System.Drawing.Point(412, 7)
        Me.listSalidas.Name = "listSalidas"
        Me.listSalidas.Size = New System.Drawing.Size(240, 280)
        Me.listSalidas.TabIndex = 9
        '
        'Pares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 332)
        Me.Controls.Add(Me.listSalidas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txn)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCalculat)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.LBLIngrese)
        Me.Controls.Add(Me.txtLimite)
        Me.Name = "Pares"
        Me.Text = "Pares"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLimite As TextBox
    Friend WithEvents LBLIngrese As Label
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents BtnCalculat As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Txn As TextBox
    Friend WithEvents listSalidas As ListBox
End Class
