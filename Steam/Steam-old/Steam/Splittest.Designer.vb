<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splittest
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
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usertype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Maths = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tecno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sport = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Usertype, Me.BirthDay, Me.Maths, Me.Tecno, Me.Sport, Me.Column1, Me.Column2})
        Me.grid.Location = New System.Drawing.Point(172, 38)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grid.Size = New System.Drawing.Size(260, 299)
        Me.grid.TabIndex = 4
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 40
        '
        'Usertype
        '
        Me.Usertype.HeaderText = "Student"
        Me.Usertype.Name = "Usertype"
        Me.Usertype.ReadOnly = True
        Me.Usertype.Width = 120
        '
        'BirthDay
        '
        Me.BirthDay.HeaderText = "BirthDay"
        Me.BirthDay.Name = "BirthDay"
        Me.BirthDay.ReadOnly = True
        Me.BirthDay.Width = 80
        '
        'Maths
        '
        Me.Maths.HeaderText = "Maths"
        Me.Maths.Name = "Maths"
        Me.Maths.ReadOnly = True
        Me.Maths.Width = 70
        '
        'Tecno
        '
        Me.Tecno.HeaderText = "Tecno"
        Me.Tecno.Name = "Tecno"
        Me.Tecno.ReadOnly = True
        Me.Tecno.Width = 70
        '
        'Sport
        '
        Me.Sport.HeaderText = "Sport"
        Me.Sport.Name = "Sport"
        Me.Sport.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Splittest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 500)
        Me.Controls.Add(Me.grid)
        Me.Name = "Splittest"
        Me.Text = "Form1"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usertype As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BirthDay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Maths As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tecno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sport As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
