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
        Me.lf = New System.Windows.Forms.Label()
        Me.la = New System.Windows.Forms.Label()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.ta = New System.Windows.Forms.TextBox()
        Me.tb = New System.Windows.Forms.TextBox()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lc = New System.Windows.Forms.Label()
        Me.lb = New System.Windows.Forms.Label()
        Me.salida2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.td = New System.Windows.Forms.TextBox()
        Me.lblderivada = New System.Windows.Forms.Label()
        Me.ti = New System.Windows.Forms.TextBox()
        Me.lblinicio = New System.Windows.Forms.Label()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lf
        '
        Me.lf.AutoSize = True
        Me.lf.Location = New System.Drawing.Point(12, 24)
        Me.lf.Name = "lf"
        Me.lf.Size = New System.Drawing.Size(83, 13)
        Me.lf.TabIndex = 0
        Me.lf.Text = "Ingrese función:"
        '
        'la
        '
        Me.la.AutoSize = True
        Me.la.Location = New System.Drawing.Point(12, 58)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(54, 13)
        Me.la.TabIndex = 1
        Me.la.Text = "Ingrese a:"
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(105, 21)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(100, 20)
        Me.tf.TabIndex = 4
        '
        'ta
        '
        Me.ta.Location = New System.Drawing.Point(105, 55)
        Me.ta.Name = "ta"
        Me.ta.Size = New System.Drawing.Size(100, 20)
        Me.ta.TabIndex = 5
        '
        'tb
        '
        Me.tb.Location = New System.Drawing.Point(105, 87)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(100, 20)
        Me.tb.TabIndex = 6
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(105, 121)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(100, 20)
        Me.tc.TabIndex = 7
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(240, 52)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 8
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(240, 87)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 9
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.Salida.Location = New System.Drawing.Point(12, 229)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(843, 150)
        Me.Salida.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "Índice"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "a"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "xi"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "b"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "f(a)"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "f(xi)"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "f(b)"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "error"
        Me.Column8.Name = "Column8"
        '
        'lc
        '
        Me.lc.AutoSize = True
        Me.lc.Location = New System.Drawing.Point(12, 124)
        Me.lc.Name = "lc"
        Me.lc.Size = New System.Drawing.Size(73, 13)
        Me.lc.TabIndex = 12
        Me.lc.Text = "Ingrese cifras:"
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.Location = New System.Drawing.Point(12, 90)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(54, 13)
        Me.lb.TabIndex = 11
        Me.lb.Text = "Ingrese b:"
        '
        'salida2
        '
        Me.salida2.AutoSize = True
        Me.salida2.Location = New System.Drawing.Point(12, 392)
        Me.salida2.Name = "salida2"
        Me.salida2.Size = New System.Drawing.Size(73, 13)
        Me.salida2.TabIndex = 13
        Me.salida2.Text = "Ingrese cifras:"
        Me.salida2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Bisección.My.Resources.Resources.CodeCogsEqn__1_
        Me.PictureBox1.Location = New System.Drawing.Point(349, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(470, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'td
        '
        Me.td.Location = New System.Drawing.Point(105, 158)
        Me.td.Name = "td"
        Me.td.Size = New System.Drawing.Size(100, 20)
        Me.td.TabIndex = 16
        '
        'lblderivada
        '
        Me.lblderivada.AutoSize = True
        Me.lblderivada.Location = New System.Drawing.Point(12, 161)
        Me.lblderivada.Name = "lblderivada"
        Me.lblderivada.Size = New System.Drawing.Size(86, 13)
        Me.lblderivada.TabIndex = 15
        Me.lblderivada.Text = "Ingrese derivada"
        '
        'ti
        '
        Me.ti.Location = New System.Drawing.Point(105, 193)
        Me.ti.Name = "ti"
        Me.ti.Size = New System.Drawing.Size(100, 20)
        Me.ti.TabIndex = 18
        '
        'lblinicio
        '
        Me.lblinicio.AutoSize = True
        Me.lblinicio.Location = New System.Drawing.Point(12, 196)
        Me.lblinicio.Name = "lblinicio"
        Me.lblinicio.Size = New System.Drawing.Size(69, 13)
        Me.lblinicio.TabIndex = 17
        Me.lblinicio.Text = "Ingrese inicio"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 420)
        Me.Controls.Add(Me.ti)
        Me.Controls.Add(Me.lblinicio)
        Me.Controls.Add(Me.td)
        Me.Controls.Add(Me.lblderivada)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.salida2)
        Me.Controls.Add(Me.lc)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.ta)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.la)
        Me.Controls.Add(Me.lf)
        Me.Name = "Form1"
        Me.Text = "Bisección"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lf As Label
    Friend WithEvents la As Label
    Friend WithEvents tf As TextBox
    Friend WithEvents ta As TextBox
    Friend WithEvents tb As TextBox
    Friend WithEvents tc As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents lc As Label
    Friend WithEvents lb As Label
    Friend WithEvents salida2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents td As TextBox
    Friend WithEvents lblderivada As Label
    Friend WithEvents ti As TextBox
    Friend WithEvents lblinicio As Label
End Class
