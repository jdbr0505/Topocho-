<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DatabaseForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatabaseForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombrePelicula = New System.Windows.Forms.TextBox()
        Me.txtGeneroPelicula = New System.Windows.Forms.TextBox()
        Me.txtFechaLanzamiento = New System.Windows.Forms.TextBox()
        Me.txtNombreDirector = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCredits = New System.Windows.Forms.Button()
        Me.TopochoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeliculaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeLanzamientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirectorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Topocho = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.TopochoDatabaseDataSet = New Pelidata.TopochoDatabaseDataSet()
        Me.TopochoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopochoTableAdapter = New Pelidata.TopochoDatabaseDataSetTableAdapters.TopochoTableAdapter()
        Me.IDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeliculaDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneroDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeLanzamientoDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirectorDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TopochoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Topocho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopochoDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopochoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre de la Pelicula:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(349, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha de Lanzamiento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(363, 347)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre del Director:"
        '
        'txtNombrePelicula
        '
        Me.txtNombrePelicula.Location = New System.Drawing.Point(224, 296)
        Me.txtNombrePelicula.Name = "txtNombrePelicula"
        Me.txtNombrePelicula.Size = New System.Drawing.Size(114, 20)
        Me.txtNombrePelicula.TabIndex = 6
        '
        'txtGeneroPelicula
        '
        Me.txtGeneroPelicula.Location = New System.Drawing.Point(191, 347)
        Me.txtGeneroPelicula.Name = "txtGeneroPelicula"
        Me.txtGeneroPelicula.Size = New System.Drawing.Size(147, 20)
        Me.txtGeneroPelicula.TabIndex = 7
        '
        'txtFechaLanzamiento
        '
        Me.txtFechaLanzamiento.Location = New System.Drawing.Point(568, 293)
        Me.txtFechaLanzamiento.Name = "txtFechaLanzamiento"
        Me.txtFechaLanzamiento.Size = New System.Drawing.Size(150, 20)
        Me.txtFechaLanzamiento.TabIndex = 8
        '
        'txtNombreDirector
        '
        Me.txtNombreDirector.Location = New System.Drawing.Point(568, 347)
        Me.txtNombreDirector.Name = "txtNombreDirector"
        Me.txtNombreDirector.Size = New System.Drawing.Size(150, 20)
        Me.txtNombreDirector.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 347)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Genero:"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Britannic Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnAdd.Location = New System.Drawing.Point(568, 91)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(137, 43)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Guardar"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCredits
        '
        Me.btnCredits.Font = New System.Drawing.Font("Britannic Bold", 15.0!)
        Me.btnCredits.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCredits.Location = New System.Drawing.Point(568, 140)
        Me.btnCredits.Name = "btnCredits"
        Me.btnCredits.Size = New System.Drawing.Size(137, 43)
        Me.btnCredits.TabIndex = 12
        Me.btnCredits.Text = "Creditos"
        Me.btnCredits.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(-2, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(420, 79)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Bienvenido"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(424, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'PeliculaDataGridViewTextBoxColumn
        '
        Me.PeliculaDataGridViewTextBoxColumn.Name = "PeliculaDataGridViewTextBoxColumn"
        '
        'GeneroDataGridViewTextBoxColumn
        '
        Me.GeneroDataGridViewTextBoxColumn.Name = "GeneroDataGridViewTextBoxColumn"
        '
        'FechaDeLanzamientoDataGridViewTextBoxColumn
        '
        Me.FechaDeLanzamientoDataGridViewTextBoxColumn.Name = "FechaDeLanzamientoDataGridViewTextBoxColumn"
        '
        'DirectorDataGridViewTextBoxColumn
        '
        Me.DirectorDataGridViewTextBoxColumn.Name = "DirectorDataGridViewTextBoxColumn"
        '
        'Topocho
        '
        Me.Topocho.AutoGenerateColumns = False
        Me.Topocho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Topocho.DataSource = Me.TopochoBindingSource
        Me.Topocho.Location = New System.Drawing.Point(12, 114)
        Me.Topocho.Name = "Topocho"
        Me.Topocho.Size = New System.Drawing.Size(544, 150)
        Me.Topocho.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn3, Me.PeliculaDataGridViewTextBoxColumn3, Me.GeneroDataGridViewTextBoxColumn3, Me.FechaDeLanzamientoDataGridViewTextBoxColumn3, Me.DirectorDataGridViewTextBoxColumn3})
        Me.DataGridView1.DataSource = Me.TopochoBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(538, 188)
        Me.DataGridView1.TabIndex = 16
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Britannic Bold", 15.0!)
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnUpdate.Location = New System.Drawing.Point(568, 189)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(137, 40)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Actualizar"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Britannic Bold", 15.0!)
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnDelete.Location = New System.Drawing.Point(568, 235)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(137, 44)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Borrar"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'TopochoDatabaseDataSet
        '
        Me.TopochoDatabaseDataSet.DataSetName = "TopochoDatabaseDataSet"
        Me.TopochoDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TopochoBindingSource1
        '
        Me.TopochoBindingSource1.DataMember = "Topocho"
        Me.TopochoBindingSource1.DataSource = Me.TopochoDatabaseDataSet
        '
        'TopochoTableAdapter
        '
        Me.TopochoTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn3
        '
        Me.IDDataGridViewTextBoxColumn3.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn3.Name = "IDDataGridViewTextBoxColumn3"
        '
        'PeliculaDataGridViewTextBoxColumn3
        '
        Me.PeliculaDataGridViewTextBoxColumn3.DataPropertyName = "Pelicula"
        Me.PeliculaDataGridViewTextBoxColumn3.HeaderText = "Pelicula"
        Me.PeliculaDataGridViewTextBoxColumn3.Name = "PeliculaDataGridViewTextBoxColumn3"
        '
        'GeneroDataGridViewTextBoxColumn3
        '
        Me.GeneroDataGridViewTextBoxColumn3.DataPropertyName = "Genero"
        Me.GeneroDataGridViewTextBoxColumn3.HeaderText = "Genero"
        Me.GeneroDataGridViewTextBoxColumn3.Name = "GeneroDataGridViewTextBoxColumn3"
        '
        'FechaDeLanzamientoDataGridViewTextBoxColumn3
        '
        Me.FechaDeLanzamientoDataGridViewTextBoxColumn3.DataPropertyName = "Fecha de lanzamiento"
        Me.FechaDeLanzamientoDataGridViewTextBoxColumn3.HeaderText = "Fecha de lanzamiento"
        Me.FechaDeLanzamientoDataGridViewTextBoxColumn3.Name = "FechaDeLanzamientoDataGridViewTextBoxColumn3"
        '
        'DirectorDataGridViewTextBoxColumn3
        '
        Me.DirectorDataGridViewTextBoxColumn3.DataPropertyName = "Director"
        Me.DirectorDataGridViewTextBoxColumn3.HeaderText = "Director"
        Me.DirectorDataGridViewTextBoxColumn3.Name = "DirectorDataGridViewTextBoxColumn3"
        '
        'DatabaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(767, 382)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCredits)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombreDirector)
        Me.Controls.Add(Me.txtFechaLanzamiento)
        Me.Controls.Add(Me.txtGeneroPelicula)
        Me.Controls.Add(Me.txtNombrePelicula)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "DatabaseForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Topocho+"
        CType(Me.TopochoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Topocho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopochoDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopochoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombrePelicula As TextBox
    Friend WithEvents txtGeneroPelicula As TextBox
    Friend WithEvents txtFechaLanzamiento As TextBox
    Friend WithEvents txtNombreDirector As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCredits As Button

    Friend WithEvents TopochoBindingSource As BindingSource
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeliculaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GeneroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeLanzamientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DirectorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Topocho As DataGridView
    Friend WithEvents DataGridView1 As DataGridView


    Private Sub DatabaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PeliculaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GeneroDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeLanzamientoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DirectorDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Friend WithEvents IDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents PeliculaDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents GeneroDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeLanzamientoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DirectorDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents TopochoDatabaseDataSet As TopochoDatabaseDataSet
    Friend WithEvents TopochoBindingSource1 As BindingSource
    Friend WithEvents TopochoTableAdapter As TopochoDatabaseDataSetTableAdapters.TopochoTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents PeliculaDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents GeneroDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeLanzamientoDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DirectorDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
