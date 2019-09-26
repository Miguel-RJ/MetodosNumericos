<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SegundoParcial
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
        Me.lx1 = New System.Windows.Forms.Label()
        Me.lx2 = New System.Windows.Forms.Label()
        Me.lx3 = New System.Windows.Forms.Label()
        Me.ly3 = New System.Windows.Forms.Label()
        Me.ly2 = New System.Windows.Forms.Label()
        Me.ly1 = New System.Windows.Forms.Label()
        Me.lz3 = New System.Windows.Forms.Label()
        Me.lz2 = New System.Windows.Forms.Label()
        Me.lz1 = New System.Windows.Forms.Label()
        Me.a11 = New System.Windows.Forms.TextBox()
        Me.a21 = New System.Windows.Forms.TextBox()
        Me.a31 = New System.Windows.Forms.TextBox()
        Me.a32 = New System.Windows.Forms.TextBox()
        Me.a22 = New System.Windows.Forms.TextBox()
        Me.a12 = New System.Windows.Forms.TextBox()
        Me.a33 = New System.Windows.Forms.TextBox()
        Me.a23 = New System.Windows.Forms.TextBox()
        Me.a13 = New System.Windows.Forms.TextBox()
        Me.lcifras = New System.Windows.Forms.Label()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.CBSeleccion = New System.Windows.Forms.ComboBox()
        Me.b3 = New System.Windows.Forms.TextBox()
        Me.b2 = New System.Windows.Forms.TextBox()
        Me.b1 = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lresultado = New System.Windows.Forms.Label()
        Me.Pares = New System.Windows.Forms.Button()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lx1
        '
        Me.lx1.AutoSize = True
        Me.lx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lx1.Location = New System.Drawing.Point(62, 58)
        Me.lx1.Name = "lx1"
        Me.lx1.Size = New System.Drawing.Size(33, 20)
        Me.lx1.TabIndex = 0
        Me.lx1.Text = "x  +"
        '
        'lx2
        '
        Me.lx2.AutoSize = True
        Me.lx2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lx2.Location = New System.Drawing.Point(62, 93)
        Me.lx2.Name = "lx2"
        Me.lx2.Size = New System.Drawing.Size(33, 20)
        Me.lx2.TabIndex = 1
        Me.lx2.Text = "x  +"
        '
        'lx3
        '
        Me.lx3.AutoSize = True
        Me.lx3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lx3.Location = New System.Drawing.Point(62, 131)
        Me.lx3.Name = "lx3"
        Me.lx3.Size = New System.Drawing.Size(33, 20)
        Me.lx3.TabIndex = 2
        Me.lx3.Text = "x  +"
        '
        'ly3
        '
        Me.ly3.AutoSize = True
        Me.ly3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ly3.Location = New System.Drawing.Point(128, 131)
        Me.ly3.Name = "ly3"
        Me.ly3.Size = New System.Drawing.Size(33, 20)
        Me.ly3.TabIndex = 5
        Me.ly3.Text = "y  +"
        '
        'ly2
        '
        Me.ly2.AutoSize = True
        Me.ly2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ly2.Location = New System.Drawing.Point(128, 93)
        Me.ly2.Name = "ly2"
        Me.ly2.Size = New System.Drawing.Size(33, 20)
        Me.ly2.TabIndex = 4
        Me.ly2.Text = "y  +"
        '
        'ly1
        '
        Me.ly1.AutoSize = True
        Me.ly1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ly1.Location = New System.Drawing.Point(128, 58)
        Me.ly1.Name = "ly1"
        Me.ly1.Size = New System.Drawing.Size(33, 20)
        Me.ly1.TabIndex = 3
        Me.ly1.Text = "y  +"
        '
        'lz3
        '
        Me.lz3.AutoSize = True
        Me.lz3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lz3.Location = New System.Drawing.Point(196, 131)
        Me.lz3.Name = "lz3"
        Me.lz3.Size = New System.Drawing.Size(34, 20)
        Me.lz3.TabIndex = 8
        Me.lz3.Text = "z  ="
        '
        'lz2
        '
        Me.lz2.AutoSize = True
        Me.lz2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lz2.Location = New System.Drawing.Point(196, 93)
        Me.lz2.Name = "lz2"
        Me.lz2.Size = New System.Drawing.Size(34, 20)
        Me.lz2.TabIndex = 7
        Me.lz2.Text = "z  ="
        '
        'lz1
        '
        Me.lz1.AutoSize = True
        Me.lz1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lz1.Location = New System.Drawing.Point(196, 58)
        Me.lz1.Name = "lz1"
        Me.lz1.Size = New System.Drawing.Size(34, 20)
        Me.lz1.TabIndex = 6
        Me.lz1.Text = "z  ="
        '
        'a11
        '
        Me.a11.Location = New System.Drawing.Point(27, 58)
        Me.a11.Name = "a11"
        Me.a11.Size = New System.Drawing.Size(34, 20)
        Me.a11.TabIndex = 9
        '
        'a21
        '
        Me.a21.Location = New System.Drawing.Point(27, 93)
        Me.a21.Name = "a21"
        Me.a21.Size = New System.Drawing.Size(34, 20)
        Me.a21.TabIndex = 10
        '
        'a31
        '
        Me.a31.Location = New System.Drawing.Point(27, 131)
        Me.a31.Name = "a31"
        Me.a31.Size = New System.Drawing.Size(34, 20)
        Me.a31.TabIndex = 11
        '
        'a32
        '
        Me.a32.Location = New System.Drawing.Point(94, 131)
        Me.a32.Name = "a32"
        Me.a32.Size = New System.Drawing.Size(34, 20)
        Me.a32.TabIndex = 14
        '
        'a22
        '
        Me.a22.Location = New System.Drawing.Point(94, 93)
        Me.a22.Name = "a22"
        Me.a22.Size = New System.Drawing.Size(34, 20)
        Me.a22.TabIndex = 13
        '
        'a12
        '
        Me.a12.Location = New System.Drawing.Point(94, 58)
        Me.a12.Name = "a12"
        Me.a12.Size = New System.Drawing.Size(34, 20)
        Me.a12.TabIndex = 12
        '
        'a33
        '
        Me.a33.Location = New System.Drawing.Point(162, 131)
        Me.a33.Name = "a33"
        Me.a33.Size = New System.Drawing.Size(34, 20)
        Me.a33.TabIndex = 17
        '
        'a23
        '
        Me.a23.Location = New System.Drawing.Point(162, 93)
        Me.a23.Name = "a23"
        Me.a23.Size = New System.Drawing.Size(34, 20)
        Me.a23.TabIndex = 16
        '
        'a13
        '
        Me.a13.Location = New System.Drawing.Point(162, 58)
        Me.a13.Name = "a13"
        Me.a13.Size = New System.Drawing.Size(34, 20)
        Me.a13.TabIndex = 15
        '
        'lcifras
        '
        Me.lcifras.AutoSize = True
        Me.lcifras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcifras.Location = New System.Drawing.Point(318, 58)
        Me.lcifras.Name = "lcifras"
        Me.lcifras.Size = New System.Drawing.Size(98, 20)
        Me.lcifras.TabIndex = 18
        Me.lcifras.Text = "Dame cifras:"
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(422, 60)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(34, 20)
        Me.tc.TabIndex = 19
        '
        'CBSeleccion
        '
        Me.CBSeleccion.FormattingEnabled = True
        Me.CBSeleccion.Items.AddRange(New Object() {"Jacobi", "Gauss-Seidel"})
        Me.CBSeleccion.Location = New System.Drawing.Point(27, 13)
        Me.CBSeleccion.Name = "CBSeleccion"
        Me.CBSeleccion.Size = New System.Drawing.Size(203, 21)
        Me.CBSeleccion.TabIndex = 20
        '
        'b3
        '
        Me.b3.Location = New System.Drawing.Point(236, 131)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(34, 20)
        Me.b3.TabIndex = 23
        '
        'b2
        '
        Me.b2.Location = New System.Drawing.Point(236, 93)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(34, 20)
        Me.b2.TabIndex = 22
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(236, 58)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(34, 20)
        Me.b1.TabIndex = 21
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(487, 60)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 24
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(487, 89)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Limpiar.TabIndex = 25
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(487, 118)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 26
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.Salida.Location = New System.Drawing.Point(27, 188)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(704, 150)
        Me.Salida.TabIndex = 27
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column1.HeaderText = "Índice"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.Width = 61
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
        'Column4
        '
        Me.Column4.HeaderText = "Z"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "E(X)"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "E(Y)"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "E(Z)"
        Me.Column7.Name = "Column7"
        '
        'lresultado
        '
        Me.lresultado.AutoSize = True
        Me.lresultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lresultado.Location = New System.Drawing.Point(23, 378)
        Me.lresultado.Name = "lresultado"
        Me.lresultado.Size = New System.Drawing.Size(0, 20)
        Me.lresultado.TabIndex = 28
        Me.lresultado.Visible = False
        '
        'Pares
        '
        Me.Pares.Location = New System.Drawing.Point(597, 60)
        Me.Pares.Name = "Pares"
        Me.Pares.Size = New System.Drawing.Size(75, 23)
        Me.Pares.TabIndex = 29
        Me.Pares.Text = "Pares"
        Me.Pares.UseVisualStyleBackColor = True
        '
        'SegundoParcial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 450)
        Me.Controls.Add(Me.Pares)
        Me.Controls.Add(Me.lresultado)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.CBSeleccion)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.lcifras)
        Me.Controls.Add(Me.a33)
        Me.Controls.Add(Me.a23)
        Me.Controls.Add(Me.a13)
        Me.Controls.Add(Me.a32)
        Me.Controls.Add(Me.a22)
        Me.Controls.Add(Me.a12)
        Me.Controls.Add(Me.a31)
        Me.Controls.Add(Me.a21)
        Me.Controls.Add(Me.a11)
        Me.Controls.Add(Me.lz3)
        Me.Controls.Add(Me.lz2)
        Me.Controls.Add(Me.lz1)
        Me.Controls.Add(Me.ly3)
        Me.Controls.Add(Me.ly2)
        Me.Controls.Add(Me.ly1)
        Me.Controls.Add(Me.lx3)
        Me.Controls.Add(Me.lx2)
        Me.Controls.Add(Me.lx1)
        Me.Name = "SegundoParcial"
        Me.Text = "SegundoParcial"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lx1 As Label
    Friend WithEvents lx2 As Label
    Friend WithEvents lx3 As Label
    Friend WithEvents ly3 As Label
    Friend WithEvents ly2 As Label
    Friend WithEvents ly1 As Label
    Friend WithEvents lz3 As Label
    Friend WithEvents lz2 As Label
    Friend WithEvents lz1 As Label
    Friend WithEvents a11 As TextBox
    Friend WithEvents a21 As TextBox
    Friend WithEvents a31 As TextBox
    Friend WithEvents a32 As TextBox
    Friend WithEvents a22 As TextBox
    Friend WithEvents a12 As TextBox
    Friend WithEvents a33 As TextBox
    Friend WithEvents a23 As TextBox
    Friend WithEvents a13 As TextBox
    Friend WithEvents lcifras As Label
    Friend WithEvents tc As TextBox
    Friend WithEvents CBSeleccion As ComboBox
    Friend WithEvents b3 As TextBox
    Friend WithEvents b2 As TextBox
    Friend WithEvents b1 As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents lresultado As Label
    Friend WithEvents Pares As Button
End Class
