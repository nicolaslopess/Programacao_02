Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices

Public Class criarConta
    Dim caminhoDadosUser As String
    Private Sub criarConta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        caminhoDadosUser = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..")) & "\componentes\Dados\Usuarios.csv"
    End Sub

    Private Sub saveCA_Click(sender As Object, e As EventArgs) Handles saveCA.Click

        Dim linhas As String(,) = carregarCSV(caminhoDadosUser)
        Dim numeroLinhas As Integer = linhas.GetLength(0) - 1

        If (linhas.Length <> 0) Then
            Dim userJaExiste As Boolean = False
            Dim idJaExiste As Boolean = False
            Dim maiorNumero As Integer = 0

            For c As Integer = 0 To linhas.GetLength(0) - 1
                If UsernameCA.Text = linhas(c, 1) Then
                    userJaExiste = True
                End If
                If numeroLinhas = linhas(c, 0) Then
                    idJaExiste = True

                End If
            Next

            If idJaExiste = True Then
                For c As Integer = 0 To linhas.GetLength(0) - 1

                    If linhas(c, 0) >= maiorNumero Then
                        maiorNumero = linhas(c, 0)
                    End If
                Next
            End If

            If userJaExiste = False Then
                Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to create the user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If confirmResult = DialogResult.Yes Then
                    FileOpen(1, caminhoDadosUser, OpenMode.Append)
                    Write(1, If(idJaExiste, maiorNumero + 1, numeroLinhas + 1))
                    Write(1, UsernameCA.Text.Replace("""", ""))
                    WriteLine(1, PasswordCA.Text.Replace("""", ""))
                    FileClose(1)

                    MessageBox.Show("User created successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Login.Show()
                    Me.Close()
                End If

            Else
                MessageBox.Show("UserName already used", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UsernameCA.Text = ""
                PasswordCA.Text = ""
            End If
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

        'colocar dados nos vetor
        For x = 0 To numeroLinhas - 1
            Dim linhaVetor As String() = linhas(x).Split(","c)
            For y = 0 To numeroColunas - 1
                valores(x, y) = linhaVetor(y).Replace("""", "")
            Next
        Next

        Return valores
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UsernameCA.Text = ""
        PasswordCA.Text = ""
        Login.Show()
        Me.Close()
    End Sub
End Class