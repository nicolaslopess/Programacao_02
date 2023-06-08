<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeletarCadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeletarCadastro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeletarDado = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.DataGridDel = New System.Windows.Forms.DataGridView()
        Me.Cancel = New System.Windows.Forms.Button()
        CType(Me.DataGridDel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(124, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Write which one you want to delete:"
        '
        'DeletarDado
        '
        Me.DeletarDado.Location = New System.Drawing.Point(311, 300)
        Me.DeletarDado.Name = "DeletarDado"
        Me.DeletarDado.Size = New System.Drawing.Size(366, 20)
        Me.DeletarDado.TabIndex = 10
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(559, 336)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(118, 27)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'DataGridDel
        '
        Me.DataGridDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridDel.Location = New System.Drawing.Point(127, 28)
        Me.DataGridDel.Name = "DataGridDel"
        Me.DataGridDel.Size = New System.Drawing.Size(550, 241)
        Me.DataGridDel.TabIndex = 8
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(435, 336)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(118, 27)
        Me.Cancel.TabIndex = 12
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'DeletarCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DeletarDado)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.DataGridDel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DeletarCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeletarCadastro"
        CType(Me.DataGridDel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DeletarDado As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents DataGridDel As DataGridView
    Friend WithEvents Cancel As Button
End Class
