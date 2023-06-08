Imports System.IO
Public Class EditarCadastro

    Dim caminhoDadosUser As String
    Dim dt As New DataTable()
    Private Sub EditarCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        caminhoDadosUser = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..")) & "\componentes\Dados\Usuarios.csv"
        carregarDataGrid()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to edit the user?", "", MessageBoxButtons.YesNo)

        Dim lines As List(Of String) = File.ReadAllLines(caminhoDadosUser).ToList()


        Dim maxIndex As Integer = -1
        For Each line As String In lines
            Dim index As Integer = CInt(line.Split(",")(0))
            If index > maxIndex Then
                maxIndex = index
            End If
        Next

        Dim dadosDeletar As String = AlterarDado.Text

        If confirmResult = DialogResult.Yes Then
            Dim index As Integer = -1
            For i As Integer = 0 To lines.Count - 1
                If lines(i).StartsWith(dadosDeletar) Then
                    index = i
                    Exit For
                End If
            Next

            File.WriteAllText(caminhoDadosUser, String.Empty)

            If index > -1 Then
                lines.RemoveAt(index)

                Dim novaLista As New List(Of String)
                For Each line As String In lines
                    novaLista.Add(line)
                Next

                ' Adicionar nova linha com novos dados
                Dim novaLinha As String = $"{maxIndex + 1},{NewUsernameEditar.Text},{NewPasswordEditar.Text}"
                novaLista.Add(novaLinha)
                File.AppendAllText(caminhoDadosUser, novaLinha)

                File.WriteAllLines(caminhoDadosUser, novaLista)

                carregarDataGrid()
            End If
        End If

    End Sub

    Private Function carregarDataGrid()
        Dim lines As List(Of String) = File.ReadAllLines(caminhoDadosUser).ToList()
        dt.Clear()
        For Each line As String In File.ReadLines(caminhoDadosUser)
            Dim dados As String() = line.Split(","c)

            For i As Integer = 0 To dados.Length - 1
                dados(i) = dados(i).Replace("""", "")
            Next

            If dt.Columns.Count = 0 Then

                For i As Integer = 0 To dados.Length - 1
                    If i = 1 Then
                        dt.Columns.Add("User Name")
                    ElseIf i = 2 Then
                        dt.Columns.Add("Password")
                    Else
                        dt.Columns.Add("Index")
                    End If

                Next
            End If
            dt.Rows.Add(dados)
        Next

        DataGridEdit.DataSource = dt

        DataGridEdit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Function

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        NewUsernameEditar.Text = ""
        NewPasswordEditar.Text = ""
        Me.Close()
        FormMenu.Show()
    End Sub
End Class