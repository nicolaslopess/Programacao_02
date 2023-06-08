<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.UsernameLogin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PasswordLogin = New System.Windows.Forms.TextBox()
        Me.createAccountLogin = New System.Windows.Forms.Button()
        Me.cancelLogin = New System.Windows.Forms.Button()
        Me.saveLogin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLogin
        '
        Me.UsernameLogin.Location = New System.Drawing.Point(253, 203)
        Me.UsernameLogin.Name = "UsernameLogin"
        Me.UsernameLogin.Size = New System.Drawing.Size(332, 20)
        Me.UsernameLogin.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(250, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password:"
        '
        'PasswordLogin
        '
        Me.PasswordLogin.Location = New System.Drawing.Point(253, 251)
        Me.PasswordLogin.Name = "PasswordLogin"
        Me.PasswordLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordLogin.Size = New System.Drawing.Size(332, 20)
        Me.PasswordLogin.TabIndex = 3
        '
        'createAccountLogin
        '
        Me.createAccountLogin.Location = New System.Drawing.Point(253, 295)
        Me.createAccountLogin.Name = "createAccountLogin"
        Me.createAccountLogin.Size = New System.Drawing.Size(170, 23)
        Me.createAccountLogin.TabIndex = 5
        Me.createAccountLogin.Text = "Create Account"
        Me.createAccountLogin.UseVisualStyleBackColor = True
        '
        'cancelLogin
        '
        Me.cancelLogin.Location = New System.Drawing.Point(429, 295)
        Me.cancelLogin.Name = "cancelLogin"
        Me.cancelLogin.Size = New System.Drawing.Size(75, 23)
        Me.cancelLogin.TabIndex = 6
        Me.cancelLogin.Text = "Cancel"
        Me.cancelLogin.UseVisualStyleBackColor = True
        '
        'saveLogin
        '
        Me.saveLogin.Location = New System.Drawing.Point(510, 295)
        Me.saveLogin.Name = "saveLogin"
        Me.saveLogin.Size = New System.Drawing.Size(75, 23)
        Me.saveLogin.TabIndex = 7
        Me.saveLogin.Text = "Save"
        Me.saveLogin.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(360, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 135)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(373, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 47)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Main"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.saveLogin)
        Me.Controls.Add(Me.cancelLogin)
        Me.Controls.Add(Me.createAccountLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PasswordLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UsernameLogin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsernameLogin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordLogin As TextBox
    Friend WithEvents createAccountLogin As Button
    Friend WithEvents cancelLogin As Button
    Friend WithEvents saveLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
