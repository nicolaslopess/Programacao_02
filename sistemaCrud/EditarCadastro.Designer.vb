<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarCadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarCadastro))
        Me.DataGridEdit = New System.Windows.Forms.DataGridView()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.AlterarDado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NewPasswordEditar = New System.Windows.Forms.TextBox()
        Me.NewUsernameEditar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        CType(Me.DataGridEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridEdit
        '
        Me.DataGridEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEdit.Location = New System.Drawing.Point(121, 22)
        Me.DataGridEdit.Name = "DataGridEdit"
        Me.DataGridEdit.Size = New System.Drawing.Size(550, 241)
        Me.DataGridEdit.TabIndex = 0
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(553, 389)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(118, 27)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Editar"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'AlterarDado
        '
        Me.AlterarDado.Location = New System.Drawing.Point(305, 294)
        Me.AlterarDado.Name = "AlterarDado"
        Me.AlterarDado.Size = New System.Drawing.Size(366, 20)
        Me.AlterarDado.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(118, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Write which one you want to change:"
        '
        'NewPasswordEditar
        '
        Me.NewPasswordEditar.Location = New System.Drawing.Point(305, 353)
        Me.NewPasswordEditar.Name = "NewPasswordEditar"
        Me.NewPasswordEditar.Size = New System.Drawing.Size(366, 20)
        Me.NewPasswordEditar.TabIndex = 4
        '
        'NewUsernameEditar
        '
        Me.NewUsernameEditar.Location = New System.Drawing.Point(305, 323)
        Me.NewUsernameEditar.Name = "NewUsernameEditar"
        Me.NewUsernameEditar.Size = New System.Drawing.Size(366, 20)
        Me.NewUsernameEditar.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(218, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "New Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(216, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "New Username:"
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(429, 389)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(118, 27)
        Me.Cancel.TabIndex = 8
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'EditarCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NewUsernameEditar)
        Me.Controls.Add(Me.NewPasswordEditar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AlterarDado)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.DataGridEdit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditarCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarCadastro"
        CType(Me.DataGridEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridEdit As DataGridView
    Friend WithEvents btnEdit As Button
    Friend WithEvents AlterarDado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NewPasswordEditar As TextBox
    Friend WithEvents NewUsernameEditar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Cancel As Button
End Class
