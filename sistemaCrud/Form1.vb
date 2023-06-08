Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Login
    Dim caminhoDadosUser As String

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        caminhoDadosUser = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..")) & "\componentes\Dados\Usuarios.csv"
    End Sub
    Private Sub createAccountLogin_Click(sender As Object, e As EventArgs) Handles createAccountLogin.Click
        criarConta.Show()
    End Sub

    Private Sub saveLogin_Click(sender As Object, e As EventArgs) Handles saveLogin.Click
        Dim users As String(,) = carregarCSV(caminhoDadosUser)
        Dim validarUser As Boolean = False
        If (users.Length <> 0) Then
            For c As Integer = 0 To users.GetLength(0) - 1
                If (users.GetLength(1) >= 3 And UsernameLogin.Text = users(c, 1) And PasswordLogin.Text = users(c, 2)) Then
                    validarUser = True
                    UsernameLogin.Text = ""
                    PasswordLogin.Text = ""
                    FormMenu.Show()
                    'Me.Hide()
                End If
            Next

        End If

        If (validarUser = False) Then
            UsernameLogin.Text = ""
            PasswordLogin.Text = ""
            MessageBox.Show("Incorrect Username or Password", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Function carregarCSV(ByVal caminho As String) As String(,)

        Dim arquivoCSV As String = File.ReadAllText(caminho)
        Dim x, y As Integer

        arquivoCSV = arquivoCSV.Replace(ControlChars.Lf, ControlChars.Cr)
        Dim linhas As String() = arquivoCSV.Split(New Char() {ControlChars.Cr}, StringSplitOptions.RemoveEmptyEntries)

        Dim numeroLinhas = linhas.Length
        Dim numeroColunas = linhas(0).Split(","c).Length

        Dim valores As String(,) = New String(numeroLinhas - 1, numeroColunas - 1) {}

        For x = 0 To numeroLinhas - 1
            Dim linhaVetor As String() = linhas(x).Split(","c)
            For y = 0 To numeroColunas - 1
                valores(x, y) = linhaVetor(y).Replace("""", "")
            Next
        Next

        Return valores
    End Function

    Private Sub cancelLogin_Click(sender As Object, e As EventArgs) Handles cancelLogin.Click
        UsernameLogin.Text = ""
        PasswordLogin.Text = ""
        Me.Close()
    End Sub


End Class
