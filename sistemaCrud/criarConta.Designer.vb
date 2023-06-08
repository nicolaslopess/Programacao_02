<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class criarConta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(criarConta))
        Me.saveCA = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PasswordCA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UsernameCA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'saveCA
        '
        Me.saveCA.Location = New System.Drawing.Point(505, 256)
        Me.saveCA.Name = "saveCA"
        Me.saveCA.Size = New System.Drawing.Size(75, 23)
        Me.saveCA.TabIndex = 15
        Me.saveCA.Text = "Save"
        Me.saveCA.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Password:"
        '
        'PasswordCA
        '
        Me.PasswordCA.Location = New System.Drawing.Point(248, 212)
        Me.PasswordCA.Name = "PasswordCA"
        Me.PasswordCA.Size = New System.Drawing.Size(332, 20)
        Me.PasswordCA.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Username:"
        '
        'UsernameCA
        '
        Me.UsernameCA.Location = New System.Drawing.Point(248, 164)
        Me.UsernameCA.Name = "UsernameCA"
        Me.UsernameCA.Size = New System.Drawing.Size(332, 20)
        Me.UsernameCA.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 42)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "CREATE ACCOUNT"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(424, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'criarConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.saveCA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PasswordCA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UsernameCA)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "criarConta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents saveCA As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordCA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents UsernameCA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
